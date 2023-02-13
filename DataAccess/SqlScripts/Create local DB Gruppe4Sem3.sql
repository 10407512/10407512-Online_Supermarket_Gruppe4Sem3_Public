Create database NetSuper
go

Use NetSuper
go

Create table Person(
	f_name nvarchar(25) not null,
	l_name nvarchar(25) not null,
	email nvarchar(50) not null,
	phoneNo varchar(25) not null,
	[role] varchar(25) not null,
	userName nvarchar(25) unique,
	primary key(email)
	)

Create table [Order](
	orderNo int identity(1,1) not null,
	total float not null,
	[date] datetime not null,
	isReady bit not null,
	isCollected bit not null,
	isPaid bit not null,
	orderCreator nvarchar(50) foreign key references Person(email),
	handler nvarchar(25) foreign key references Person(userName),
	phoneNo varchar(25),
	email nvarchar(50) not null,
	Primary key(orderNo)
)

Create table Product(
	name nvarchar(50) not null,
	brand nvarchar(50) not null,
	price float not null,
	[description] nvarchar(1000),
	stock int not null CONSTRAINT Check_PositiveValue Check (stock>=(0)),
	barcode varchar(50) not null
	Primary key(barcode)
)

Create table Orderline(
	order_orderNo int not null foreign key references [Order](orderNo) ON DELETE CASCADE,
	quantity int not null,
	subTotal float not null,
	product_barcode varchar(50) not null foreign key references Product(barcode)
)
