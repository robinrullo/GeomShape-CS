-- MySQL Script generated by MySQL Workbench
-- Sat Sep 11 14:49:22 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema shape
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `shape` ;

-- -----------------------------------------------------
-- Schema shape
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `shape` DEFAULT CHARACTER SET utf8 ;
USE `shape` ;

-- -----------------------------------------------------
-- Table `shape`.`circle`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `shape`.`circle` ;

CREATE TABLE IF NOT EXISTS `shape`.`circle` (
  `Id` CHAR(36) NOT NULL,
  `shapeId` VARCHAR(45) NOT NULL,
  `offsetX` DOUBLE NOT NULL,
  `offsetY` DOUBLE NOT NULL,
  `radius` FLOAT NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `shape`.`rectangle`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `shape`.`rectangle` ;

CREATE TABLE IF NOT EXISTS `shape`.`rectangle` (
  `Id` CHAR(36) NOT NULL,
  `shapeId` VARCHAR(45) NOT NULL,
  `offsetX` DOUBLE NOT NULL,
  `offsetY` DOUBLE NOT NULL,
  `lengthA` FLOAT NOT NULL,
  `lengthB` FLOAT NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `shape`.`triangle`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `shape`.`triangle` ;

CREATE TABLE IF NOT EXISTS `shape`.`triangle` (
  `Id` CHAR(36) NOT NULL,
  `shapeId` VARCHAR(45) NOT NULL,
  `offsetX` DOUBLE NOT NULL,
  `offsetY` DOUBLE NOT NULL,
  `lengthA` FLOAT NOT NULL,
  `lengthB` FLOAT NOT NULL,
  `lengthC` FLOAT NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
