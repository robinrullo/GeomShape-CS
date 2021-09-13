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
    public class DrawingController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryWrapper _repository;

        public DrawingController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var drawings = _repository.Drawing.GetAllDrawings();

                _logger.LogInfo($"Returned all drawings from database.");

                return Ok(drawings.ToArray());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllDrawings action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        
        [HttpGet("{id:guid}", Name = "DrawingById")]
        public IActionResult GetDrawingById(Guid id)
        {
            try
            {
                var drawing = _repository.Drawing.GetDrawingById(id);

                if (drawing.IsEmptyObject())
                {
                    _logger.LogError($"Drawing with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _logger.LogInfo($"Returned drawing with id: {id}");
                return Ok(drawing);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetDrawingById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        
        [HttpPost]
        public IActionResult CreateDrawing([FromBody]Drawing drawing)
        {
            try
            {
                if (drawing.IsObjectNull())
                {
                    _logger.LogError("Drawing object sent from client is null.");
                    return BadRequest("Drawing object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid drawing object sent from client.");
                    return BadRequest("Invalid model object");
                }

                _repository.Drawing.CreateDrawing(drawing);

                return CreatedAtRoute("DrawingById", new { id = drawing.Id }, drawing);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateDrawing action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateDrawing(Guid id, [FromBody]Drawing drawing)
        {
            try
            {
                if (drawing.IsObjectNull())
                {
                    _logger.LogError("Drawing object sent from client is null.");
                    return BadRequest("Drawing object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid drawing object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var dbDrawing = _repository.Drawing.GetDrawingById(id);
                if (dbDrawing.IsEmptyObject())
                {
                    _logger.LogError($"Drawing with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _repository.Drawing.UpdateDrawing(dbDrawing, drawing);

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside UpdateDrawing action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteDrawing(Guid id)
        {
            try
            {
                var drawing = _repository.Drawing.GetDrawingById(id);
                if (drawing.IsEmptyObject())
                {
                    _logger.LogError($"Drawing with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _repository.Drawing.DeleteDrawing(drawing);

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside DeleteDrawing action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}