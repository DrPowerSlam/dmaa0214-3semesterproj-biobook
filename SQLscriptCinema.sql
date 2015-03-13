use dmaa0214_3Sem_2

create table Customer
(
cusID int IDENTITY(1,1),
name varchar(30), 

primary key(cusID)

);



create table Movie
(
movieID int IDENTITY(1,1),
name varchar(30), 
playtime time,
primary key(movieID)
);

create table Hall
(
hallID int IDENTITY(1,1),
name varchar(30), 
maxNumberOfSeats int
primary key(hallID)
);


create table Scheduler
(
schID int IDENTITY(1,1),
Datetime Date,
starttime Time,
movieID int ,
hallID int ,
foreign key(movieID) references Movie(movieID),
primary key(schID)


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
resID int IDENTITY(1,1),
customerID int, 
schedulerID int,
rowArray varchar(MAX),
seatArray varchar(MAX),
foreign key(customerID) references Customer(cusID),
primary key(resID)
);