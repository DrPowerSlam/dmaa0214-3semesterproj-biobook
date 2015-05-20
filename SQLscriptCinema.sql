use dmaa0214_3Sem_2

IF OBJECT_ID('Reservation', 'U') IS NOT NULL
	DROP TABLE Reservation;
IF OBJECT_ID('Seat', 'U') IS NOT NULL
	DROP TABLE Seat;
IF OBJECT_ID('Scheduler', 'U') IS NOT NULL
	DROP TABLE Scheduler;
IF OBJECT_ID('Customer', 'U') IS NOT NULL
	DROP TABLE Customer;
IF OBJECT_ID('Movie', 'U') IS NOT NULL
	DROP TABLE Movie;
IF OBJECT_ID('Hall', 'U') IS NOT NULL
	DROP TABLE Hall;


create table Customer
(
CusID int IDENTITY(1,1),
name varchar(30), 
phoneNumber varchar(20),
password varchar(50),
Mail varchar(50),

primary key(CusID)

);
insert into Customer values ('Jens', '+4520304051', '20302020','******');
insert into Customer values ('Kaj', '+4520324050','20302020','******');
insert into Customer values ('Tue', '+4520304056','20302020','******');
insert into Customer values ('Hamun', '+4520354050','20302020','******');
insert into Customer values ('Renee', '+4522304050','20302020','******');

create table Movie
(
MovieID int IDENTITY(1,1),
name varchar(30), 
Playtime int,
Price int,
Image varchar(50),
unique(name),
primary key(MovieID)
);

insert into Movie values ('Spiderman', 60, 100, 'spiderman.jpg');
insert into Movie values ('Super-Man', 80, 100, 'superman.jpg');
insert into Movie values ('Lord of the Rings', 300, 100, 'Lordoftherings.jpg');

create table Hall
(
HallID int IDENTITY(1,1),
name varchar(30), 
MaxNumberOfSeats int
primary key(HallID)
);

insert into Hall values ('Blue', 90);
insert into Hall values ('Red', 100);
insert into Hall values ('Green', 110);


create table Scheduler
(
SchID int IDENTITY(1,1),
Datetime Date,
Starttime Time,
MovieID int ,
HallID int ,
foreign key(MovieID) references Movie(MovieID) on delete set default,
foreign key(HallID) references Hall(HallID),
primary key(SchID)
);

create table Seat
(
ID int IDENTITY(1,1),
Row int,
ColumnArray varchar(MAX),
SchedulerID int,

foreign key(SchedulerID) references Scheduler(SchID) on delete cascade,
primary key(ID)
);

create table Reservation
(
ResID int IDENTITY(1,1),
CustomerID int, 
SchedulerID int,
Row varchar(MAX),
Seat varchar(MAX),
foreign key(CustomerID) references Customer(CusID) on delete cascade,
foreign key(SchedulerID) references Scheduler(SchID) on delete set default,
primary key(ResID)
);


