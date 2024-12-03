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
--DECLARE @result NVARCHAR(255);
--SET @result = dbo.checkCustomerFunc('098726356782');
--PRINT @result;

Create Function checkVoucher (@voucherCode NVARCHAR(255))
RETURNS FLOAT
AS
BEGIN
	DECLARE @discount FLOAT = -1.0;
	SELECT @discount = discount
	FROM Voucher
	WHERE idVoucher = @voucherCode;
	return @discount;
END
--DECLARE @result FLOAT;
--SET @result =  dbo.checkVoucher('098726356782');
--PRINT @result;
go;
Create View view_ListIngredient as SELECT M.idMenu, I.idIngredient, nameMenu, Iname, IM.number as numberNeed, I.number numberAvailble FROM MENU M, IngredientsMenu IM, Ingredient I WHERE M.idMenu = IM.idMenu AND I.idIngredient = IM.idIngredient

go;
--BỎ
--CREATE TRIGGER UpdateIngredientsOnOrder
--ON Orders
--AFTER INSERT
--AS
--BEGIN
 --   DECLARE @idMenu int, @idOrder int, @number int, @ingredientNumber int;
    -- Cursor to iterate through inserted rows in Orders
  --  DECLARE orderCursor CURSOR FOR
  --  SELECT idMenu, idOrder, number
  --  FROM inserted;
   -- OPEN orderCursor;
    -- Fetch the first row
  --  FETCH NEXT FROM orderCursor INTO @idMenu, @idOrder, @number;

    -- Iterate through each inserted row
 --   WHILE @@FETCH_STATUS = 0
 --   BEGIN
        -- Update Ingredients based on the newly inserted order
   --     UPDATE Ingredient
   --     SET Ingredient.number = Ingredient.number - (SELECT IngredientsMenu.number 
     --                                                  FROM IngredientsMenu 
      --                                                 WHERE IngredientsMenu.idMenu = @idMenu 
     --                                                  AND IngredientsMenu.idIngredient = Ingredient.idIngredient) * @number
     --   FROM Ingredient
   --     INNER JOIN IngredientsMenu ON Ingredient.idIngredient = IngredientsMenu.idIngredient
     --   WHERE IngredientsMenu.idMenu = @idMenu;

        -- Fetch the next row
 --       FETCH NEXT FROM orderCursor INTO @idMenu, @idOrder, @number;
 --   END;
 --   CLOSE orderCursor;
--    DEALLOCATE orderCursor;
--END;

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
AFTER INSERT,UPDATE
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

create function getIngredientsByMenuID(@idMenu Int)
RETURNS TABLE
AS
	RETURN SELECT * FROM viewIgredientsByMenu WHERE idMenu = @idMenu

Create view viewIgredientsByMenu AS Select i.id AS idIng, m.id AS idMenu, i.ten as nname, i.gia AS price, im.so AS number From view_Menu m, viewIngredientsMenu im, viewIngredient i WHERE m.id = im.menu AND im.id = i.id

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

CREATE TRIGGER CheckDuplicatePhoneNumber
ON dbo.Employee
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @PhoneNumber NVARCHAR(15);

    SELECT @PhoneNumber = inserted.phoneNumber
    FROM inserted;

    IF EXISTS (
        SELECT 1
        FROM dbo.Employee
        WHERE phoneNumber = @PhoneNumber
    )
    BEGIN
        RAISERROR('Số điện thoại đã tồn tại trong cơ sở dữ liệu.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

CREATE TRIGGER CheckPhoneNumberFormat
ON dbo.Employee
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @PhoneNumber NVARCHAR(15);

    SELECT @PhoneNumber = inserted.phoneNumber
    FROM inserted;

    IF @PhoneNumber LIKE '%[^0-9]%'
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ. Vui lòng chỉ nhập các ký tự số.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

CREATE TRIGGER CheckEmployeeAge
ON dbo.Employee
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentDate DATE;
    DECLARE @MinValidBirthDate DATE;

    -- Lấy ngày hiện tại
    SELECT @CurrentDate = GETDATE();

    -- Tính toán năm sinh tối thiểu để nhân viên có thể có 18 tuổi
    SELECT @MinValidBirthDate = DATEADD(YEAR, -18, @CurrentDate);

    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE dateOfBirth > @MinValidBirthDate
    )
    BEGIN
        RAISERROR('Nhân viên phải trên 18 tuổi để được thêm vào.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

CREATE TRIGGER CheckDuplicatePhoneNumber_Customer
ON dbo.Customer
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @PhoneNumber NVARCHAR(15);

    SELECT @PhoneNumber = inserted.phoneNumber
    FROM inserted;

    IF EXISTS (
        SELECT 1
        FROM dbo.Customer
        WHERE phoneNumber = @PhoneNumber
    )
    BEGIN
        RAISERROR('Số điện thoại đã tồn tại trong cơ sở dữ liệu.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

CREATE TRIGGER CheckPhoneNumberFormat_Customer
ON dbo.Customer
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE phoneNumber LIKE '%[^0-9]%'
    )
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ. Vui lòng chỉ nhập các ký tự số.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
