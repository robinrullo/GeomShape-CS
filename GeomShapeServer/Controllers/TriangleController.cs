using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Entities.Extensions;

namespace GeomShapeServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TriangleController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryWrapper _repository;

        public TriangleController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var triangles = _repository.Triangle.GetAllTriangles();

                _logger.LogInfo($"Returned all triangles from database.");

                return Ok(triangles.ToArray());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllTriangles action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        
        [HttpGet("{id:guid}", Name = "TriangleById")]
        public IActionResult GetTriangleById(Guid id)
        {
            try
            {
                var triangle = _repository.Triangle.GetTriangleById(id);

                if (triangle.IsEmptyObject())
                {
                    _logger.LogError($"Triangle with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _logger.LogInfo($"Returned triangle with id: {id}");
                return Ok(triangle);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetTriangleById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        
        [HttpPost]
        public IActionResult CreateTriangle([FromBody]Triangle triangle)
        {
            try
            {
                if (triangle.IsObjectNull())
                {
                    _logger.LogError("Triangle object sent from client is null.");
                    return BadRequest("Triangle object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid triangle object sent from client.");
                    return BadRequest("Invalid model object");
                }

                _repository.Triangle.CreateTriangle(triangle);

                return CreatedAtRoute("TriangleById", new { id = triangle.Id }, triangle);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateTriangle action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateTriangle(Guid id, [FromBody]Triangle triangle)
        {
            try
            {
                if (triangle.IsObjectNull())
                {
                    _logger.LogError("Triangle object sent from client is null.");
                    return BadRequest("Triangle object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid triangle object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var dbTriangle = _repository.Triangle.GetTriangleById(id);
                if (dbTriangle.IsEmptyObject())
                {
                    _logger.LogError($"Triangle with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _repository.Triangle.UpdateTriangle(dbTriangle, triangle);

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside UpdateTriangle action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteTriangle(Guid id)
        {
            try
            {
                var triangle = _repository.Triangle.GetTriangleById(id);
                if (triangle.IsEmptyObject())
                {
                    _logger.LogError($"Triangle with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _repository.Triangle.DeleteTriangle(triangle);

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside DeleteTriangle action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}