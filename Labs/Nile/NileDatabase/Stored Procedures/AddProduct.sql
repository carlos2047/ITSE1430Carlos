-- Carlos Fuentes
-- ITSE 1430
-- November 23, 2018
-- AddProduct.sql

CREATE PROCEDURE [dbo].[AddProduct]
	@name NVARCHAR(100),
    @price MONEY,    
    @description NVARCHAR(MAX) = NULL,
	@isDiscontinued BIT = 0
AS BEGIN
    SET NOCOUNT ON;

    INSERT INTO Products (Name, Price, Description, IsDiscontinued) VALUES (@name, @price, @description, @isDiscontinued)

    SELECT SCOPE_IDENTITY()
END
