CREATE PROCEDURE CheckProductExists
 @ProductID INT
 AS
 BEGIN
   IF EXISTS (SELECT 1 FROM Products WHERE ProductID = @ProductID)
      PRINT 'Product exists';
   ELSE
     PRINT 'Product not found';
 END;

 EXEC CheckProductExists @ProductID =1;