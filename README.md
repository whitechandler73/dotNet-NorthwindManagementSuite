# Northwind Database Management Suite

##### Northwind Management Suite is a database access and modifying utility created by our development team for CITC2312 semester project.

### Team Members: 
Team Member | Position
------------ | -------------
Chandler White | _Team Lead_
Daniel Lucy | _Database Administrator / Back end developer_
Brandon Morgan | _Marketing / Information Designer_
Gregory Sullivan | _Software Developer_
C.J. Kee | _Software Developer_

### Content Goal
Windows based graphical application to create, read, update, and delete data for Northwind Food Supply

### Audience 
Northwind database administrators and employees

------------------------------------------------------------------------------------------
## Business Need:

Management database for a small depot that supplies local restaurants in Scranton, Pennslyvania. We need a database to localize all of our data regarding customers, orders, and shipment, employees, and product details.

### Tables:

* Categories
   * CategoryID
   * CategoryName
   * Description 
* Customers 
   * CustomerID
   * CustomerName
   * ContactName
   * Address
   * City
   * PostalCode
   * Country
* Employees
   * EmployeeID
   * LastName
   * FirstName
   * BirthDate
   * Photo
   * Notes
* Order_Details
   * OrderDetailID
   * OrderID
   * ProductID
   * Quantity
* Orders 
   * OrderID
   * CustomerID
   * EmployeeID
   * OrderDate
   * ShipperID 
* Products
   * ProductID
   * ProductName
   * SupplierID
   * CategoryID
   * Unit
   * Price
* Shippers
   * ShipperID
   * ShipperName
   * Phone
* Suppliers
   * SupplierID
   * SupplierName
   * ContactName
   * Address
   * City
   * PostalCode
   * Country
   * Phone
