create table Places (
	PlaceID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	PlaceName nvarchar(150) NOT NULL,
	Capacity int NOT NULL,
	BarArea bit NOT NULL,
	VIPArea bit NOT NULL,
	OpeningHour int NOT NULL,
	ClosingHour int NOT NULL,
	AdultsOnly bit NOT NULL,
	RentalPrice int NOT NULL
);

create table Artists (
	ArtistID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	ArtistName nvarchar(150) NOT NULL,
	MusicGenre nvarchar(50) NOT NULL,
	PerformancePrice int NOT NULL,
	ExplicitContent bit NOT NULL,
	ArtistAvailability bit NOT NULL
);

create table Concerts (
	ConcertID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	EventDate SmallDateTime NOT NULL,
	PlaceID int NOT NULL FOREIGN KEY REFERENCES Places(PlaceID),
	ArtistID int NOT NULL FOREIGN KEY REFERENCES Artists(ArtistID),
	BaseTicketPrice int NOT NULL,
	VIPTicketPrice int NOT NULL,
	RemainingCapacity int NOT NULL
);

create table TicketOrders (
	OrderID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	ConcertID int NOT NULL FOREIGN KEY REFERENCES Concerts(ConcertID),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	VIPTicket bit NOT NULL,
	Mail nvarchar(150) NOT NULL,
	PhoneNumber nvarchar(12)
);