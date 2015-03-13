use dmaa0214_3Sem_2

create table Customer
(
CusID int IDENTITY(1,1),
name varchar(30), 

primary key(CusID)

);



create table Movie
(
MovieID int IDENTITY(1,1),
name varchar(30), 
Playtime time,
primary key(MovieID)
);

create table Hall
(
HallID int IDENTITY(1,1),
name varchar(30), 
MaxNumberOfSeats int
primary key(HallID)
);


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