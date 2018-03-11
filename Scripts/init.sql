 use master;

IF OBJECT_ID('dbo.TestUser', 'U') IS NOT NULL 
  DROP TABLE dbo.TestUser;

 Create table TestUser(
     id int IDENTITY(1,1) primary key,
     name nvarchar(50),
     lastname nvarchar(50)
 )
  
 Insert into TestUser (name,lastname) values ('Norbert','Tesla');
 Insert into TestUser (name,lastname) values ('Alicja','Bell');
 Insert into TestUser (name,lastname) values ('Marian','Watson');
 Insert into TestUser (name,lastname) values ('Katarzyna','Holmes');