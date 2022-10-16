// See https://aka.ms/new-console-template for more information


using NorthwindC;
// Console.WriteLine
Console.WriteLine("Hello, World!");

// list of Category
Category aCategory1 = new Category(4,"table","rectangle");
Category aCategory2 = new Category(3, "chair", "round");
// giving value

//aCategory1.CategoryId = 4;
//aCategory1.CategoryName = "table";
//aCategory1.Description = "rectangle";
// Console.WriteLine
Console.WriteLine("CategoryId:" + aCategory1.CategoryId);
Console.WriteLine("CategoryName:" + aCategory1.CategoryName);
Console.WriteLine("Description:" + aCategory1.Description);

//aCategory2.CategoryId = 3;
//aCategory2.CategoryName = "chair";
//aCategory2.Description = "round";
// Console.WriteLine
Console.WriteLine("CategoryId:" + aCategory2.CategoryId);
Console.WriteLine("CategoryName:" + aCategory2.CategoryName);
Console.WriteLine("Description:" + aCategory2.Description);
// add list

List<Category> aListOfCategories = new List<Category>();

aListOfCategories.Add(aCategory1);
aListOfCategories.Add(aCategory2);

// loop

foreach (var c in aListOfCategories)
{
    Console.WriteLine(c.ToString());
    Console.WriteLine("\n\n\n");
}



// list of customers
// giving value

Customer aCustomer1 = new Customer("15001", "apple","samson", "manager", "saris","addis ababa","oromia","56001","Ethiopia","0912132311", "1234567891");

Customer aCustomer2 = new Customer("14001", "apple", "sante", "manager", "saris", "A.A", "Oromia", "56001", "Ethiopia", "0912134567", "0912345678");











//aCustomer1.CustomerId = "15001";
//aCustomer1.CompanyName = "apple";
//aCustomer1.ContactName = "samson";
//aCustomer1.ContactTitle = "manager";
//aCustomer1.Address = "saris";
//aCustomer1.City = "addis ababa";
//aCustomer1.Region = "oromia";
//aCustomer1.PostalCode = "56001";
//aCustomer1.Country = "Ethiopia";
//aCustomer1.Phone = "0912132311";
//aCustomer1.Fax = "1234567891";

// Console.WriteLine
Console.WriteLine("CustomerId :" + aCustomer1.CustomerId);
Console.WriteLine("CompanyName:" + aCustomer1.CompanyName);
Console.WriteLine("ContactName:" + aCustomer1.ContactName);
Console.WriteLine("ContactTitle:" + aCustomer1.ContactTitle);
Console.WriteLine("Address:" + aCustomer1.Address);
Console.WriteLine("City:" + aCustomer1.City);
Console.WriteLine("Region:" + aCustomer1.Region);
Console.WriteLine("PostalCode:" + aCustomer1.PostalCode);
Console.WriteLine("Country:" + aCustomer1.Country);
Console.WriteLine("Phone:" + aCustomer1.Phone);
Console.WriteLine("Fax:" + aCustomer1.Fax);

//aCustomer2.CustomerId = "14001";
//aCustomer2.CompanyName = "apple";
//aCustomer2.ContactName = "sante";
//aCustomer2.ContactTitle = "manager";
//aCustomer2.Address = "saris";
//aCustomer2.City = "A.A";
//aCustomer2.Region = "Oromia";
//aCustomer2.PostalCode = "56001";
//aCustomer2.Country = "Ethiopia"; ;
//aCustomer2.Phone = "0912134567";
//aCustomer2.Fax = "0912345678";

// Console.WriteLine
Console.WriteLine("CustomerId :" + aCustomer2.CustomerId);
Console.WriteLine("CompanyName:" + aCustomer2.CompanyName);
Console.WriteLine("ContactName:" + aCustomer2.ContactName);
Console.WriteLine("ContactTitle:" + aCustomer2.ContactTitle);
Console.WriteLine("Address:" + aCustomer2.Address);
Console.WriteLine("City:" + aCustomer2.City);
Console.WriteLine("Region:" + aCustomer2.Region);
Console.WriteLine("PostalCode:" + aCustomer2.PostalCode);
Console.WriteLine("Country:" + aCustomer2.Country);
Console.WriteLine("Phone:" + aCustomer2.Phone);
Console.WriteLine("Fax:" + aCustomer2.Fax);

// add list
List<Customer> aListOfCustomers = new List<Customer>();

aListOfCustomers.Add(aCustomer1);
aListOfCustomers.Add(aCustomer2);

//loop

foreach (var cu in aListOfCustomers)
{
    Console.WriteLine(cu.ToString());
    Console.WriteLine("\n\n\n");
}


// list of employees
// giving value


Employee aEmployee1 = new Employee(1234, "Abebe", "Bikila", "runner", "Ato", "sept 2", "sept 3", "Bole", "A.A", "Amhara", "56001", "Ethiopia", "9091234567", "9094567892", "Impeccible", -2);
Employee aEmployee2 = new Employee(1412, "Abebe", "Firomi", "Mr", "Mr", "nov 2", "nov 3", "semit", "A.A", "Bole", "56001", "Ethiopia", "0912345678", "0912456783", "nice", -3);

//aEmployee1.EmployeeId = 1234;
//aEmployee1.LastName = "Abebe";
//aEmployee1.FirstName = "Bikila";
//aEmployee1.Title = "runner";
//aEmployee1.TitleOfCourtesy = "Ato";
//aEmployee1.BirthDate = "sept 2";
//aEmployee1.HireDate = "sept 3";
//aEmployee1.Address = "Bole";
//aEmployee1.City = "A.A";
//aEmployee1.Region = "Amhara";
//aEmployee1.PostalCode = "56001";
//aEmployee1.Country = "Ethiopia";
//aEmployee1.HomePhone = "9091234567";
//aEmployee1.Extension = "9094567892";
//aEmployee1.Notes = "Impeccible";
//aEmployee1.ReportsTo = -2;

// Console.WriteLine

Console.WriteLine("EmployeeId :" + aEmployee1.EmployeeId);
Console.WriteLine("LastName :" + aEmployee1.LastName);
Console.WriteLine("FirstName:" + aEmployee1.FirstName);
Console.WriteLine("Title:" + aEmployee1.Title);
Console.WriteLine("TitleOfCourtesy:" + aEmployee1.TitleOfCourtesy);
Console.WriteLine("BirthDate:" + aEmployee1.BirthDate);
Console.WriteLine("HireDate:" + aEmployee1.HireDate);
Console.WriteLine("Address :" + aEmployee1.Address);
Console.WriteLine("City :" + aEmployee1.City);
Console.WriteLine("Region:" + aEmployee1.Region);
Console.WriteLine("PostalCode:" + aEmployee1.PostalCode);
Console.WriteLine("Country:" + aEmployee1.Country);
Console.WriteLine("HomePhone:" + aEmployee1.HomePhone);
Console.WriteLine("Extension  :" + aEmployee1.Extension);
Console.WriteLine("Notes :" + aEmployee1.Notes);
Console.WriteLine("ReportsTo :" + aEmployee1.ReportsTo);

//aEmployee2.EmployeeId = 1412;
//aEmployee2.FirstName = "Firomi";
//aEmployee2.Title = "Mr";
//aEmployee2.TitleOfCourtesy = "Mr";
//aEmployee2.BirthDate = "nov 2";
//aEmployee2.HireDate = "nov 3";
//aEmployee2.Address = "semit";
//aEmployee2.Region = "Bole";
//aEmployee2.Country = "Ethiopia";
//aEmployee2.HomePhone = "0912345678";
//aEmployee2.Extension = "0912456783";
//aEmployee2.Notes = "nice";

// Console.WriteLine

Console.WriteLine("EmployeeId :" + aEmployee2.EmployeeId);
Console.WriteLine("LastName :" + aEmployee2.LastName);
Console.WriteLine("FirstName:" + aEmployee2.FirstName);
Console.WriteLine("Title:" + aEmployee2.Title);
Console.WriteLine("TitleOfCourtesy:" + aEmployee2.TitleOfCourtesy);
Console.WriteLine("BirthDate:" + aEmployee2.BirthDate);
Console.WriteLine("HireDate:" + aEmployee2.HireDate);
Console.WriteLine("Address :" + aEmployee2.Address);
Console.WriteLine("City :" + aEmployee2.City);
Console.WriteLine("Region:" + aEmployee2.Region);
Console.WriteLine("PostalCode:" + aEmployee2.PostalCode);
Console.WriteLine("Country:" + aEmployee2.Country);
Console.WriteLine("HomePhone:" + aEmployee2.HomePhone);
Console.WriteLine("Extension  :" + aEmployee2.Extension);
Console.WriteLine("Notes :" + aEmployee2.Notes);
Console.WriteLine("ReportsTo :" + aEmployee2.ReportsTo);
// add list
List<Employee> aListOfEmployees = new List<Employee>();

aListOfEmployees.Add(aEmployee1);
aListOfEmployees.Add(aEmployee2);

// loop

foreach (var e in aListOfEmployees)
{
    Console.WriteLine(e.ToString());
    Console.WriteLine("\n\n\n");
}


// list of orders
// giving value

Order aOrder1 = new Order(700, "12345", 1233, "sep 4", "sep 6", "sep 5", 12, 1, "going merry", "atlas", "nomine", "A.A", "56001", "USA");
Order aOrder2 = new Order(1234, "56789", 13, "sep 6", "sep 8", "sep 7", 2, 1, "Titanic", "persia", "A.A", "Bole", "56001", "Amesterdam");


//aOrder1.OrderId = 700;
//aOrder1.CustomerId = "12345";
//aOrder1.EmployeeId = 1233;
//aOrder1.OrderDate = "sep 4";
//aOrder1.RequiredDate = "sep 6";
//aOrder1.ShippedDate = "sep 5";
//aOrder1.ShipVia = 12;
//aOrder1.Freight = 1;
//aOrder1.ShipName = "going merry";
//aOrder1.ShipAddress = "atlas";
//aOrder1.ShipCity = "nomine";
//aOrder1.ShipRegion = "A.A";
//aOrder1.ShipPostalCode = "56001";
//aOrder1.ShipCountry = "USA";

// Console.WriteLine
Console.WriteLine("OrderId :" + aOrder1.OrderId);
Console.WriteLine("CustomerId :" + aOrder1.CustomerId);
Console.WriteLine("EmployeeId:" + aOrder1.EmployeeId);
Console.WriteLine("OrderDate:" + aOrder1.OrderDate);
Console.WriteLine("RequiredDate:" + aOrder1.RequiredDate);
Console.WriteLine("ShippedDate:" + aOrder1.ShippedDate);
Console.WriteLine("ShipVia:" + aOrder1.ShipVia);
Console.WriteLine("Freight :" + aOrder1.Freight);
Console.WriteLine("ShipName :" + aOrder1.ShipName);
Console.WriteLine("ShipAddress:" + aOrder1.ShipAddress);
Console.WriteLine("ShipCity:" + aOrder1.ShipCity);
Console.WriteLine("ShipRegion:" + aOrder1.ShipRegion);
Console.WriteLine("ShipPostalCode  :" + aOrder1.ShipPostalCode);
Console.WriteLine("ShipCountry :" + aOrder1.ShipCountry);

//aOrder2.OrderId = 1234;
//aOrder2.CustomerId = "56789";
//aOrder2.EmployeeId = 13;
//aOrder2.OrderDate = "sep 6";
//aOrder2.RequiredDate = "sep 8";
//aOrder2.ShippedDate = "sep 7";
//aOrder2.ShipVia = 2;
//aOrder2.Freight = 1;
//aOrder2.ShipName = "Titanic";
//aOrder2.ShipAddress = "persia";
//aOrder2.ShipCity = "A.A";
//aOrder2.ShipRegion = "Bole";
//aOrder2.ShipPostalCode = "56001";
//aOrder2.ShipCountry = "Amesterdam";

// Console.WriteLine
Console.WriteLine("OrderId :" + aOrder2.OrderId);
Console.WriteLine("CustomerId :" + aOrder2.CustomerId);
Console.WriteLine("EmployeeId:" + aOrder2.EmployeeId);
Console.WriteLine("OrderDate:" + aOrder2.OrderDate);
Console.WriteLine("RequiredDate:" + aOrder2.RequiredDate);
Console.WriteLine("ShippedDate:" + aOrder2.ShippedDate);
Console.WriteLine("ShipVia:" + aOrder2.ShipVia);
Console.WriteLine("Freight :" + aOrder2.Freight);
Console.WriteLine("ShipName :" + aOrder2.ShipName);
Console.WriteLine("ShipAddress:" + aOrder2.ShipAddress);
Console.WriteLine("ShipCity:" + aOrder2.ShipCity);
Console.WriteLine("ShipRegion:" + aOrder2.ShipRegion);
Console.WriteLine("ShipPostalCode  :" + aOrder2.ShipPostalCode);
Console.WriteLine("ShipCountry :" + aOrder2.ShipCountry);

// add list
List<Order> aListOfOrders = new List<Order>();

aListOfOrders.Add(aOrder1);
aListOfOrders.Add(aOrder2);

// loop
foreach (var o in aListOfOrders)
{
    Console.WriteLine(o.ToString());
    Console.WriteLine("\n\n\n");
}



// list of orders
// give value

OrderDetail aOrderDetail1 = new OrderDetail(77, 78, 2, 3, 1);
OrderDetail aOrderDetail2 = new OrderDetail(79, 80, 3, 4, 5);

//aOrderDetail1.OrderId = 77;
//aOrderDetail1.ProductId = 78;
//aOrderDetail1.UnitPrice = 2;
//aOrderDetail1.Quantity = 3;
//aOrderDetail1.Discount = 1;

// Console.WriteLine

Console.WriteLine("OrderId :" + aOrderDetail1.OrderId);
Console.WriteLine("ProductId :" + aOrderDetail1.ProductId);
Console.WriteLine("UnitPrice:" + aOrderDetail1.UnitPrice);
Console.WriteLine("Quantity:" + aOrderDetail1.Quantity);
Console.WriteLine("Discount  :" + aOrderDetail1.Discount);

//aOrderDetail2.OrderId = 79;
//aOrderDetail2.ProductId = 80;
//aOrderDetail2.UnitPrice = 3;
//aOrderDetail2.Quantity = 4;
//aOrderDetail2.Discount = 5;

// Console.WriteLine

Console.WriteLine("OrderId :" + aOrderDetail2.OrderId);
Console.WriteLine("ProductId :" + aOrderDetail2.ProductId);
Console.WriteLine("UnitPrice:" + aOrderDetail2.UnitPrice);
Console.WriteLine("Quantity:" + aOrderDetail2.Quantity);
Console.WriteLine("Discount  :" + aOrderDetail2.Discount);

// add list

List<OrderDetail> aListOfOrderDetails = new List<OrderDetail>();

aListOfOrderDetails.Add(aOrderDetail1);
aListOfOrderDetails.Add(aOrderDetail2);
// loop

foreach (var od in aListOfOrderDetails)
{
    Console.WriteLine(od.ToString());
    Console.WriteLine("\n\n\n");
}



// list of products
// give value


Product aProduct1 = new Product(1790, "chair", 21, 23, "two", 2, 3, 4, 5, true);
Product aProduct2 = new Product(112, "table", 34, 43, "one", 15, 16, 17, 1, true);



//aProduct1.ProductId = 1790;
//aProduct1.ProductName = "chair";
//aProduct1.SupplierId = 21;
//aProduct1.CategoryId = 23;
//aProduct1.QuantityPerUnit = "two";
//aProduct1.UnitPrice = 2;
//aProduct1.UnitsInStock = 3;
//aProduct1.UnitsInOrder = 4;
//aProduct1.ReorderLevel = 5;
//aProduct1.Discontinued = true;// by default , boolean is true

// Console.WriteLine

Console.WriteLine("ProductId :" + aProduct1.ProductId);
Console.WriteLine("ProductName :" + aProduct1.ProductName);
Console.WriteLine("SupplierId:" + aProduct1.SupplierId);
Console.WriteLine("CategoryId:" + aProduct1.CategoryId);
Console.WriteLine("QuantityPerUnit:" + aProduct1.QuantityPerUnit);
Console.WriteLine("UnitPrice:" + aProduct1.UnitPrice);
Console.WriteLine("UnitsInStock:" + aProduct1.UnitsInStock);
Console.WriteLine("UnitsInOrder :" + aProduct1.UnitsInOrder);
Console.WriteLine("ReorderLevel :" + aProduct1.ReorderLevel);
Console.WriteLine("Discontinued :" + aProduct1.Discontinued);

//aProduct2.ProductId = 112;
//aProduct2.ProductName = "table";
//aProduct2.SupplierId = 34;
//aProduct2.CategoryId = 43;
//aProduct2.QuantityPerUnit = "one";
//aProduct2.UnitPrice = 15;
//aProduct2.UnitsInStock = 16;
//aProduct2.UnitsInOrder = 17;
//aProduct2.ReorderLevel = 1;
//aProduct2.Discontinued = true;// by default , boolean is true

// Console.WriteLine

Console.WriteLine("ProductId :" + aProduct2.ProductId);
Console.WriteLine("ProductName :" + aProduct2.ProductName);
Console.WriteLine("SupplierId:" + aProduct2.SupplierId);
Console.WriteLine("CategoryId:" + aProduct2.CategoryId);
Console.WriteLine("QuantityPerUnit:" + aProduct2.QuantityPerUnit);
Console.WriteLine("UnitPrice:" + aProduct2.UnitPrice);
Console.WriteLine("UnitsInStock:" + aProduct2.UnitsInStock);
Console.WriteLine("UnitsInOrder :" + aProduct2.UnitsInOrder);
Console.WriteLine("ReorderLevel :" + aProduct2.ReorderLevel);
Console.WriteLine("Discontinued :" + aProduct2.Discontinued);

// add list

List<Product> aListOfProducts = new List<Product>();

aListOfProducts.Add(aProduct1);
aListOfProducts.Add(aProduct2);

// loop


foreach (var p in aListOfProducts)
{
    Console.WriteLine(p.ToString());
    Console.WriteLine("\n\n\n");
}

// list shippers
// give value
Shipper aShipper1 = new Shipper(15, "apple", "0912345674");
Shipper aShipper2 = new Shipper(16, "google", "1234123456");

//aShipper1.ShipperId = 15;
//aShipper1.CompanyName = "apple";
//aShipper1.Phone = "0912345674";

// Console.WriteLine

Console.WriteLine("ShipperId :" + aShipper1.ShipperId);
Console.WriteLine("CompanyName :" + aShipper1.CompanyName);
Console.WriteLine("Phone:" + aShipper1.Phone);

//aShipper2.ShipperId = 16;
//aShipper2.CompanyName = "google";
//aShipper2.Phone = "1234123456";

// Console.WriteLine

Console.WriteLine("ShipperId :" + aShipper2.ShipperId);
Console.WriteLine("CompanyName :" + aShipper2.CompanyName);
Console.WriteLine("Phone:" + aShipper2.Phone);

// add list

List<Shipper> aListOfShippers = new List<Shipper>();

aListOfShippers.Add(aShipper1);
aListOfShippers.Add(aShipper2);

//loop
foreach (var sh in aListOfShippers)
{
    Console.WriteLine(sh.ToString());
    Console.WriteLine("\n\n\n");
}



// list suppliers
// give value


Supplier aSupplier1 = new Supplier(3, "atlas", "Abebe", "sir", "BoleBulbula", "A.A", "Bole", "56001", "Ethiopia", "0912435678", "1231245678", "levelup");
Supplier aSupplier2 = new Supplier(4, "atlas", "Abebe", "sir", "BoleBulbula", "A.A", "Bole", "56001", "Ethiopia", "0912435778", "1231245678", "upgrade");

//aSupplier1.SupplierId = 3;
//aSupplier1.CompanyName = "atlas";
//aSupplier1.ContactName = "Abebe";
//aSupplier1.ContactTitle = "sir";
//aSupplier1.Address = "BoleBulbula";
//aSupplier1.City = "A.A";
//aSupplier1.Region = "Bole";
//aSupplier1.PostalCode = "56001";
//aSupplier1.Country = "Ethiopia";
//aSupplier1.Phone = "0912435678";
//aSupplier1.Fax = "1231245678";
//aSupplier1.HomePage = "levelup";

// Console.WriteLine

Console.WriteLine("SupplierId :" + aSupplier1.SupplierId);
Console.WriteLine("CompanyName :" + aSupplier1.CompanyName);
Console.WriteLine("ContactName:" + aSupplier1.ContactName);
Console.WriteLine("ContactTitle:" + aSupplier1.ContactTitle);
Console.WriteLine("Address :" + aSupplier1.Address);
Console.WriteLine("City:" + aSupplier1.City);
Console.WriteLine("Region  = -1;:" + aSupplier1.Region);
Console.WriteLine("PostalCode :" + aSupplier1.PostalCode);
Console.WriteLine("Country  :" + aSupplier1.Country);
Console.WriteLine("Phone:" + aSupplier1.Phone);
Console.WriteLine("Fax:" + aSupplier1.Fax);
Console.WriteLine("HomePage :" + aSupplier1.HomePage);

//aSupplier2.SupplierId = 4;
//aSupplier2.CompanyName = "atlas";
//aSupplier2.ContactName = "Abebe";
//aSupplier2.ContactTitle = "sir";
//aSupplier2.Address = "BoleBulbula";
//aSupplier2.City = "A.A";
//aSupplier2.Region = "Bole";
//aSupplier2.PostalCode = "56001";
//aSupplier2.Country = "Ethiopia";
//aSupplier2.Phone = "0912435778";
//aSupplier2.Fax = "1231245678";
//aSupplier2.HomePage = "upgrade";

// Console.WriteLine

Console.WriteLine("SupplierId :" + aSupplier2.SupplierId);
Console.WriteLine("CompanyName :" + aSupplier2.CompanyName);
Console.WriteLine("ContactName:" + aSupplier2.ContactName);
Console.WriteLine("ContactTitle:" + aSupplier2.ContactTitle);
Console.WriteLine("Address :" + aSupplier2.Address);
Console.WriteLine("City:" + aSupplier2.City);
Console.WriteLine("Region  = -1;:" + aSupplier2.Region);
Console.WriteLine("PostalCode :" + aSupplier2.PostalCode);
Console.WriteLine("Country  :" + aSupplier2.Country);
Console.WriteLine("Phone:" + aSupplier2.Phone);
Console.WriteLine("Fax:" + aSupplier2.Fax);
Console.WriteLine("HomePage :" + aSupplier2.HomePage);

// add list

List<Supplier> aListOfSuppliers = new List<Supplier>();

aListOfSuppliers.Add(aSupplier1);
aListOfSuppliers.Add(aSupplier2);

//loop
foreach (var su in aListOfSuppliers)
{
    Console.WriteLine(su.ToString());
    Console.WriteLine("\n\n\n");
}





// ToString()
Console.WriteLine("\n\n\n");
Console.WriteLine(aCategory1.ToString());
Console.WriteLine("\n\n\n");
Console.WriteLine(aCategory2.ToString());


// ToString()
Console.WriteLine("\n\n\n");
Console.WriteLine(aCustomer1.ToString());
Console.WriteLine("\n\n\n");
Console.WriteLine(aCustomer2.ToString());


// ToString()
Console.WriteLine("\n\n\n");
Console.WriteLine(aEmployee1.ToString());
Console.WriteLine("\n\n\n");
Console.WriteLine(aEmployee2.ToString());

// ToString()
Console.WriteLine("\n\n\n");
Console.WriteLine(aOrder1.ToString());
Console.WriteLine("\n\n\n");
Console.WriteLine(aOrder2.ToString());


// ToString()
Console.WriteLine("\n\n\n");
Console.WriteLine(aOrderDetail1.ToString());
Console.WriteLine("\n\n\n");
Console.WriteLine(aOrderDetail2.ToString());


// ToString()
Console.WriteLine("\n\n\n");
Console.WriteLine(aProduct1.ToString());
Console.WriteLine("\n\n\n");
Console.WriteLine(aProduct2.ToString());


//ToString()
Console.WriteLine("\n\n\n");
Console.WriteLine(aShipper1.ToString());
Console.WriteLine("\n\n\n");
Console.WriteLine(aShipper2.ToString());



// ToString()
Console.WriteLine("\n\n\n");
Console.WriteLine(aSupplier1.ToString());
Console.WriteLine("\n\n\n");
Console.WriteLine(aSupplier2.ToString());

// ToString()
//Console.WriteLine("\n\n\n");
//Console.WriteLine(aProgram1.ToString());
//Console.WriteLine("\n\n\n");








