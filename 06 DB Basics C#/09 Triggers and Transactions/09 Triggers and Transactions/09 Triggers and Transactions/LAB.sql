--A Transaction is a sequence of actions (database operations) executed as a whole:
-- * Either all of them complete successfully or none of them do
--Examples:
-- * A bank transfer from one account into another (withdrawal + deposit)
-- * If either the withdrawal or the deposit fails the whole operation is cancelled

-- *** Transactions Behavior *** --
--Transactions guarantee the consistency and the integrity of the database
-- * All changes in a transaction are temporary
-- * Changes are persisted when COMMIT is executed
-- * At any time, all changes can be canceled by ROLLBACK
--All changes are persisted at once
-- * As long as COMMIT is called

-- *** Transactions: What Can Go Wrong? *** --
--Some actions fail to complete
-- * The application software or database server crashes
-- * The user cancels the action while it’s in progress
--Interference from another transaction.
-- * What happens if several transfers run for the same account at the same time?

-- Transactions Syntax
--USE Bank
GO
CREATE PROC usp_TransferFunds
(@accountid INT,
 @amount DECIMAL(10, 2)
)
AS
         BEGIN
             BEGIN TRANSACTION;
             UPDATE Accounts
                SET
                    Balance -= @amount
             WHERE Id = @accountid;
             IF @@rowcount <> 1 -- Didn’t affect exactly one row
                 BEGIN
                     ROLLBACK;
                     RAISERROR('Invalid account!', 16, 1);
                     RETURN;
                 END;
             COMMIT;
         END;
GO
--execute
EXEC usp_TransferFunds
     1,
     100.5;
SELECT *
FROM Accounts;

-- *** Transaction Properties *** --
--Modern DBMS servers have built-in transaction support
-- * Implement “ACID” transactions.
-- * E.g. MS SQL Server, Oracle, MySQL, …
--ACID means:
-- * Atomicity
-- * Consistency 
-- * Isolation
-- * Durability

-- *** Atomicity *** --
--Atomicity means that:
--Transactions execute as a whole
--DBMS guarantees that either all of theoperations are performed or none of them
--Example: Transferring funds between bank accounts
--Either withdraw + deposit both succeed, or none of them do
--In case of failure, the database stays unchanged

-- *** Consistency *** --
--Consistency means that:
-- * The database has a legal state in both the transaction’s beginning and end
-- * Only valid data will be written to the DB
-- * Transaction cannot break the rules ofthe database
-- * Primary keys, foreign keys, check constraints…
--Consistency example:
-- * Transaction cannot end with a duplicate primary key in a table

-- *** Isolation *** --
--Isolation means that:
-- * Multiple transactions running at the same time do not impact each other’s execution
-- * Transactions don’t see othertransactions’ uncommitted changes
-- * Isolation level defines how deeptransactions isolate from one another
--Isolation example:
-- * If two or more people try to buy the last copy of a product, only one of them will succeed

-- *** Durability *** --
--Durability means that:
-- * If a transaction is committed it becomes persistent
--   ** Cannot be lost or undone
-- * Ensured by use of database transaction logs
--Durability example:
-- * After funds are transferred and committed the power supply at the DB server is lost
-- * Transaction stays persistent (no data is lost)

-- *** What Are Triggers? *** --
--Triggers are very much like stored procedures.
-- * Called in case of specific event
--We do not call triggers explicitly
-- * Triggers are attached to a table.
-- * Triggers are fired when a certain SQL statement is executed against the contents of the table.
--Syntax:
-- * AFTER INSERT/UPDATE/DELETE
-- * INSTEAD OF INSERT/UPDATE/DELETE

-- *** After Triggers *** --
-- Defined by the keyword FOR
GO
CREATE TRIGGER tr_TownsUpdate ON Towns
FOR UPDATE
AS
     IF EXISTS
              (
                  SELECT *
                  FROM inserted
                  WHERE Name IS NULL
                        OR LEN(Name) = 0
)
         BEGIN
             RAISERROR('Town name cannot be empty.', 16, 1);
             ROLLBACK;
             RETURN;
         END;
GO
-- execute
UPDATE Towns SET Name='' WHERE TownId=1

-- *** Instead Of Triggers *** --
--Defined by using INSTEAD OF
GO
CREATE TABLE Accounts
(Username VARCHAR(10) NOT NULL PRIMARY KEY,
 Password VARCHAR(20) NOT NULL,
 Active NOT NULL
        DEFAULT 'Y'
);
GO

GO
CREATE TRIGGER tr_AccountsDelete ON Accounts
INSTEAD OF DELETE
AS
         BEGIN
             UPDATE a
                SET
                    Active = 'N'
             FROM Accounts AS a
                  JOIN DELETED d ON d.Username = a.Username
             WHERE a.Active = 'Y';
         END;
GO

