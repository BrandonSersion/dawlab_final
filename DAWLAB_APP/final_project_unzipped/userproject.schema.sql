

CREATE SCHEMA IF NOT EXISTS`userproject1` ;
USE `userproject1` ;

DROP TABLE IF EXISTS `user`;
CREATE TABLE `userproject1`.`user` (
  `user_id` INT(10) UNSIGNED NOT NULL,
  `user_name` VARCHAR(45) NOT NULL,
  `password` CHAR(60) NOT NULL,
  `join_date` DATETIME NOT NULL,
  `first_name` VARCHAR(45) NULL,
  `last_name` VARCHAR(45) NULL,
  `is_admin` TINYINT(1) NULL DEFAULT 0,
  `email` VARCHAR(255) NULL,
  PRIMARY KEY (`user_id`));
  
  INSERT INTO `user` VALUES (2, 'Wudist2', 'Aycheh2', 3/4/2107, 'Wudist', 'Aycheh', 2, 'wudistaycheh@yahoo.com'),
							(1, 'Lintonio', 'Aycheh2', 3/4/2107, 'Wudist', 'Aycheh', 2, 'wudistaycheh@yahoo.com');
  