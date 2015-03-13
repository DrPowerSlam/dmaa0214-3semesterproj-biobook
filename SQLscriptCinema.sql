use dmaa0214_3Sem_2

IF OBJECT_ID('db_owner.Customer', 'U') IS NOT NULL
	DROP TABLE db_owner.Customer;
IF OBJECT_ID('db_owner.Movie', 'U') IS NOT NULL
	DROP TABLE db_owner.Movie;
IF OBJECT_ID('db_owner.Hall', 'U') IS NOT NULL
	DROP TABLE db_owner.Hall;
IF OBJECT_ID('db_owner.Scheduler', 'U') IS NOT NULL
	DROP TABLE db_owner.Scheduler;
IF OBJECT_ID('db_owner.Seat', 'U') IS NOT NULL
	DROP TABLE db_owner.Seat;
IF OBJECT_ID('db_owner.Reservation', 'U') IS NOT NULL
	DROP TABLE db_owner.Reservation;

create table Customer
(
CusID int IDENTITY(1,1),
name varchar(30), 
primary key(CusID)
);

INSERT INTO Customer VALUES('Kaj');
INSERT INTO Customer VALUES('Rene');
INSERT INTO Customer VALUES('Tue');
INSERT INTO Customer VALUES('Hamun');

create table Movie
(
MovieID int IDENTITY(1,1),
name varchar(70), 
Playtime int,
primary key(MovieID)
);

INSERT INTO Movie VALUES('Superman', 120);
INSERT INTO Movie VALUES('Spider-Man', 90);
INSERT INTO Movie VALUES('Lord of the Rings', 180);

create table Hall
(
HallID int IDENTITY(1,1),
name varchar(30), 
MaxNumberOfSeats int
primary key(HallID)
);

INSERT INTO Hall VALUES('Imperial', 90);
INSERT INTO Hall VALUES('Green', 100);
INSERT INTO Hall VALUES('Red', 110);

create table Scheduler
(
SchID int IDENTITY(1,1),
Datetime Date,
Starttime Time,
MovieID int ,
HallID int ,
foreign key(MovieID) references Movie(MovieID),
primary key(SchID)
);

create table Seat
(
ID int IDENTITY(1,1),
Row int,
ColumnArray varchar(MAX),
SchedulerID int,
primary key(ID)
);

create table Reservation
(
ResID int IDENTITY(1,1),
CustomerID int, 
SchedulerID int,
RowArray varchar(MAX),
SeatArray varchar(MAX),
foreign key(CustomerID) references Customer(CusID),
primary key(ResID)
);