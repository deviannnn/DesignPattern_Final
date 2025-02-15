﻿USE master
GO
IF exists( SELECT * FROM sysdatabases WHERE name='YAME')
	DROP DATABASE YAME

GO
CREATE DATABASE YAME

GO
USE YAME

------------------- ACCOUNT -------------------
GO
CREATE TABLE ACCOUNT
(
	[ID] INT IDENTITY(1,1) PRIMARY KEY,
	[YAME_ID] VARCHAR(10) NULL UNIQUE,
	[GMAIL] VARCHAR(50) NOT NULL UNIQUE,
	[PHONE] VARCHAR(10) NOT NULL UNIQUE,
	[PASSWORD] VARCHAR(150) NOT NULL,
	[NAME] NVARCHAR(40) NOT NULL,
	[GENDER] BIT NOT NULL,
	[ADDRESS] NVARCHAR(100) NOT NULL,
	[LOCKED] BIT DEFAULT 0,
	[ACTIVE] BIT DEFAULT 0,
	[ROLE] NVARCHAR(10) DEFAULT 'STAFF'
)

GO
CREATE TRIGGER GenerateYameId
	ON ACCOUNT
	AFTER INSERT
AS
BEGIN
	DECLARE @AccountId VARCHAR(10)
    DECLARE @NewYameId VARCHAR(10)
    DECLARE @YearPart VARCHAR(2)
    DECLARE @GenderPart CHAR(1)
    DECLARE @RandomPart INT

	SELECT @AccountId = CAST(ID AS VARCHAR(10)) FROM inserted
	SELECT @GenderPart = CASE WHEN GENDER = 1 THEN '1' ELSE '0' END FROM inserted
    SET @YearPart = RIGHT(YEAR(GETDATE()), 2)

	DECLARE @RandomDigits INT = 7 - LEN(@AccountId)
	SET @RandomPart = CAST(RAND() * ((9 * POWER(10, @RandomDigits-1)) + (1 * POWER(10, @RandomDigits-1))) AS INT)

    WHILE 1 = 1
    BEGIN
        SET @NewYameId = @YearPart + @GenderPart + CAST(@RandomPart AS VARCHAR(6)) + @AccountId
        IF LEN(@NewYameId) = 10 AND NOT EXISTS (SELECT 1 FROM ACCOUNT WHERE YAME_ID = @NewYameId)
        BEGIN
            BREAK
        END
		SET @RandomPart = @RandomPart + 1
    END

    UPDATE ACCOUNT
    SET YAME_ID = @NewYameId
    FROM ACCOUNT INNER JOIN inserted ON ACCOUNT.ID = inserted.ID
END
SELECT * FROM ACCOUNT
GO
INSERT INTO [ACCOUNT] ([GMAIL], [PHONE], [PASSWORD], [NAME], [GENDER], [ADDRESS], [ROLE])
VALUES ('admin@gmail.com', '0123456789', 'admin', N'Admin', 1, N'123 Test Street', 'ADMIN');
GO
INSERT INTO [ACCOUNT] ([GMAIL], [PHONE], [PASSWORD], [NAME], [GENDER], [ADDRESS], [LOCKED])
VALUES ('staff1@gmail.com', '0987654321', 'staff', N'Staff1', 0, N'456 Test Avenue', 1);
GO
INSERT INTO [ACCOUNT] ([GMAIL], [PHONE], [PASSWORD], [NAME], [GENDER], [ADDRESS], [ACTIVE])
VALUES ('staff2@gmail.com', '0987654322', 'staff', N'Staff2', 1, N'456 Test Avenue', 0);
GO
INSERT INTO [ACCOUNT] ([GMAIL], [PHONE], [PASSWORD], [NAME], [GENDER], [ADDRESS], [LOCKED], [ACTIVE])
VALUES ('staff3@gmail.com', '0987654323', 'staff', N'Staff3', 0, N'456 Test Avenue', 1, 0);

GO
SELECT * FROM ACCOUNT WHERE YAME_ID = 'admin@gmail.com' OR GMAIL = 'admin@gmail.com' OR PHONE = 'admin@gmail.com'
--SELECT COUNT(*) FROM ACCOUNT WHERE GMAIL = 'admin@gmail.com' OR PHONE = '2412846371'


------------------- CUSTOMER -------------------
GO
CREATE TABLE CUSTOMER
(
	[ID] INT IDENTITY(0,1) PRIMARY KEY,
	[CODE] VARCHAR(10) NULL UNIQUE,
	[PHONE] VARCHAR(10) NOT NULL UNIQUE,
	[NAME] NVARCHAR(40) NOT NULL,
	[POINT] INT DEFAULT 0,
	[PERCENT_DISCOUNT] FLOAT DEFAULT 0,
	[ACTIVE] BIT DEFAULT 1
)
GO
INSERT INTO [CUSTOMER] ([CODE], [PHONE], [NAME])
VALUES ('0','0',N'YAME Customer');
GO
INSERT INTO [CUSTOMER] ([CODE], [PHONE], [NAME], [POINT], [PERCENT_DISCOUNT])
VALUES ('0987655555','0987655555',N'Customer1', 502, 0.05);
GO
INSERT INTO [CUSTOMER] ([CODE], [PHONE], [NAME], [POINT], [PERCENT_DISCOUNT])
VALUES ('0987655556','0987655556',N'Customer2', 7002, 0.12);


GO
CREATE TRIGGER UpdatePoint
    ON CUSTOMER
    AFTER UPDATE
AS 
BEGIN
    UPDATE CUSTOMER
    SET PERCENT_DISCOUNT = 
        CASE
            WHEN inserted.POINT >= 500 AND inserted.POINT < 1000 THEN 0.05
            WHEN inserted.POINT >= 1000 AND inserted.POINT < 2000 THEN 0.06
            WHEN inserted.POINT >= 2000 AND inserted.POINT < 3000 THEN 0.07
            WHEN inserted.POINT >= 3000 AND inserted.POINT < 4000 THEN 0.08
            WHEN inserted.POINT >= 4000 AND inserted.POINT < 5000 THEN 0.09
            WHEN inserted.POINT >= 5000 AND inserted.POINT < 6000 THEN 0.1
            WHEN inserted.POINT >= 6000 AND inserted.POINT < 7000 THEN 0.11
            WHEN inserted.POINT >= 7000 AND inserted.POINT < 8000 THEN 0.12
            WHEN inserted.POINT >= 8000 AND inserted.POINT < 9000 THEN 0.13
            WHEN inserted.POINT >= 9000 AND inserted.POINT < 10000 THEN 0.14
            WHEN inserted.POINT >= 10000 THEN 0.15
            ELSE 0
        END
    FROM inserted
    WHERE CUSTOMER.ID = inserted.ID
END

------------------- SIZES_TYPE -------------------
-- DROP TABLE SIZES_TYPE
GO
CREATE TABLE SIZES_TYPE
(
	[ID] INT IDENTITY(1,1) PRIMARY KEY,
	[NAME] NVARCHAR(40) NOT NULL,
	[DESCRIPTION] NVARCHAR(100) NULL,
	[ACTIVE] BIT DEFAULT 1
)
GO
INSERT INTO [SIZES_TYPE] ([NAME], [DESCRIPTION]) 
VALUES
('Only 1 size', 'Only having 1 option used for Accessory'),
('SMLXL', 'Character Size Type having 4 options used for Tops and Underwear'),
('29 to 33', 'Having 5 options used for Bottoms'),
('40 to 43', 'Having 4 options used for Footwear')

------------------- SIZES -------------------
-- DROP TABLE SIZES
GO
CREATE TABLE SIZES
(
	[ID] INT IDENTITY(1,1) PRIMARY KEY,
	[CODE] VARCHAR(3) NOT NULL,
	[NAME] VARCHAR(10) NOT NULL,
	[SIZES_TYPE_ID] INT NOT NULL,
	[ACTIVE] BIT DEFAULT 1
	FOREIGN KEY (SIZES_TYPE_ID) REFERENCES SIZES_TYPE(ID)
)
GO
INSERT INTO [SIZES] ([CODE], [NAME], [SIZES_TYPE_ID])
VALUES
('000','FREE SIZE', 1), ('001','S', 2), ('002','M', 2), ('003','L', 2), ('004','XL', 2),
('001','29', 3), ('002','30', 3), ('003','31', 3), ('004','32', 3), ('005','33', 3),
('001','40', 4), ('002','41', 4), ('003','42', 4), ('004','43', 4)

------------------- CATEGORY -------------------
-- DROP TABLE CATEGORY
GO
CREATE TABLE CATEGORY
(
	[ID] INT IDENTITY(1,1) PRIMARY KEY,
	[NAME] NVARCHAR(40) NOT NULL,
	[SIZES_TYPE_ID] INT NOT NULL,
	[ACTIVE] BIT DEFAULT 1
	FOREIGN KEY (SIZES_TYPE_ID) REFERENCES SIZES_TYPE(ID)
)
GO
INSERT INTO [CATEGORY] ([NAME], [SIZES_TYPE_ID])
VALUES ('Tops', 2), ('Bottoms', 3), ('Underwear', 2), ('Footwear', 4), ('Accessory', 1)

------------------- PRODUCT -------------------
-- DROP TABLE PRODUCT
GO
CREATE TABLE PRODUCT
(
	[ID] INT IDENTITY(1,1) PRIMARY KEY,
	[CODE] VARCHAR(7) NOT NULL UNIQUE,
	[NAME] NVARCHAR(50) NOT NULL,
	[COST] FLOAT NOT NULL,
	[PRICE] FLOAT NOT NULL,
	[PERCENT_DISCOUNT] FLOAT NOT NULL,
	[CATEGORY_ID] INT NOT NULL,
	[ACTIVE] BIT DEFAULT 1
	FOREIGN KEY (CATEGORY_ID) REFERENCES CATEGORY(ID)
)

GO
INSERT INTO [PRODUCT] ([CODE], [NAME], [COST], [PRICE], [PERCENT_DISCOUNT], [CATEGORY_ID])
VALUES
('0000000', N'TEST1', 15, 20, 0, 1),
('0000001', N'TEST2', 15, 40, 0.5, 1),
('0000002', N'TEST3', 20, 39, 0.5, 1)

------------------- PRODUCT_SIZE -------------------
-- DROP TABLE PRODUCT_SIZE
GO
CREATE TABLE PRODUCT_SIZE
(
	[ID] INT IDENTITY(1,1) PRIMARY KEY,
	[PRODUCT_ID] INT NOT NULL,
    [SIZES_ID] INT NOT NULL,
	[BARCODE] VARCHAR(10) NOT NULL UNIQUE,
	[QUANTITY] INT NOT NULL,
	[ACTIVE] BIT DEFAULT 1
	FOREIGN KEY (PRODUCT_ID) REFERENCES PRODUCT(ID),
    FOREIGN KEY (SIZES_ID) REFERENCES SIZES(ID)
)

GO
INSERT INTO [PRODUCT_SIZE] ([PRODUCT_ID], [SIZES_ID], [BARCODE], [QUANTITY])
VALUES 
(1, 2, '0000000001', 20),
(1, 3, '0000000002', 20),
(1, 4, '0000000003', 20),
(1, 5, '0000000004', 20),
(2, 6, '0000001001', 20),
(2, 7, '0000001002', 20),
(2, 8, '0000001003', 20),
(2, 9, '0000001004', 20),
(2, 10, '0000001005', 20),
(3, 1, '0000002000', 20)

------------------- INVOICE -------------------
-- DROP TABLE INVOICE
GO
CREATE TABLE INVOICE
(
	[ID] INT IDENTITY(1,1) PRIMARY KEY,
	[ACCOUNT_ID] INT NOT NULL,
	[CUSTOMER_ID] INT NOT NULL,
	[CODE] VARCHAR(20) NULL UNIQUE,
	[CREATED_DATE] DATE DEFAULT GETDATE(),
	[EXCHANGE_DATE] DATE DEFAULT DATEADD(WEEK, 1, GETDATE()),
	[VOUCHER_DATE] DATE DEFAULT DATEADD(MONTH, 1, GETDATE()),
	[USED_EXCHANGE] BIT DEFAULT 0,
	[USED_VOUCHER] BIT DEFAULT 0,
	[TOTAL_ITEM] INT DEFAULT 0,
	[TOTAL_ORIGIN] FLOAT DEFAULT 0,
	[DISCOUNT_AMOUNT] FLOAT DEFAULT 0,
	[DISCOUNT_VOUCHER] FLOAT DEFAULT 0,
	[TOTAL_AMOUNT] FLOAT DEFAULT 0,
	[RECEIVE] INT NOT NULL,
	[NEXT_DISCOUNT_VOUCHER] FLOAT DEFAULT 0,
	[MIN_AMOUNT_REQUIRED] INT DEFAULT 0,
	FOREIGN KEY(ACCOUNT_ID) REFERENCES ACCOUNT(ID),
	FOREIGN KEY(CUSTOMER_ID) REFERENCES CUSTOMER(ID)
)

GO
CREATE TRIGGER GenerateInvoiceCode
    ON INVOICE
    AFTER INSERT
AS
BEGIN
	DECLARE @InvoiceId VARCHAR(10), @CreateDatePart VARCHAR(6), @TotalAmount FLOAT, @DiscountVoucher FLOAT
    DECLARE @NewInvoiceCode VARCHAR(18)
	DECLARE @RandomPart INT

	SELECT 
		@InvoiceId = CAST(ID AS VARCHAR(10)),
		@CreateDatePart = FORMAT(CREATED_DATE, 'ddMMyy'),
		@TotalAmount = TOTAL_AMOUNT,
		@DiscountVoucher = DISCOUNT_VOUCHER 
	FROM inserted

	DECLARE @RandomDigits INT = 10 - LEN(@InvoiceId)
	SET @RandomPart = CAST(RAND() * ((9 * POWER(10, @RandomDigits-1)) + (1 * POWER(10, @RandomDigits-1))) AS INT)

	WHILE 1 = 1
    BEGIN
		SET @NewInvoiceCode = @CreateDatePart + '00' + CAST(@RandomPart AS VARCHAR(9)) + @InvoiceId
        IF LEN(@NewInvoiceCode) = 18 AND NOT EXISTS (SELECT 1 FROM INVOICE WHERE CODE = @NewInvoiceCode)
        BEGIN
            BREAK
        END
		SET @RandomPart = @RandomPart + 1
    END

	DECLARE @AfterDiscount FLOAT = @TotalAmount - @DiscountVoucher
    UPDATE INVOICE
	SET 
		CODE = @NewInvoiceCode,
		TOTAL_AMOUNT = @AfterDiscount,
		NEXT_DISCOUNT_VOUCHER = @AfterDiscount * 0.05,
		MIN_AMOUNT_REQUIRED = @AfterDiscount * 0.5
	FROM INVOICE INNER JOIN inserted ON INVOICE.ID = inserted.ID
END

GO
INSERT INTO [INVOICE] ([ACCOUNT_ID], [CUSTOMER_ID], [RECEIVE])
VALUES (1, 0, 500);

GO
INSERT INTO [INVOICE] ([ACCOUNT_ID], [CUSTOMER_ID],[DISCOUNT_VOUCHER], [RECEIVE])
VALUES (1, 0, 10.5, 250);


------------------- INVOICE_DETAIL -------------------
-- DROP TABLE INVOICE_DETAIL
GO
CREATE TABLE INVOICE_DETAIL
(
	[ID] INT IDENTITY(1,1) PRIMARY KEY,
	[INVOICE_ID] INT NOT NULL,
	[PRODUCT_SIZE_ID] INT NOT NULL,
	[BARCODE] VARCHAR(10) NOT NULL,
	[QUANTITY] INT NOT NULL,
	[PRICE] FLOAT DEFAULT 0,
	[ORIGIN] FLOAT DEFAULT 0,
	[DISCOUNT] FLOAT DEFAULT 0,
	[AMOUNT] FLOAT DEFAULT 0,
	[EXCHANGE_QUANTITY] INT DEFAULT 0
	FOREIGN KEY(INVOICE_ID) REFERENCES INVOICE(ID),
	FOREIGN KEY(PRODUCT_SIZE_ID) REFERENCES PRODUCT_SIZE(ID),
)

GO
CREATE TRIGGER UpdateInvoiceDetails
	ON INVOICE_DETAIL
	AFTER INSERT
AS
BEGIN
    DECLARE @InvoiceId INT, @ProductSizeId INT, @Quantity INT

    DECLARE @Price FLOAT, @PercentDiscount FLOAT

    -- Get ID, QUANTITY, PRODUCT_SIZE_ID from inserted
    SELECT @InvoiceId = INVOICE_ID, @Quantity = QUANTITY, @ProductSizeId = PRODUCT_SIZE_ID FROM inserted

	-- Truy xuất thông tin giá và giảm giá từ bảng PRODUCT
    SELECT 
        @Price = P.PRICE,
        @PercentDiscount = P.PERCENT_DISCOUNT
    FROM PRODUCT_SIZE PS
    INNER JOIN PRODUCT P ON PS.PRODUCT_ID = P.ID
    INNER JOIN SIZES S ON PS.SIZES_ID = S.ID
    WHERE PS.ID = @ProductSizeId

	DECLARE @Origin FLOAT = @Price * @Quantity
	DECLARE @Discount FLOAT = @Origin * @PercentDiscount
	DECLARE @Amount FLOAT = @Origin - @Discount

	-- Cập nhật các cột của INVOICE_DETAIL
	UPDATE INVOICE_DETAIL
    SET 
        PRICE = @Price,
		ORIGIN = @Origin,
        DISCOUNT = @Discount,
        AMOUNT = @Amount
    FROM INVOICE_DETAIL INNER JOIN inserted ON INVOICE_DETAIL.ID = inserted.ID

    -- Cập nhật các cột của INVOICE
    UPDATE INVOICE
    SET
        TOTAL_ITEM = TOTAL_ITEM + @Quantity,
        TOTAL_ORIGIN = TOTAL_ORIGIN + @Origin,
        DISCOUNT_AMOUNT = DISCOUNT_AMOUNT + @Discount,
		TOTAL_AMOUNT = TOTAL_AMOUNT + @Amount,
        NEXT_DISCOUNT_VOUCHER = NEXT_DISCOUNT_VOUCHER + @Amount * 0.05,
        MIN_AMOUNT_REQUIRED = MIN_AMOUNT_REQUIRED + @Amount * 0.5
    WHERE ID = @InvoiceId

    -- Giảm QUANTITY trong PRODUCT_SIZE
    UPDATE PRODUCT_SIZE
    SET 
        QUANTITY = QUANTITY - @Quantity
    WHERE ID = @ProductSizeId
END

GO
INSERT INTO [INVOICE_DETAIL] ([INVOICE_ID], [PRODUCT_SIZE_ID], [BARCODE], [QUANTITY])
VALUES (1, 1, '0000000001', 2);
GO
INSERT INTO [INVOICE_DETAIL] ([INVOICE_ID], [PRODUCT_SIZE_ID], [BARCODE], [QUANTITY])
VALUES (1, 5, '0000001001', 2);
GO
INSERT INTO [INVOICE_DETAIL] ([INVOICE_ID], [PRODUCT_SIZE_ID], [BARCODE], [QUANTITY])
VALUES (1, 10, '0000002000', 1);
GO
INSERT INTO [INVOICE_DETAIL] ([INVOICE_ID], [PRODUCT_SIZE_ID], [BARCODE], [QUANTITY])
VALUES (2, 10, '0000002000', 1);


--GO -- TRIGGER CAP NHAT CONG VAO SO LUONG DOI --
--CREATE TRIGGER tg_SANPHAMSIZE_CAPNHATSOLUONGDOI
--	ON CTHD
--	AFTER UPDATE
--AS BEGIN
--	DECLARE @MASP VARCHAR(20)
--	DECLARE @MASIZE VARCHAR(10)
--	DECLARE @SOLUONGDOI INT
--	SELECT @MASP = MASP, @MASIZE = MASIZE, @SOLUONGDOI = SOLUONGDOI FROM inserted

--	UPDATE SANPHAM_SIZE SET SOLUONG = SOLUONG + @SOLUONGDOI WHERE MASP = @MASP AND MASIZE = @MASIZE
--END