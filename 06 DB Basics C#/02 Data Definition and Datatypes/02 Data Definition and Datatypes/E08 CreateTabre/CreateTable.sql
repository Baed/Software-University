USE master
GO

CREATE DATABASE Minions

USE Minions

CREATE TABLE Users(
Id BIGINT IDENTITY PRIMARY KEY NOT NULL,
Username VARCHAR(30) UNIQUE NOT NULL,
Password  VARCHAR(26) NOT NULL,
ProfilePicture VARBINARY(MAX),
LastLoginTime DATETIME,
IsDeleted BIT 
)

INSERT INTO Users 
(Username, Password, ProfilePicture, LastLoginTime, IsDeleted)
VALUES
('Angel', '123456', NULL, NULL, 1),
('Haralampi', '25852', NULL, NULL, 0),
('Daniel', '4563', NULL, NULL, 0),
('Evgeni', '24621', NULL, NULL, 1),
('Stavri', '213521', NULL, NULL, 0)

SELECT * FROM Users