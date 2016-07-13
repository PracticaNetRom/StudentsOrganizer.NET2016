drop table Login;

CREATE TABLE Login(
    ID int Primary Key not null IDENTITY (1,1),
	Username varchar(30) not null,
	Password varchar(30) not null,

);

Insert INTO Login (Username, Password)  Values( 'user1', '1234');

select * from Login;