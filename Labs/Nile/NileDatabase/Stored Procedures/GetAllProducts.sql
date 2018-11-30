-- Carlos Fuentes
-- ITSE 1430
-- November 23, 2018
-- GetAllProducts.sql

CREATE PROCEDURE [dbo].[GetAllProducts]	
AS BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, Price, Description, IsDiscontinued
    FROM Products
END
