CREATE TABLE Products (
    ProductID int,
    ProductName varchar(50),
    ProductDescription varchar(50),
    ProductExpiryDate datetime,
	Price money
);

insert into Products values(1,'LedTV','55INCH,FHD',CONVERT(VARCHAR,'11/27/2020',103),200);
insert into Products values(2,'Bread','For Breakfast',CONVERT(VARCHAR,'11/27/2020',103),200);
insert into Products values(3,'Eggs','For Breakfast',CONVERT(VARCHAR,'11/27/2020',103),200);
insert into Products values(4,'Water','For Drinking',CONVERT(VARCHAR,'12/27/2020',103),200);