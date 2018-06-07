USE Minions

SELECT * FROM Users

/*   SET DEFAULT VALUE TIME OF LAST_LOGIN_TIME  */

ALTER TABLE Users
ADD DEFAULT GETDATE() FOR LastLoginTime

/*** INSERT VALUES TIME IN TABLE ***/

INSERT INTO Users
(Username, Password, IsDeleted)
VALUES
('Angel', '123456', 1),
('Trayan', '55554d', 1)


