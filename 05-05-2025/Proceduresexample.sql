CREATE PROCEDURE GetAllProducts
AS
BEGIN
SELECT* FROM Products;
END;


EXEC GetAllProducts;

CREATE PROCEDURE HigerEndProducts
AS
BEGIN
SELECT * FROM Products where Price > 60000;
END;

EXEC HigerEndProducts;

Create Procedure GetOrdersByProducts
@ProductID INT
As
Begin
Select 
o.orderId,
o.Quantity,
o.Orderddate,
p.ProductName,
p.Price
from Orders o
Inner Join Products p on o.ProductId = p.ProductID
Where o.ProductID = @ProductID;
END;

EXEC GetOrdersByProducts @ProductID = 1;

Create Procedure GetProductRevenuess 
@ProductID INT
As 
BEGIN
Select
o.Quantity,
p.Price,
(o.Quantity*p.Price)As TotalRevenue
From orders o
Inner Join Products p ON o.productID =p.ProductID
where o.productId = @productId;
End;

EXEC GetProductRevenuess @ProductID = 1;