USE master
IF(db_id(N'EmployeesAndRewards')) IS NOT NULL
	DROP DATABASE EmployeesAndRewards

CREATE DATABASE EmployeesAndRewards
GO

USE EmployeesAndRewards

CREATE TABLE Employees(
	[Id] int not null primary key identity(1,1),
	[LastName] nvarchar(150),
	[FirstName] nvarchar(150),
	[Birth] DateTime2
	)
GO

CREATE TABLE Rewards(
	[Id] int not null primary key identity(1,1),
	[Title] nvarchar(150),
	[Description] nvarchar(150)
	)
GO

CREATE PROCEDURE InitListEmployee
AS
BEGIN
INSERT INTO Employees
VALUES(N'Employee 1','1', '2000-10-02'),
(N'Employee 3','1', '2000-10-02'),
(N'Employee 4','1', '2000-10-02')
END
GO

CREATE PROCEDURE InitListReward
AS
BEGIN
INSERT INTO Rewards
VALUES(N'nobel prize', N'epic reward'),
(N'another prize', 'common reward')
END
GO

CREATE TABLE Relations(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[EmployeeId] INT NOT NULL,
	[RewardId] INT NOT NULL,
	FOREIGN KEY (EmployeeId) REFERENCES Employees(Id) ON DELETE CASCADE,
	FOREIGN KEY (RewardId) REFERENCES Rewards(Id) ON DELETE CASCADE,
	)
GO

CREATE PROCEDURE InitListRelations
AS
BEGIN
INSERT INTO Relations
VALUES(1, 1), (1,2),(2,2)
END
GO

CREATE PROCEDURE AddRewards(
	@title nvarchar(150),
	@description nvarchar(150))
AS
BEGIN
	INSERT INTO Rewards
	VALUES(@title, @description)
END
GO

CREATE TYPE RewardsIds
AS TABLE(id int)
GO

CREATE PROCEDURE AddEmployee(
	@lastname nvarchar(150),
	@firstname nvarchar(150),
	@birth DateTime2,
	@rewardIds RewardsIds readonly)
AS
BEGIN
	DECLARE @employeeId AS TABLE(id int)
	INSERT INTO Employees
	OUTPUT Inserted.Id INTO @employeeId
	VALUES(@lastname,@firstname, @birth)
	INSERT INTO Relations
	SELECT [@employeeId].id, [@rewardIds].id FROM @rewardIds, @employeeId
END
GO

CREATE PROCEDURE GetEmployees
AS
BEGIN	
	SELECT [Id],[LastName],[FirstName],[Birth]
		FROM [Employees]
END
GO

CREATE PROCEDURE GetEmployeeById(@id int)
AS
	SELECT [Id],[LastName],[FirstName],[Birth]
		FROM [Employees]
			WHERE Id = @id
GO

CREATE PROCEDURE InsertEmployee(
	@lastName nvarchar(100),
	@firstName nvarchar(100),
	@birth DateTime2)
AS
	DECLARE @insertedEmployee TABLE (EmployeeId int);
	INSERT INTO [Employees](LastName, FirstName, Birth)
		OUTPUT INSERTED.Id INTO @insertedEmployee(EmployeeId)
			VALUES( @lastName, @firstName, @birth)
	SELECT EmployeeId FROM @insertedEmployee
GO

CREATE PROCEDURE DeleteEmployee(@employeeId int)
AS
	DELETE FROM [Employees] WHERE Id = @employeeId;
GO

CREATE PROCEDURE GetRewards
AS
	SELECT [Id], [Title], [Description]
		FROM [Rewards]
GO

CREATE PROCEDURE GetRewardsById(@id int)
AS
	SELECT [Id], [Title], [Description]
		FROM [Rewards]
			WHERE Id = @id
GO

CREATE PROCEDURE DeleteReward(@rewardId int)
AS
	DELETE FROM [Rewards] WHERE Id = @rewardId;
GO

CREATE PROCEDURE GetRewardsForEmployeeById(@idemployee int)
AS
	SELECT Rewards.Id,Title,[Description]
		FROM [Relations]
			LEFT JOIN Rewards ON Relations.RewardId =  Rewards.Id
				WHERE [Relations].EmployeeId = @idemployee;
GO


CREATE PROCEDURE UpdateEmployee(@id int,@lastName nvarchar(150),@firstName nvarchar(150),@birth DateTime2)
AS
	UPDATE [Employees] SET [LastName] = @lastName,[FirstName] = @firstName,[Birth] = @birth
		WHERE Id = @id

GO

CREATE PROCEDURE UpdateReward(@id int,@title nvarchar(150),@description nvarchar(150))
AS
	UPDATE [Rewards] SET [Title] = @title, [Description] = @description
		WHERE Id = @id
GO

CREATE PROCEDURE UpdateEmployeers
AS
SELECT * FROM dbo.Employees
GO

BEGIN
DECLARE @Rewards RewardsIds;
INSERT INTO @Rewards VALUES(1),(2)

EXEC InitListEmployee
EXEC InitListReward
EXEC InitListRelations
EXEC AddEmployee N'Employee 123', N'1', N'2000-01-01', @Rewards
EXEC GetRewardsForEmployeeById 1
EXEC UpdateReward 2,апрапррпба,прорпо
--DELETE FROM dbo.Employees
--WHERE id IN (SELECT TOP(2) id FROM dbo.Employees)
--SELECT * FROM dbo.Rewards 
--SELECT * FROM dbo.Employees
END
--ANN\SQLEXPRESS