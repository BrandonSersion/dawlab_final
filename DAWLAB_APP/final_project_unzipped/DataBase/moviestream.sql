-- creating database

CREATE DATABASE  IF NOT EXISTS `moviestream`;
USE `moviestream`;

-- creating  user table
DROP TABLE IF EXISTS `user`; 
CREATE TABLE `moviestream`.`user` (
  `user_id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `user_name` VARCHAR(50) NOT NULL,
  `password` CHAR(60) NOT NULL,
  `join_date` DATETIME NOT NULL,
  `firstname` VARCHAR(45) NULL,
  `lastname` VARCHAR(45) NULL,
  `admin` TINYINT(1) NULL DEFAULT 0,
  PRIMARY KEY (`user_id`),
  UNIQUE INDEX `user_name_UNIQUE` (`user_name` ASC));
  ALTER TABLE `moviestream`.`user` 
ADD UNIQUE INDEX `user_id_UNIQUE` (`user_id` ASC);

ALTER TABLE `moviestream`.`user` 
CHANGE COLUMN `user_id` `user_id` INT(10) UNSIGNED NOT NULL ;

ALTER TABLE `moviestream`.`user` 
CHANGE COLUMN `user_id` `user_id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT ;



-- create movie table
DROP TABLE IF EXISTS `movie`;
CREATE TABLE `moviestream`.`movie` (
  `movie_id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `user_id` INT(10) NOT NULL,
  `title` VARCHAR(60) NOT NULL,
  `runtime` FLOAT NOT NULL,
  `discribtion` TEXT(300) NOT NULL,
  PRIMARY KEY (`movie_id`),
  UNIQUE INDEX `movie_id_UNIQUE` (`movie_id` ASC),
  UNIQUE INDEX `title_UNIQUE` (`title` ASC),
  CONSTRAINT `user_id`
    FOREIGN KEY (`movie_id`)
    REFERENCES `moviestream`.`user` (`user_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
    
    ALTER TABLE `moviestream`.`movie` 
DROP FOREIGN KEY `user_id`;
ALTER TABLE `moviestream`.`movie` 
DROP COLUMN `user_id`;

ALTER TABLE `moviestream`.`movie` 
CHANGE COLUMN `movie_id` `movie_id` INT(10) NOT NULL AUTO_INCREMENT ;

 ALTER TABLE `moviestream`.`movie` 
CHANGE COLUMN `movie_id` `movie_id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT ; 

ALTER TABLE `moviestream`.`movie` 
DROP INDEX `movie_id_UNIQUE` ;
ALTER TABLE `moviestream`.`movie` 
ADD UNIQUE INDEX `movie_id_UNIQUE` (`movie_id` ASC);

ALTER TABLE `moviestream`.`movie` 
DROP INDEX `movie_id_UNIQUE` ;

-- create user_movie Intermidiat table

CREATE TABLE `moviestream`.`user_movie` (
  `user_id` INT(10) UNSIGNED NOT NULL,
  `movie_id` INT(10) UNSIGNED NOT NULL,
  INDEX `user_id_idx` (`user_id` ASC),
  INDEX `movie_id_idx` (`movie_id` ASC),
  CONSTRAINT `user_id`
    FOREIGN KEY (`user_id`)
    REFERENCES `moviestream`.`user` (`user_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `movie_id`
    FOREIGN KEY (`movie_id`)
    REFERENCES `moviestream`.`movie` (`movie_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- create actors table
CREATE TABLE `moviestream`.`actors` (
  `actor_id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `actor_name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`actor_id`),
  UNIQUE INDEX `actor_id_UNIQUE` (`actor_id` ASC));
  
  ALTER TABLE `moviestream`.`actors` 
CHANGE COLUMN `actor_id` `actor_id` INT(10) UNSIGNED NOT NULL ,
DROP INDEX `actor_id_UNIQUE` ;
  