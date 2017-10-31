CREATE DATABASE ADP
CREATE TABLE ACCOUNT(
	UserName varchar(30),
	Password varchar(30)
)
CREATE TABLE ROOMTYPE(
					TypeID VARCHAR(10) NOT NULL PRIMARY KEY,
					Price INT,
					Decription nvarchar(200)
)
CREATE TABLE ROOM(
					RoomID VARCHAR(10) NOT NULL PRIMARY KEY,
					TypeID VARCHAR(10) REFERENCES ROOMTYPE,
					StatusRoom NVARCHAR(200)
)

CREATE TABLE VEHICLE(
					VehicleID varchar(10) NOT NULL PRIMARY KEY,
					Name nvarchar(100),
					Price int
)

CREATE TABLE CUSTOMER(
					CustomerID VARCHAR(10) NOT NULL PRIMARY KEY,
					Name NVARCHAR(100),
					Addres NVARCHAR(200),
					Phone VARCHAR(20),
					RoomID VARCHAR(10)
)

CREATE TABLE RENTTYPE(
					RentTypeID varchar(10) not null primary key,
					NameType nvarchar(100)
)

CREATE TABLE RESERVATION(
						ReservationID VARCHAR(10) NOT NULL PRIMARY KEY,
						CustomerID VARCHAR(10) NOT NULL REFERENCES dbo.CUSTOMER,
						RoomID VARCHAR(10) NOT NULL REFERENCES dbo.ROOM,
						VehicleID varchar(10) REFERENCES dbo.VEHICLE,
						RentTypeID varchar(10) REFERENCES dbo.RENTTYPE,
						StartDate DATE NOT NULL,
						EndDate DATE,
)

CREATE TABLE SERVICE_FEE(
						ServiceID VARCHAR(10) NOT NULL PRIMARY KEY,
						Name NVARCHAR(100),
						Price int
)
CREATE TABLE INVOICE(
					ReservationID VARCHAR(10) NOT NULL REFERENCES dbo.RESERVATION,
					ServiceID VARCHAR(10) NOT NULL REFERENCES dbo.SERVICE_FEE,
					Decription NVARCHAR(200)
					primary key(ReservationID,ServiceID)
)
