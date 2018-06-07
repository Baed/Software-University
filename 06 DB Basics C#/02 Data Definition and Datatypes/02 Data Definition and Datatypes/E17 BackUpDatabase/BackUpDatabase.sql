USE Minions

GO
DROP DATABASE Minions

BACKUP DATABASE Minions
TO DISK = 'C:\My Staff\SoftUni\06 DB Basics C#\02 Data Definition and Datatypes\MinionsBackup.bak'

RESTORE DATABASE Minions
FROM DISK = 'C:\My Staff\SoftUni\06 DB Basics C#\02 Data Definition and Datatypes\MinionsBackup.bak'