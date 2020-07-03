Create database KTGK2
go

Create table phone(
	id int primary key identity(1,1),
	model nvarchar(100),
	price decimal(18, 0),
	gerenal_note nchar(100)	
)