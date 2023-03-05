create database Trains
drop database Trains
create table Stations(
StationID int primary key not null,
StationName varchar(max),
LocationSt varchar(max),
ZipCode char(4)
)

create table TrainRoute(
RouteID int primary key not null,
Duration int,
BeginningStation varchar(max),
EndingStation varchar(max)
)

create table TicketClerk(
ClerkID int primary key not null,
FirstName varchar(max),
LastName varchar(max),
Email varchar(max)  --add constraint 
)

create table Trains (
TrainID int primary key not null,
StationID int not null foreign key references Stations(StationID),
ArrivesFrom varchar(255),
DepartsTo varchar(255),
RouteID int not null foreign key references TrainRoute(RouteID)
)

create table Ticket(
TicketID int not null primary key,
SeatNo int,
TicketClass varchar(max),
TrainID int not null foreign key references Trains(TrainID)
)

create table Schedule(
LogID int primary key,
StationID int foreign key references Stations(StationID),
TrainID int foreign key references Trains(TrainID),
Arrival datetime,
Departure datetime,
DelayMinutes int
)

create table Passenger (
PassengerID int primary key,
Last_Name varchar(255),
First_Name varchar(255),
Age int not null,
TelephoneNo varchar(255),
TicketID int foreign key references Ticket(TicketID)
)

create table SignUp (
userID int primary key,
username varchar(max),
pswrd varchar(max),
email varchar(max),
telephone varchar(255),
PassengerID int foreign key references Passenger(PassengerID)
)

create table Booking (
TransactionID int primary key,
TicketID int foreign key references Ticket(TicketID),
Price int,
PassengerID int foreign key references Passenger(PassengerID),
Date datetime,
ClerkID int foreign key references TicketClerk(ClerkID)
)

--2023--
drop table SignUp;
drop table Passenger;
drop table Booking;

create table SignUp(
userID int primary key identity(1,1),
FirstName varchar(max),
LastName varchar(max),
username varchar(max),
pswrd varchar(max),
email varchar(max),
telephone varchar(255))

create table Passenger (
PassengerID int primary key,
userID int foreign key references SignUp(userID),
TicketID int foreign key references Ticket(TicketID))

insert into SignUp(FirstName, LastName, username, pswrd, email, telephone) values ('serg', 'ar', 'adgr', 'agfg', 'arg', 'srfgsd')
