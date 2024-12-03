create database QuanLyCafe
go 

use QuanLyCafe
Go
-- Employee
create table Employee
(
	idEmployee int primary key,
	Ename nvarchar(100) not null,
	dateOfBirth date not null,
	gender nvarchar(10) not null,
	Eaddress nvarchar(100) not null,
	phoneNumber varchar(20) not null
)
go

-- Import
create table Import
(
	idImport int identity primary key,
	idEmployee int not null,
	dateCheck DateTime
	foreign key (idEmployee) references Employee(idEmployee)
)
go

-- Ingredient
create table Ingredient
(
	idIngredient int primary key,
	Iname nvarchar(100) not null default N'Chưa đặt tên',
	price float not null default 0,
	number int not null
)
GO
-- Account
create table Account
(
	idAccount int identity primary key,
	ApassWord nvarchar(1000) not null,
	roleName nvarchar(100) null,
	userName nvarchar(100) not null
	foreign key(idAccount) references Employee(idEmployee)
)
go



-- Menu
create table Menu
(
	idMenu int primary key,
	nameMenu nvarchar(100) not null default N'Chưa đặt tên',
	price float not null default 0,
	imageurl varbinary(MAX),
)
go


-- Customer
create table Customer
(
	nameCustomer nvarchar(100) primary key,
	Caddress nvarchar(100) not null,
	phoneNumber varchar(20) not null unique,
)
go

-- Bill
create table Bill
(
	id varchar(20) primary key,
	idEmployee int not null,
	dateCheck Datetime not null default getDate(),
	phoneNumber varchar(20),
	foreign key (idEmployee) references Employee(idEmployee),
	foreign key (phoneNumber) references Customer(phoneNumber)

)
go

-- Order
create table Orders
(
	idOrder int primary key,
	idMenu int not null,
	idBill varchar(20)  not null,
	number int not null,
	foreign key (idBill) references Bill(id),
	foreign key(idMenu) references Menu(idMenu)

)
go

create table ImportedIngredients
(
	idIngredient int not null,
	idImport int not null,
	foreign key (idIngredient) references Ingredient(idIngredient),
	foreign key (idImport) references Import(idImport),
	primary key (idIngredient, idImport)
)
go

create table IngredientsMenu
(
	idIngredient int not null,
	idMenu int not null,
	number int,
	foreign key (idIngredient) references Ingredient(idIngredient),
	foreign key (idMenu) references Menu(idMenu),
	primary key (idIngredient, idMenu)
)
go


insert into dbo.Employee (idEmployee,Ename,dateOfBirth,gender,Eaddress,phoneNumber)
Values
	(1, N'Nguyễn Văn An', '2000-05-15', N'Nam', N'123 Đường Nguyễn Văn Trỗi, Thành phố Thủ Đức', '0239238237'),
    (2, N'Trần Thị Bí', '2005-08-22', N'Nữ', N'456 Đường Lê Văn Việt, Thành phố Thủ Đức', '0395327813'),
    (3, N'Phạm Văn Ca', '2004-03-10', N'Nam', N'789 Đường Trần Nhật Duật, Quận 2 Sài Gòn', '0338272192'),
    (4, N'Ngô Thị Diễm', '1999-11-25', N'Nữ', N'321 Đường Hoàng Thị Loan, Quận 9 Sài Gòn', '0349382139'),
    (5, N'Lê Văn Toàn', '1998-07-18', N'Nam', N'567 Đường Tôn Đức Thắng, Quận 5 Sài Gòn', '0383892018'),
    (6, N'Võ Thị Thúy', '1988-04-30', N'Nữ', N'876 Đường Mai Hắc Đế, Quận 1 Sài Gòn', '0283829182'),
    (7, N'Hoàng Văn Gia', '2001-09-05', N'Nam', N'234 Đường Nguyễn Thiện Thuật, Quận 3 Sài Gòn', '0332891723'),
    (8, N'Đỗ Thị Hoàng', '2002-01-12', N'Nữ', N'432 Đường Hoàng Văn Thụ, Quận 5 Sài Gòn', '0932273221'),
    (9, N'Mai Văn Ý', '2003-12-08', N'Nam', N'789 Đường Trần Phú, Thành phố Bình Dương', '0328232342'),
    (10, N'Nguyễn Thị Kiều', '2001-06-20', N'Nữ', N'876 Đường Đinh Công Tráng, Thành phố Đồng Nai', '02397612385');
    
go

INSERT INTO Import (idEmployee, dateCheck)
VALUES
    (1, '2024-03-14 08:30:00'),
    (2, '2024-02-12 10:45:00'),
    (3, '2023-04-18 12:15:00'),
    (4, '2023-05-27 14:30:00'),
    (5, '2023-06-17 16:00:00'),
    (6, '2023-07-15 09:00:00'),
    (7, '2023-08-16 11:30:00'),
    (8, '2023-09-19 13:45:00'),
    (9, '2024-01-20 15:15:00'),
    (10, '2024-02-21 17:30:00');
go

INSERT INTO Ingredient (idIngredient, Iname, price, number) VALUES
    (1, N'Trà đen', 1000, 100),
    (2, N'Đường', 6000, 50),
    (3, N'Nước lọc', 1000, 200),
    (4, N'Bơi bơ', 15000, 30),
    (5, N'Đậu phộng', 17500, 40),
    (6, N'Sữa đặc', 8750, 25),
    (7, N'Đá viên', 1000, 150),
    (8, N'Cà phê', 9000, 20),
    (9, N'Sirô dâu', 2500, 15),
    (10, N'Chanh xanh', 3000, 35),
    (11, N'Hạt chia', 2500, 60),
    (12, N'Kem vani', 12000, 18),
    (13, N'Sirô mâm xôi', 10000, 22),
    (14, N'Trân châu đen', 9500, 28),
    (15, N'Mật ong', 3200, 24);
go

INSERT INTO Account (ApassWord) VALUES
    ('Password123'),
    ('SecurePass789'),
    ('StrongPassword'),
    ('UserPass456'),
    ('Secret123!@'),
    ('Password@!'),
    ('Account567'),
    ('Pass1234'),
    ('SecureAccount789'),
    ('Strong789@');
go

INSERT INTO Menu (idMenu,nameMenu, price) VALUES
    (1,N'Trà sữa trân châu', 35000),
    (2,N'Cà phê đen', 22000),
    (3,N'Sinh tố dâu', 40000),
    (4,N'Caramel macchiato', 33000),
    (5,N'Nước cam ép', 25000),
    (6,N'Nước lọc', 5000),
    (7,N'Latte vani', 38000),
    (8,N'Bạc xỉu', 25000),
    (9,N'Cappuccino', 36000),
    (10,N'Soda chanh', 25000),
	(11,N'Cà phê sữa đá', 25000),
    (12,N'Bánh mì trứng ốp-la', 22000),
    (13,N'Sinh tố xoài', 35000),
    (14,N'Choco frappe', 32000),
    (15,N'Sữa chua trái cây', 35000),
    (16,N'Bia tươi', 15000),
    (17,N'Matcha latte', 35000),
    (18,N'Bánh crepe chocolate', 40000),
    (19,N'Nước mâm xôi', 15000),
    (20,N'Cà phê sữa tươi', 28000);
go


INSERT INTO Customer (nameCustomer, Caddress, phoneNumber) VALUES
    (N'Nguyễn Văn Ý', N'123 Đường Nguyễn Văn Nghi, Quận 1, TP.Hồ Chí Minh', '0349324202'),
    (N'Trần Thị Cát Tường', N'456 Đường Thích Bửu Đăng, Quận 2, TP.Hồ Chí Minh', '0204283247'),
    (N'Phạm Văn Chính', N'789 Đường Thanh Đa, Quận 3, TP.Hồ Chí Minh', '0332918882'),
    (N'Lê Thị Diễm My', N'321 Đường Nguyễn Thái Sơn, Quận 4, TP.Hồ Chí Minh', '0324008877'),
    (N'Hồ Văn Nam', N'567 Đường Cộng Hòa, Quận 5, TP.Hồ Chí Minh', '0998297771'),
    (N'Võ Thị Tuyết Nga', N'876 Đường Huỳnh Văn Bánh, Quận 6, TP.Hồ Chí Minh', '0939240912'),
    (N'Trần Trọng Tú', N'234 Đường Hùng Vương, Quận 7, TP.Hồ Chí Minh', '0948327482'),
    (N'Phan Đỗ Nhật Huy', N'432 Đường Lý Nam Đế, Quận 8, TP.Hồ Chí Minh', '0294283242'),
    (N'Mai Văn Khang', N'789 Đường Nguyễn Du, Quận 9, TP.Hồ Chí Minh', '0333488721'),
    (N'Nguyễn Thị Kiều Lanh', N'876 Đường Phan Văn Trị, Quận 10, TP.Hồ Chí Minh', '0934032734'),
    (N'Đặng Thị Tuệ', N'567 Đường Bùi Đình Túy, Quận 11, TP.Hồ Chí Minh', '0987263782'),
    (N'Nguyễn Thị Thảo My', N'123 Đường Lý Thường Kiệt, Quận 12, TP.Hồ Chí Minh', '0982423724'),
    (N'Lý Văn Ngọ', N'345 Đường Bạch Đằng, Bình Thạnh, TP.Hồ Chí Minh', '0294853282'),
    (N'Hồ Thị Phương', N'678 Đường Vĩnh Viễn, Gò Vấp, TP.Hồ Chí Minh', '0925310325'),
    (N'Trần Văn Qúy', N'234 Đường Tân Phước, Tân Bình, TP.Hồ Chí Minh', '0983274323'),
	(N'Đặng Văn Lâm', N'567 Đường Lê Văn Việt, Thành phố Thủ Đức', '0283729122'),
    (N'Nguyễn Thị Mai', N'123 Đường Mai Hắc Đế, Quận 1 Sài Gòn', '0392729342'),
    (N'Lý Văn Nam',N'345 Đường Nguyễn Thị Minh Khai, Quận 5 Sài Gòn', '0923772332'),
    (N'Hồ Thị Phượng',N'678 Đường Phan Đình Phùng, Thành phố Bình Dương', '0238237442'),
    (N'Trần Văn Quỳnh', N'234 Đường Nguyễn Huệ, Quận 12 Sài Gòn', '0234923974'),
    (N'Nguyễn Thị Sang',N'789 Đường Âu Cơ, Quận 3 Sài Gòn', '0932382329'),
    (N'Lê Văn Tú', N'432 Đường Quang Trung, Thành phố Bình Thuận', '0328932388'),
    (N'Phạm Thị Uyên',N'876 Đường Lạc Long Quân, Quận 7 Sài Gòn', '0293094922'),
    (N'Nguyễn Văn Việt',N'321 Đường An Dương Vương, Quận 2 Sài Gòn', '0394903212'),
    (N'Trần Thị Thảo',N'567 Đường Lê Văn Việt, Thành phố Thủ Đức', '0983920341');
go


Create view view_Menu as SELECT idMenu AS id, nameMenu AS nname, price, imageurl FROM Menu;
go;

Create Function getAll()
Returns table
as
return select * from view_Menu;
go;


Select * from getAll()


CREATE FUNCTION checkCustomerFunc
    (@soDienThoai NVARCHAR(10))
RETURNS NVARCHAR(255)
AS
BEGIN
    DECLARE @hoTen NVARCHAR(255);

    SELECT @hoTen = nameCustomer
    FROM Customer
    WHERE phoneNumber = @soDienThoai;

    RETURN @hoTen;
END;
go;

--DECLARE @result FLOAT;
--SET @result =  dbo.checkVoucher('098726356782');
--PRINT @result;



Create View view_ListIngredient as SELECT M.idMenu, I.idIngredient, nameMenu, Iname, IM.number as numberNeed, I.number numberAvailble FROM MENU M, IngredientsMenu IM, Ingredient I WHERE M.idMenu = IM.idMenu AND I.idIngredient = IM.idIngredient
go;


CREATE TRIGGER autoDescreaseIngredientsOnOrders
ON Orders
AFTER INSERT
AS
BEGIN
    DECLARE @idMenu INT, @idOrder INT, @number INT, @ingredientNumber INT;

    -- Selecting values into variables from inserted table
    SELECT @idMenu = i.idMenu, @idOrder = i.idOrder, @number = i.number
    FROM inserted i;

    -- Update Ingredients based on the inserted data
    UPDATE Ingredient 
    SET Ingredient.number = Ingredient.number - (SELECT IngredientsMenu.number 
                           FROM IngredientsMenu 
                           WHERE IngredientsMenu.idMenu = @idMenu 
                             AND IngredientsMenu.idIngredient = Ingredient.idIngredient) * @number
    FROM Ingredient
    INNER JOIN IngredientsMenu ON Ingredient.idIngredient = IngredientsMenu.idIngredient
    WHERE IngredientsMenu.idMenu = @idMenu;
END

go;


CREATE TRIGGER CheckNegativeNumber
ON Ingredient
AFTER INSERT
AS
BEGIN
    DECLARE @NegativeError NVARCHAR(100) = 'Nguyên liệu không hợp lệ';

    IF EXISTS (SELECT * FROM inserted WHERE number < 0)
    BEGIN
        RAISERROR(@NegativeError, 16, 1);
        ROLLBACK TRANSACTION;
    END;
END;
go;


create procedure insertBill 
	@id VARCHAR(20),
	@idEmployee INT,
	@phoneNo VARCHAR(10) = null
AS BEGIN
	DECLARE @time DATETIME;
	SELECT @time = GETDATE();
	INSERT INTO BILL(id,idEmployee, phoneNumber,dateCheck) VALUES(@id,@idEmployee, @phoneNo, @time)
END

--EXEC insertBill @idEmployee = 1, @phoneNo = null

CREATE PROCEDURE insertOrder
    @idBill varchar(20),
    @idMenu int,
    @number int
AS 
BEGIN
    DECLARE @idOrder INT;
    
    -- Lấy giá trị idOrder cuối cùng
    SELECT @idOrder = ISNULL(MAX(idOrder), 0) + 1 FROM Orders;
    
    -- Chèn dữ liệu vào bảng Orders
    INSERT INTO Orders (idOrder, idMenu, idBill, number)
    VALUES (@idOrder, @idMenu, @idBill, @number);
    
    -- Trả về idOrder vừa chèn
    SELECT @idOrder AS NewOrderId;
END;
go


CREATE FUNCTION getMenuByKeyword (@keyword nvarchar(MAX))
RETURNS TABLE
AS
	RETURN (
		SELECT * FROM view_Menu 
		WHERE nname Like '%'+@keyword+'%'
	);
Select * from getMenuByKeyword('Cappuc')
--Insert into IngredientsMenu(idIngredient,idMenu,number) values (1,1,10);
--Insert into IngredientsMenu(idIngredient,idMenu,number) values (2,1,10);
--Select * from Ingredient;
--Insert into Orders(idBill,idMenu,number,idOrder) Values('T162024412629813',1,1,24);
--Select * from Ingredient;


--NEW NEW NEW
-- NEW NEW NEW
create procedure insertMenu 
	@nameMenu nvarchar(100),
	@price float,
	@imageURL varbinary(MAX)
As
BEGIN
    DECLARE @idMenu INT;
    
    -- Lấy giá trị idOrder cuối cùng
    SELECT @idMenu = ISNULL(MAX(idMenu), 0) + 1 FROM Menu;
    
    -- Chèn dữ liệu vào bảng Orders
    INSERT INTO Menu(idMenu,nameMenu, price, imageUrl)
    VALUES (@idMenu, @nameMenu, @price, @imageUrl);
    
    -- Trả về idOrder vừa chèn
    SELECT @idMenu AS id;
END;


Create procedure updateMenu
	@id INT,
	@nameMenu nvarchar(100) = null,
	@price float = -1.0,
	@imageurl varbinary(MAX) = null
AS
Begin
	Declare @oldName nvarchar(100) 
	,@oldPrice float,
	@oldImage varbinary(MAX);
	SELECT @oldName = nname, @oldPrice = price, @oldImage = @imageurl FROM view_Menu;
	IF @nameMenu IS NULL SET @nameMenu = @oldName;
	IF @price = -1.0 SET @price = @oldPrice;
	IF @imageurl IS NULL SET @imageurl = @oldImage;
	UPDATE Menu
	SET nameMenu = @nameMenu, price = @price, imageurl = @imageurl
	FROM Menu
	WHERE idMenu = @id;
End


--Select * from Menu where idMenu = 1;
--Exec updateMenu 1,null, 15000, null;
--Select * from Menu where idMenu = 1;
create view viewAccount as select idAccount as id, ApassWord as pass  from Account 



Create Function getAllAccount()
Returns table
as
return select * from viewAccount;


create procedure insertAccount 
	@idAccount int,
	@ApassWord nvarchar(1000)
AS BEGIN
	INSERT INTO Account(idAccount, ApassWord) VALUES(@idAccount, @ApassWord)
END


create view viewBill as select id as Bill, idEmployee as Employee, dateCheck as Cdate, phoneNumber as phone from Bill 



Create Function getAllBill()
Returns table
as
return select * from viewBill;

create view viewCustomer as select nameCustomer as Cname, Caddress as Cadd, phoneNumber as phone from Customer 


Create Function getAllCustomer()
Returns table
as
return select * from viewCustomer;

create procedure insertCustomer 
	@nameCustomer nvarchar(100),
	@Caddress nvarchar(100),
	@phoneNumber varchar(20)
AS BEGIN
	INSERT INTO Customer(nameCustomer, Caddress, phoneNumber) VALUES(@nameCustomer, @Caddress, @phoneNumber)
END


create view viewEmployee as select idEmployee as id, Ename as ten, dateOfBirth as birth, gender as gen, Eaddress as diachi, phoneNumber as phone  from Employee	 


Create Function getAllEmployee()
Returns table
as
return select * from viewEmployee;

create procedure insertEmployee 
	@Ename nvarchar(100),
	@dateOfBirth date,
	@gender nvarchar(10),
	@Eaddress nvarchar(100),
	@phoneNumber varchar(20)
AS BEGIN
	DECLARE @id Int;
	SELECT @id = MAX(idEmployee) + 1 From Employee;
	INSERT INTO Employee(idEmployee, Ename, dateOfBirth, gender, Eaddress, phoneNumber) VALUES(@id, @Ename, @dateOfBirth, @gender, @Eaddress, @phoneNumber)
	SELECT @id 
END


create view viewImport as select idImport as id, idEmployee as idE, dateCheck as ngay  from Import 



Create Function getAllImport()
Returns table
as
return select * from viewImport;



create procedure insertImport 
	@idEmployee int
AS BEGIN
	DECLARE @time DATETIME, @id Int;
	SELECT @time = GETDATE();
	SELECT @id = MAX(idImport) + 1 From Import;
	INSERT INTO Import(idEmployee, dateCheck ) VALUES(@idEmployee, @time)
	SELECT @id
END



create view viewImportedIngredients as select idIngredient as id, idImport as idI  from ImportedIngredients


Create Function getAllImportedIngredients()
Returns table
as
return select * from viewImportedIngredients;

CREATE PROCEDURE insertImportedIngredients 
    @idIngredient INT,
    @idImport INT,
    @number INT
AS
BEGIN
    -- Start transaction
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insert a new record into ImportedIngredients
        INSERT INTO ImportedIngredients (idIngredient, idImport) 
        VALUES (@idIngredient, @idImport);
        
        -- Declare variables for storing current and new numbers
        DECLARE @oldNumber INT, @newNumber INT;
        
        -- Select the current number of ingredients only for the given id
        SELECT @oldNumber = number 
        FROM Ingredient
        WHERE idIngredient = @idIngredient;
        -- Calculate the new number
        SET @newNumber = @oldNumber + @number;
        
        -- Update the Ingredient table
        UPDATE Ingredient
        SET number = @newNumber
        WHERE idIngredient = @idIngredient;
        
        -- Commit the transaction if all commands succeed
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction in case of an error
        ROLLBACK TRANSACTION;

        -- Rethrow the caught exception for further handling or logging
        THROW;
    END CATCH
END;


SELECT * FROM Ingredient WHERE idIngredient = 9;
EXEC insertImportedIngredients 9,1003,12;
SELECT * FROM Ingredient WHERE idIngredient = 9;


create view viewIngredient as select idIngredient as id, Iname as ten, price as gia, number as so from Ingredient



Create Function getAllIngredient()
Returns table
as
return select * from viewIngredient;


--Select * from getAllIngredient()
create procedure insertIngredient 
	@Iname nvarchar(100), 
	@price float, 
	@number int
AS BEGIN
	DECLARE @id INT;
	SELECT @id = MAX(idIngredient) +1 FROM Ingredient
	INSERT INTO Ingredient(idIngredient, Iname, price, number) VALUES( @id, @Iname, @price, @number)
END


create view viewIngredientsMenu as select idIngredient as id, idMenu as menu, number as so from IngredientsMenu


Create Function getAllIngredientsMenu()
Returns table
as
return select * from viewIngredientsMenu;


create procedure insertIngredientsMenu 
	@idIngredient int,
	@idMenu int,
	@number int
AS BEGIN
	INSERT INTO IngredientsMenu(idIngredient, idMenu, number) VALUES(@idIngredient, @idMenu, @number)
END


create view viewOrder as select idOrder as id, idMenu as menu, idBill as bill, number as so  from Orders


Create Function getAllOrder()
Returns table
as
return select * from viewOrder;


Create view viewIgredientsByMenu AS Select i.id AS idIng, m.id AS idMenu, i.ten as nname, i.gia AS price, im.so AS number From view_Menu m, viewIngredientsMenu im, viewIngredient i WHERE m.id = im.menu AND im.id = i.id


create function getIngredientsByMenuID(@idMenu Int)
RETURNS TABLE
AS
	RETURN SELECT * FROM viewIgredientsByMenu WHERE idMenu = @idMenu


Select * from getIngredientsByMenuID(1)


create proc deleteIngredentsMenu @idMenu int, @idIngredient int
as
begin
	delete from IngredientsMenu Where idIngredient = @idIngredient And idMenu = @idMenu
end


create proc updateIngredient
	@id int,
	@name nvarchar(100) = null,
	@price float = -1.0,
	@number int = -1
as
begin
	declare @oldName nvarchar(100), @oldPrice float, @oldNumber int;
	select @oldName = Iname, @oldPrice = price , @oldNumber = number From Ingredient where idIngredient = @id;
	If @name is null SET @name = @oldName;
	If @price = -1.0 SET @price = @oldPrice;
	If @number = -1 SET @number = @oldNumber
	Update Ingredient
	Set Iname = @name,
		price = @price,
		number = @number
	WHERE idIngredient = @id;
end;
go;



create function getOrderByBillID(@billID nvarchar(20))
RETURNS TABLE
AS RETURN SELECT * FROM viewOrder Where bill = @billID;



CREATE FUNCTION getBillByKeyword (@keyword nvarchar(MAX))
RETURNS TABLE
AS
	RETURN (
		SELECT * FROM viewBill 
		WHERE Bill Like '%'+@keyword+'%' or phone Like '%'+@keyword+'%'
	);


CREATE FUNCTION getCustomerByKeyword (@keyword nvarchar(MAX))
RETURNS TABLE
AS
	RETURN (
		SELECT * FROM viewCustomer 
		WHERE Cname Like '%'+@keyword+'%' or Cadd Like '%'+@keyword+'%' or phone Like '%'+@keyword+'%'
	);



CREATE FUNCTION getEmloyeeByKeyword (@keyword nvarchar(MAX))
RETURNS TABLE
AS
	RETURN (
		SELECT * FROM viewEmployee 
		WHERE ten Like '%'+@keyword+'%' or gen Like '%'+@keyword+'%' or diachi Like '%'+@keyword+'%' or phone Like '%'+@keyword+'%'
	);



CREATE FUNCTION getIngredientByKeyword (@keyword nvarchar(MAX))
RETURNS TABLE
AS
	RETURN (
		SELECT * FROM viewIngredient 
		WHERE ten Like '%'+@keyword+'%' 
	);

Create procedure updateEmployee
	@idEmployee INT,
	@Ename nvarchar(100),
	@dateOfBirth date,
	@gender nvarchar(10),
	@Eaddress nvarchar(100),
	@phoneNumber varchar(20)
AS
Begin
	Declare @oldEname nvarchar(100),
	@oldDateOfBirth date,
	@oldGender nvarchar(10),
	@oldEaddress nvarchar(100),
	@oldPhoneNumber varchar(20)
	SELECT @oldEaddress = diachi, @oldGender = gen, @oldEname = ten, @oldDateOfBirth = birth, @oldPhoneNumber = phone
	FROM viewEmployee WHERE id = @idEmployee;
	IF @Eaddress IS NULL SET @Eaddress = @oldEaddress;
	IF @gender IS NULL SET @gender = @oldGender;
	IF @Ename IS NULL SET @Ename = @oldEname;
	IF @dateOfBirth IS NULL SET @dateOfBirth = @oldDateOfBirth
	UPDATE Employee
	SET Ename = @Ename, Eaddress = @Eaddress, gender = @gender,
	dateOfBirth = @dateOfBirth, phoneNumber = @phoneNumber
	FROM Employee
	WHERE idEmployee = @idEmployee;
End


create proc updateCustomer
	@name varchar(20),
	@Caddres nvarchar(100),
	@phone varchar(20)
as
begin
	declare @Oldaddres nvarchar(100),
	@oldName varchar(20);
	SELECT @Oldaddres = Cadd, @oldName = Cname FROM viewCustomer WHERE phone = @phone;
	If @Caddres IS NULL SET @Caddres = @Oldaddres;
	IF @name IS NULL SET @name = @oldName
	Update Customer
	Set nameCustomer = @name,
		Caddress = @Caddres
	FROM Customer
	WHERE phoneNumber = @phone;
end;
go;



Exec updateCustomer '0204283247','123','1'



CREATE ROLE R_ADMIN;
CREATE ROLE R_USER;
--GRANT [CÂU TRUY VẤN] ON [ĐỐI TƯỢNG] TO [ROLE]
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Account to R_ADMIN;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Bill to R_ADMIN;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Customer to R_ADMIN;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Employee to R_ADMIN;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Import to R_ADMIN;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.ImportedIngredients to R_ADMIN;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Menu to R_ADMIN;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Orders to R_ADMIN;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Ingredient to R_ADMIN;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.IngredientsMenu to R_ADMIN;

GRANT SELECT ON dbo.Account to R_USER;
GRANT SELECT, INSERT ON dbo.Bill to R_USER;
GRANT SELECT, INSERT, UPDATE ON dbo.Customer to R_USER;
GRANT SELECT ON dbo.Employee to R_USER;
GRANT SELECT, INSERT, UPDATE ON dbo.Import to R_USER;
GRANT SELECT, INSERT, UPDATE ON dbo.ImportedIngredients to R_USER;
GRANT SELECT, INSERT, UPDATE ON dbo.Menu to R_USER;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Orders to R_USER;
GRANT SELECT, INSERT, UPDATE ON dbo.Ingredient to R_USER;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.IngredientsMenu to R_USER;
 
DENY INSERT, UPDATE, DELETE ON dbo.Account to R_USER;
DENY UPDATE, DELETE ON dbo.Bill to R_USER;
DENY delete ON dbo.Customer to R_USER;
DENY INSERT, UPDATE, DELETE ON dbo.Employee to R_USER;
DENy DELETE ON dbo.Import to R_USER;
DENY DELETE ON dbo.ImportedIngredients to R_USER;
DENY DELETE ON dbo.Menu to R_USER;
DENY DELETE ON dbo.Ingredient to R_USER;

GRANT EXEC ON dbo.createAccount To R_ADMIN;
DENY EXEC ON dbo.createAccount To R_USER;

GRANT EXEC ON dbo.deleteIngredentsMenu To R_USER,R_ADMIN;
GRANT EXEC ON dbo.insertBill To R_USER,R_ADMIN;
GRANT EXEC ON dbo.insertCustomer To R_USER,R_ADMIN;
GRANT EXEC ON dbo.insertEmployee To R_ADMIN;
DENY EXEC ON dbo.insertEmployee To R_USER;
GRANT EXEC ON dbo.insertImport To R_USER,R_ADMIN;
GRANT EXEC ON dbo.insertImportedIngredients To R_USER,R_ADMIN;
GRANT EXEC ON dbo.insertIngredient To R_USER,R_ADMIN;
GRANT EXEC ON dbo.insertMenu To R_USER,R_ADMIN;
GRANT EXEC ON dbo.insertOrder To R_USER,R_ADMIN;
GRANT EXEC ON dbo.updateCustomer To R_USER,R_ADMIN;
GRANT EXEC ON dbo.updateEmployee To R_ADMIN;
deny EXEC ON dbo.updateEmployee To R_USER;
GRANT EXEC ON dbo.updateIngredient To R_USER,R_ADMIN;
GRANT EXEC ON dbo.updateMenu To R_USER,R_ADMIN;


GRANT SELECT ON dbo.getAll To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getAllAccount To R_ADMIN;
deny SELECT ON dbo.getAllAccount To R_USER;
GRANT SELECT ON dbo.getAllBill To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getAllCustomer To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getAllEmployee To R_ADMIN,R_USER;
GRANT SELECT ON dbo.getAllImport To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getAllImportedIngredients To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getAllIngredient To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getAllIngredientsMenu To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getAllOrder To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getBillByKeyword To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getCustomerByKeyword To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getEmloyeeByKeyword To R_ADMIN,R_USER;
GRANT SELECT ON dbo.getIngredientByKeyword To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getIngredientsByMenuID To R_USER,R_ADMIN;
GRANT SELECT ON dbo.getOrderByBillID To R_USER,R_ADMIN;
GRANT EXEC ON dbo.checkCustomerFunc To R_USER,R_ADMIN;
GRANT EXEC ON dbo.checkLogin To R_USER,R_ADMIN;

CREATE PROCEDURE createAccount
	@idAccount INT,
    @username NVARCHAR(100),
    @password NVARCHAR(100)
AS 
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    INSERT INTO Account(idAccount,roleName,ApassWord,username) VALUES(@idAccount,'R_USER',@password,@username)
    -- Tạo đăng nhập
--	TẠO LOGIN HỆ THỐNG -> TẠO USER CHO DATABASE -> GÁN QUYỀN
    SET @sql = 'CREATE LOGIN ' + QUOTENAME(@username) + ' WITH PASSWORD = ''' + @password + ''';';
    EXEC sp_executesql @sql;
    
    -- Tạo người dùng và liên kết với đăng nhập
    SET @sql = 'CREATE USER ' + QUOTENAME(@username) + ' FOR LOGIN ' + QUOTENAME(@username) + ';';
    EXEC sp_executesql @sql;
    
    -- Gán người dùng vào vai trò
    SET @sql = 'ALTER ROLE R_USER ADD MEMBER ' + QUOTENAME(@username) + ';';
    EXEC sp_executesql @sql;
END;


EXEC createAccount @idAccount = 9, @username = 'user9', @password = 'password123';


CREATE FUNCTION checkLogin(@username nvarchar(100),@password nvarchar(1000))
RETURNS int 
AS BEGIN
	IF EXISTS (SELECT * FROM Account a WHERE a.username = @username AND a.ApassWord = @password)
	Begin
		return 1;
	end
	Return 0;
END;
checkLogin(@username = 'user7',@password='password123')



