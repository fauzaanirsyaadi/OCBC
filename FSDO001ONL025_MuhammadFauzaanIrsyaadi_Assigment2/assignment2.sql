create table productLines(
productLine int identity(1,1) primary key NOT NULL,
textDescription varchar(100),
htmlDescription varchar(100),
image varchar(100)
);

create table products(
productCode int identity(1,1) NOT NULL,
productName varchar(100),
productLine int NOT NULL,
productScale varchar(50),
productVendor varchar(50),
productDescription varchar(250),
qtyInStock int,
buyPrice int,
MSRP varchar(50),
primary key (productCode),
foreign key (productLine) references productLines(productLine)
)

create table offices(
officeCode int identity(1,1) NOT NULL,
city varchar(50),
phone varchar(13),
addressLine1 varchar(50),
addressLine2 varchar(50),
state varchar(50),
country varchar(50),
postalcode int,
territory varchar(50),
primary key (officeCode)
)

create table employees(
employeeNumber int identity(1,1) NOT NULL,
lastName varchar(50),
firstName varchar(50),
extension varchar(10),
email varchar(50),
officeCode int,
reportsTO int,
jobTitle varchar(50),
primary key (employeeNumber),
foreign key (officeCode) references offices(officeCode),
foreign key (reportsTO) references employees(employeeNumber)
)

create table customers(
customerNumber int identity(1,1) NOT NULL,
customerName varchar(100),
contactLastName varchar(100),
contactFirstName varchar(100),
phone varchar(14),
addressLine1 varchar(100),
addressLine2 varchar(100),
city varchar(50),
state varchar(50),
postalCode int,
country varchar(50),
salesRepEmployeeNumber int NOT NULL,
creditLimit int,
primary key (customerNumber),
foreign key (salesRepEmployeeNumber) references employees(employeeNumber)
)

create table payments(
customerNumber int NOT NULL,
checkNumber int identity(1,1) NOT NULL,
paymentDate date,
amount float,
primary key (customerNumber, checkNumber))

create table orders(
orderNumber int identity(1,1) NOT NULL,
orderDate date,
requiredDate date,
shippedDate date,
status varchar(10),
comments varchar(100),
customerNumber int NOT NULL, 
primary key (orderNumber),
foreign key (customerNumber) references customers(customerNumber)
)

create table orderdetails(
orderNumber int NOT NULL,
productCode int NOT NULL,
quantityOrdered int,
priceEach int,
orderLineNumber int,
primary key (orderNumber , productCode),
foreign key (orderNumber) references orders(orderNumber),
foreign key (productCode) references products(productCode)
)

--productLines
insert into productLines (textDescription, htmlDescription, image) values ('textDescription1', 'htmlDescription1', 'image1');
insert into productLines (textDescription, htmlDescription, image) values ('textDescription2', 'htmlDescription2', 'image2');
insert into productLines (textDescription, htmlDescription, image) values ('textDescription3', 'htmlDescription3', 'image3');
insert into productLines (textDescription, htmlDescription, image) values ('textDescription4', 'htmlDescription4', 'image4');
insert into productLines (textDescription, htmlDescription, image) values ('textDescription5', 'htmlDescription5', 'image5');

--products
insert into products (productName, productLine, productScale, productVendor,productDescription, qtyInStock, buyPrice, MSRP)
values ('productName1', 1, '3x4', 'productVendor', 'productDescription', 30, 30000, 'MSRP');
insert into products (productName, productLine, productScale, productVendor,productDescription, qtyInStock, buyPrice, MSRP)
values ('productName2', 1, '3x4', 'productVendor', 'productDescription', 30, 30000, 'MSRP');
insert into products (productName, productLine, productScale, productVendor,productDescription, qtyInStock, buyPrice, MSRP)
values ('productName3', 2, '3x4', 'productVendor', 'productDescription', 30, 30000, 'MSRP');
insert into products (productName, productLine, productScale, productVendor,productDescription, qtyInStock, buyPrice, MSRP)
values ('productName4', 2, '3x4', 'productVendor', 'productDescription', 30, 30000, 'MSRP');
insert into products (productName, productLine, productScale, productVendor,productDescription, qtyInStock, buyPrice, MSRP)
values ('productName5', 3, '3x4', 'productVendor', 'productDescription', 30, 30000, 'MSRP');

--offices
insert into offices (city, phone,addressLine1, addressLine2, state,country,postalcode,territory) 
values ('city1', '0123456789','addressLine1', 'addressLine2', 'state', 'country', 0123, 'territory')
insert into offices (city, phone,addressLine1, addressLine2, state,country,postalcode,territory) 
values ('city2', '0123456789','addressLine1', 'addressLine2', 'state', 'country', 0123, 'territory')
insert into offices (city, phone,addressLine1, addressLine2, state,country,postalcode,territory) 
values ('city3', '0123456789','addressLine1', 'addressLine2', 'state', 'country', 0123, 'territory')
insert into offices (city, phone,addressLine1, addressLine2, state,country,postalcode,territory) 
values ('city4', '0123456789','addressLine1', 'addressLine2', 'state', 'country', 0123, 'territory')
insert into offices (city, phone,addressLine1, addressLine2, state,country,postalcode,territory) 
values ('city5', '0123456789','addressLine1', 'addressLine2', 'state', 'country', 0123, 'territory')

--employees
insert into employees (lastName, firstName, extension, email, officeCode, reportsTo, jobTitle) 
values ('Nel', 'Ant', '0123', 'asd@gmail.com', 1, NULL, 'Senior Developer')
insert into employees (lastName, firstName, extension, email, officeCode, reportsTo, jobTitle) 
values ('Nel1', 'Ant', '0123', 'asd@gmail.com', 1, 5, 'Junior Developer')
insert into employees (lastName, firstName, extension, email, officeCode, reportsTo, jobTitle) 
values ('Nel2', 'Ant', '0123', 'asd@gmail.com', 1, 5, 'Junior Developer')
insert into employees (lastName, firstName, extension, email, officeCode, reportsTo, jobTitle) 
values ('Nel3', 'Ant', '0123', 'asd@gmail.com', 1, 2, 'intern Developer')
insert into employees (lastName, firstName, extension, email, officeCode, reportsTo, jobTitle) 
values ('Nel4', 'Ant', '0123', 'asd@gmail.com', 1, 2, 'intern Developer')

--customers
insert into customers (customerName, contactLastName, 
contactFirstName, phone, addressLine1,addressLine2, 
city, state, postalCode, country, salesRepEmployeeNumber, 
creditLimit) 
values ('customerName1', 'contactLastName1', 'contactFirstName', '0123456789', 'addressLine1', 'addressLine2', 'city', 'state', 0123, 'country', 5, 30000)

insert into customers (customerName, contactLastName, 
contactFirstName, phone, addressLine1,addressLine2, 
city, state, postalCode, country, salesRepEmployeeNumber, 
creditLimit) 
values ('customerName2', 'contactLastName2', 'contactFirstName', '0123456789', 'addressLine1', 'addressLine2', 'city', 'state', 0123, 'country', 5, 30000)

insert into customers (customerName, contactLastName, 
contactFirstName, phone, addressLine1,addressLine2, 
city, state, postalCode, country, salesRepEmployeeNumber, 
creditLimit) 
values ('customerName3', 'contactLastName3', 'contactFirstName', '0123456789', 'addressLine1', 'addressLine2', 'city', 'state', 0123, 'country', 5, 30000)

insert into customers (customerName, contactLastName, 
contactFirstName, phone, addressLine1,addressLine2, 
city, state, postalCode, country, salesRepEmployeeNumber, 
creditLimit) 
values ('customerName4', 'contactLastName4', 'contactFirstName', '0123456789', 'addressLine1', 'addressLine2', 'city', 'state', 0123, 'country', 5, 30000)

insert into customers (customerName, contactLastName, 
contactFirstName, phone, addressLine1,addressLine2, 
city, state, postalCode, country, salesRepEmployeeNumber, 
creditLimit) 
values ('customerName5', 'contactLastName5', 'contactFirstName', '0123456789', 'addressLine1', 'addressLine2', 'city', 'state', 0123, 'country', 5, 30000)

--payments
insert into payments (customerNumber, paymentDate, amount) 
values (1, '2021/10/13', 1000000)
insert into payments (customerNumber, paymentDate, amount) 
values (2, '2021/10/13', 2000000)
insert into payments (customerNumber, paymentDate, amount) 
values (3, '2021/10/15', 3000000)
insert into payments (customerNumber, paymentDate, amount) 
values (4, '2021/10/15', 4000000)
insert into payments (customerNumber, paymentDate, amount) 
values (5, '2021/10/15', 5000000)

--orders
insert into orders (orderDate, requiredDate, shippedDate, status, comments, customerNumber) 
values ('2021/9/21', '2021/9/23', '2021/9/25', 'shipped', '-', 1)
insert into orders (orderDate, requiredDate, shippedDate, status, comments, customerNumber) 
values ('2021/9/21', '2021/9/23', '2021/9/25', 'recieved', '-', 2)
insert into orders (orderDate, requiredDate, shippedDate, status, comments, customerNumber) 
values ('2021/9/21', '2021/9/23', '2021/9/25', 'shipped', '-', 3)
insert into orders (orderDate, requiredDate, shippedDate, status, comments, customerNumber) 
values ('2021/9/21', '2021/9/23', '2021/9/25', 'recieved', '-', 4)
insert into orders (orderDate, requiredDate, shippedDate, status, comments, customerNumber) 
values ('2021/9/21', '2021/9/23', '2021/9/25', 'shipped', '-', 5)

--orderdetails
insert into orderdetails (orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber) 
values (1, 1, 10, 10000, 1)
insert into orderdetails (orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber) 
values (2, 2, 20, 20000, 2)
insert into orderdetails (orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber) 
values (3, 3, 30, 30000, 3)
insert into orderdetails (orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber) 
values (4, 4, 40, 40000, 4)
insert into orderdetails (orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber) 
values (5, 5, 50, 50000, 5)
