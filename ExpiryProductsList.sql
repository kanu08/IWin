CREATE PROCEDURE GetNearExpiryProducts_SP
AS
BEGIN
SET NOCOUNT ON
 
SELECT ProductID,ProductName,ProductDescription,ProductExpiryDate,Price  FROM 
Product where DATEDIFF(day,GETDATE(), ProductExpiryDate) BETWEEN 0 AND 5
 
END
