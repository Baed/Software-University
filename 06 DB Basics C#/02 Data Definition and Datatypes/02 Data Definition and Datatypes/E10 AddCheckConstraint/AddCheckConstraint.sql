USE Minions

SELECT * FROM Users

/*   ADD CHECK CONSTRAINT  */

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY (id, Username)

ALTER TABLE Users
ADD CONSTRAINT CHK_ProfilePectureSize CHECK (DATALENGTH(ProfilePicture) <= 900 * 1024) /*   1 kB = 1024 B  */

ALTER TABLE Users
ADD CONSTRAINT CHK_PasswordSize CHECK (DATALENGTH(Password) >= 5)






