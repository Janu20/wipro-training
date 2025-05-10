Create table Products (
ProductID INT PRIMARY KEY,
ProductName varchar(50),
Price DECIMAL(10,2));

Create table Orders(
OrderID INT PRIMARY KEY,
ProductID INT,
Quantity INT,
OrderdDate DATE,
FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

insert into products (ProductID, ProductName, Price)
VALUES
(1, 'Laptop', 70000.00),
(2, 'Smartphone', 30000.00),
(3, 'Tablet', 20000.00),
(4, 'Monitor', 15000.00);

select * from products;

insert into Orders(OrderID, ProductID, Quantity, OrderdDate)
VALUES
(101, 1, 2, '2024-12-01'),
(102, 2, 1, '2024-12-05'),
(103, 3, 3, '2024-12-10'),
(104, 1, 1, '2024-12-15'),
(105, 4, 2, '2024-12-20');

select*from orders;

select
orders.orderId,
products.productname,
orders.quantity,
products.price,
(orders.quantity * products.price) as totalamount,
orders.orderddate
from orders inner join products on orders.productId =products.productID;


select
products.productid,
products.productname,
orders.orderid,
orders.quantity,
orders.orderddate
from products right join orders on products.productID = orders.productID;

select
products.productid,
products.productname,
orders.orderid,
orders.quantity,
orders.orderddate
from products left join orders on products.productID = orders.productID;

select 
products.productname,
sum(orders.Quantity) as totalunitssold
from orders inner join products on orders.productId =products.productID
group by products.productname;

