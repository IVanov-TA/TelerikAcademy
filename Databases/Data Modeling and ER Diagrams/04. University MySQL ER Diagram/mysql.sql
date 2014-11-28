SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `univesities` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `univesities` ;

-- -----------------------------------------------------
-- Table `univesities`.`Univesities`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `univesities`.`Univesities` (
  `UnivesityID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`UnivesityID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `univesities`.`Faculties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `univesities`.`Faculties` (
  `FacultyID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NULL,
  `univesities_UnivesityID` INT NOT NULL,
  PRIMARY KEY (`FacultyID`),
  INDEX `fk_Departments_univesities1_idx` (`univesities_UnivesityID` ASC),
  CONSTRAINT `fk_Departments_univesities1`
    FOREIGN KEY (`univesities_UnivesityID`)
    REFERENCES `univesities`.`Univesities` (`UnivesityID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `univesities`.`Departments_has_Departments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `univesities`.`Departments_has_Departments` (
  `Departments_DepartmentID` INT NOT NULL,
  `Departments_DepartmentID1` INT NOT NULL,
  PRIMARY KEY (`Departments_DepartmentID`, `Departments_DepartmentID1`),
  INDEX `fk_Departments_has_Departments_Departments1_idx` (`Departments_DepartmentID1` ASC),
  INDEX `fk_Departments_has_Departments_Departments_idx` (`Departments_DepartmentID` ASC),
  CONSTRAINT `fk_Departments_has_Departments_Departments`
    FOREIGN KEY (`Departments_DepartmentID`)
    REFERENCES `univesities`.`Faculties` (`FacultyID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Departments_has_Departments_Departments1`
    FOREIGN KEY (`Departments_DepartmentID1`)
    REFERENCES `univesities`.`Faculties` (`FacultyID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `univesities`.`Departments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `univesities`.`Departments` (
  `DepartmentsID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  `Faculties_FacultyID` INT NOT NULL,
  PRIMARY KEY (`DepartmentsID`),
  INDEX `fk_Departments_Faculties1_idx` (`Faculties_FacultyID` ASC),
  CONSTRAINT `fk_Departments_Faculties1`
    FOREIGN KEY (`Faculties_FacultyID`)
    REFERENCES `univesities`.`Faculties` (`FacultyID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `univesities`.`Professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `univesities`.`Professors` (
  `ProfesorID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NOT NULL,
  `` VARCHAR(45) NULL,
  `DepartmentsID` INT NOT NULL,
  PRIMARY KEY (`ProfesorID`),
  INDEX `fk_Professors_Departments1_idx` (`DepartmentsID` ASC),
  CONSTRAINT `fk_Professors_Departments1`
    FOREIGN KEY (`DepartmentsID`)
    REFERENCES `univesities`.`Departments` (`DepartmentsID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `univesities`.`Titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `univesities`.`Titles` (
  `TitlesID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`TitlesID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `univesities`.`Professor_Title`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `univesities`.`Professor_Title` (
  `ProfesorID` INT NOT NULL,
  `TitlesID` INT NOT NULL,
  INDEX `fk_Professors_Titles_Titles1_idx` (`TitlesID` ASC),
  PRIMARY KEY (`ProfesorID`, `TitlesID`),
  CONSTRAINT `fk_Professors_Titles_Professors1`
    FOREIGN KEY (`ProfesorID`)
    REFERENCES `univesities`.`Professors` (`ProfesorID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Professors_Titles_Titles1`
    FOREIGN KEY (`TitlesID`)
    REFERENCES `univesities`.`Titles` (`TitlesID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `univesities`.`Courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `univesities`.`Courses` (
  `CourseID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  `Coursescol` VARCHAR(45) NULL,
  `Departments_DepartmentsID` INT NOT NULL,
  PRIMARY KEY (`CourseID`),
  INDEX `fk_Courses_Departments1_idx` (`Departments_DepartmentsID` ASC),
  CONSTRAINT `fk_Courses_Departments1`
    FOREIGN KEY (`Departments_DepartmentsID`)
    REFERENCES `univesities`.`Departments` (`DepartmentsID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `univesities`.`Professor_Course`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `univesities`.`Professor_Course` (
  `ProfesorID` INT NOT NULL,
  `CourseID` INT NOT NULL,
  PRIMARY KEY (`ProfesorID`, `CourseID`),
  INDEX `fk_Professor_Course_Courses1_idx` (`CourseID` ASC),
  CONSTRAINT `fk_Professor_Course_Professors1`
    FOREIGN KEY (`ProfesorID`)
    REFERENCES `univesities`.`Professors` (`ProfesorID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Professor_Course_Courses1`
    FOREIGN KEY (`CourseID`)
    REFERENCES `univesities`.`Courses` (`CourseID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `univesities`.`Students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `univesities`.`Students` (
  `StudentID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  `FacultyID` INT NOT NULL,
  PRIMARY KEY (`StudentID`),
  INDEX `fk_Students_Faculties1_idx` (`FacultyID` ASC),
  CONSTRAINT `fk_Students_Faculties1`
    FOREIGN KEY (`FacultyID`)
    REFERENCES `univesities`.`Faculties` (`FacultyID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `univesities`.`Student_Course`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `univesities`.`Student_Course` (
  `StudentID` INT NOT NULL,
  `CourseID` INT NOT NULL,
  PRIMARY KEY (`StudentID`, `CourseID`),
  INDEX `fk_Student_Course_Courses1_idx` (`CourseID` ASC),
  CONSTRAINT `fk_Student_Course_Students1`
    FOREIGN KEY (`StudentID`)
    REFERENCES `univesities`.`Students` (`StudentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Student_Course_Courses1`
    FOREIGN KEY (`CourseID`)
    REFERENCES `univesities`.`Courses` (`CourseID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
