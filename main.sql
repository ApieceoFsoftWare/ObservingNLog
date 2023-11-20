CREATE DATABASE UdemyNLogDatabase
go
use UdemyNlogDatabase
go

CREATE TABLE LOGME
(
	ID int identity(1,1) primary key,
	Levels nvarchar(20),
	Message nvarchar(MAX),
	CreationDate DateTime
)
go

CREATE PROC SAVEtoLOGME
(
	@Levels nvarchar(20),
	@Message nvarchar(MAX)
)	
as 
begin
	INSERT INTO LOGME (Levels, Message, CreationDate)
	VALUES (@Levels, @Message, GETDATE())
end