Create DataBase Assessment4

Create table Companies
(
	CompanyId int Primary Key,
    Name Varchar(100),
    City varchar(100),
    Address Varchar(255)
)

Create table Students 
(
    StudentId int Primary Key,
    Name Varchar(30),
    Qualification Varchar(50),
    Skill Varchar(50)
)

insert into Companies(CompanyId, Name, City, Address )Values
(101, 'Dell', 'Hyd', 'HiTechCity'),
(102, 'HP', 'Chicago', 'New Yark'),
(103, 'Apple', 'Texes', 'Dallas')


insert into Students(StudentId, Name, Qualification, Skill )Values
(1, 'Vasu', 'BTech', 'Python'),
(2, 'Mamatha', 'BTech', 'Java'),
(3, 'Sai', 'MTech', 'SQL')