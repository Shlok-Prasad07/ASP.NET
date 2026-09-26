--- create a database table ---

create database asp_lab9

---- create table for student ----

create table student(
	Stu_id INT AUTO_INCREMENT PRIMARY KEY,
	Enrollment_No varchar(11),
	Student_Name varchar(30),
	Semester int,
	SPI decimal(4,2),
	CPI decimal(4,2),
);

Select * from student;

---- create a store proc to select,insert,update,delete ----

CREATE PROC stu_CRUD
(
	@Stu_id INT = NULL,
	@Enrollment_No varchar(11)=null,
	@Student_Name varchar(20)=null,
	@Semester int = 0,
	@SPI decimal(4,2)=0,
	@CPI decimal(4,2)=0, @Event nvarchar(50)=null)
AS 
BEGIN
    IF (@Event = 'Select')
    BEGIN
        SELECT * FROM student;
    END
	ELSE IF(@Event = 'SelectbyID')
	BEGIN
		SELECT Enrollment_No,Student_Name,Semester,SPI,CPI FROM student WHERE Stu_id=@Stu_id
	END
    ELSE IF (@Event = 'Add')
    BEGIN
        INSERT INTO student (Enrollment_No,Student_Name,Semester,SPI,CPI)
        VALUES (@Enrollment_No,@Student_Name,@Semester,@SPI,@CPI);
    END
    ELSE IF (@Event = 'Update')
    BEGIN
        UPDATE student
        SET Enrollment_No=@Enrollment_No,Student_Name=@Student_Name,Semester=@Semester,SPI=@SPI,CPI=@CPI WHERE Stu_id = @Stu_id;
    END
    ELSE
    BEGIN
        DELETE FROM student WHERE Stu_id=@Stu_id;
    END
END

--------- insert,update,delete,featch data sql query ---------

EXEC stu_CRUD 
    @Enrollment_No='ENR101',
    @Student_Name='Shlok',
    @Semester=3,
    @SPI=8.20,
    @CPI=8.00,
    @Event='Add';

EXEC stu_CRUD 
    @Stu_id=101,
    @Enrollment_No='23020201134',
    @Student_Name='Shlok Prasad',
	@Semester=5,
    @SPI=9.05,
    @CPI=9.13,
    @Event='Update';

EXEC stu_CRUD 
    @Stu_id=101,
    @Event='Delete';

EXEC stu_CRUD @Event='Select';
