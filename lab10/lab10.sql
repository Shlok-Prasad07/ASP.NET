--- create a database table ---

create database asp_lab10

---- create table for student ----

create table faculty(
	Faculty_ID INT Identity(1,1) PRIMARY KEY,
	Faculty_FirstName varchar(30),
	Faculty_LastName varchar(30),
	Faculty_ContactNo bigint,
	Faculty_EmailID nvarchar(60)
);

Select * from faculty;

---- create a store proc to select,insert,update,delete ----

CREATE PROC faculty_CRUD
(
	@Faculty_ID INT = null,
	@Faculty_FirstName varchar(30) = null,
	@Faculty_LastName varchar(30) = null,
	@Faculty_ContactNo bigint = 0,
	@Faculty_EmailID nvarchar(60) = null,
	@Event nvarchar(50)=null)
AS 
BEGIN
    IF (@Event = 'Select')
    BEGIN
        SELECT * FROM faculty;
    END
	ELSE IF(@Event = 'SelectbyID')
	BEGIN
		SELECT Faculty_FirstName,Faculty_LastName,Faculty_ContactNo,Faculty_EmailID FROM faculty WHERE Faculty_ID=@Faculty_ID
	END
    ELSE IF (@Event = 'Add')
    BEGIN
        INSERT INTO faculty (Faculty_FirstName,Faculty_LastName,Faculty_ContactNo,Faculty_EmailID)
        VALUES (@Faculty_FirstName,@Faculty_LastName,@Faculty_ContactNo,@Faculty_EmailID);
    END
    ELSE IF (@Event = 'Update')
    BEGIN
        UPDATE faculty SET Faculty_FirstName=@Faculty_FirstName,Faculty_LastName=@Faculty_LastName,Faculty_ContactNo=@Faculty_ContactNo,Faculty_EmailID=@Faculty_EmailID WHERE Faculty_ID=@Faculty_ID;
    END
    ELSE
    BEGIN
        DELETE FROM faculty WHERE Faculty_ID=@Faculty_ID;
    END
END


