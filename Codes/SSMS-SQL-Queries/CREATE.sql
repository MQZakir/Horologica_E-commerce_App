-- Creating table for addresses
CREATE TABLE addressInfo (addressID int PRIMARY KEY IDENTITY(11, 1), city varchar(50) NOT NULL, street varchar(50) NOT NULL, buildingNo int);


-- Creating table for brands
CREATE TABLE brand (brandID int PRIMARY KEY IDENTITY (101, 1), brandName varchar(50) NOT NULL);


-- Creating the table for login information
CREATE TABLE loginInfo (loginID int PRIMARY KEY IDENTITY(1, 1), username varchar(50) NOT NULL, password varchar(50) NOT NULL);


-- Creating the table for customer
CREATE TABLE customer (customerID int PRIMARY KEY IDENTITY(111, 1), name varchar(100) NOT NULL, 
						contactNo varchar(20) NOT NULL, email varchar(100) NOT NULL, age int NOT NULL, 
						addressID int NOT NULL, loginID int NOT NULL, 
						FOREIGN KEY (addressID) REFERENCES addressInfo(addressID), FOREIGN KEY (loginID) REFERENCES loginInfo(loginID));


-- Creating the table for supplier
CREATE TABLE supplier (supplierID int PRIMARY KEY IDENTITY(10, 3), supplierName varchar(50) NOT NULL, quantity int NOT NULL);


-- Creating table for products
CREATE table product (productID int PRIMARY KEY IDENTITY(1011, 1), productName varchar(100) NOT NULL, 
						quantity int NOT NULL, price DECIMAL(30, 2) NOT NULL, brandID int NOT NULL, supplierID int NOT NULL, img varchar(50) NOT NULL,
						FOREIGN KEY (brandID) REFERENCES brand(brandID), FOREIGN KEY (supplierID) REFERENCES supplier(supplierID));


-- Creating table for bag
CREATE TABLE bag (bagID int PRIMARY KEY IDENTITY(100, 5), customerID int NOT NULL, productID int NOT NULL, productQuantity int NOT NULL, bagTotal DECIMAL(30, 2) NOT NULL,
					FOREIGN KEY (productID) REFERENCES product(productID), FOREIGN KEY (customerID) REFERENCES customer(customerID));


-- Crating table for orderDescription
CREATE TABLE orderDescription (descriptionID int PRIMARY KEY IDENTITY(10, 10), orderStatus varchar(50) NOT NULL CHECK (orderStatus in ('Confirmed', 'Canceled', 'Delivered')), 
								orderDate date NOT NULL, orderQuantity int NOT NULL, customerID int NOT NULL, total DECIMAL(30, 2) NOT NULL, 
								FOREIGN KEY (customerID) REFERENCES customer(customerID));


-- Creating table for orders
CREATE TABLE orderInfo (orderID int PRIMARY KEY IDENTITY(1, 4), descriptionID int NOT NULL, orderProductID int NOT NULL, 
						FOREIGN KEY (descriptionID) REFERENCES orderDescription(descriptionID), FOREIGN KEY (orderProductID) REFERENCES orderProduct(orderProductID));
