--Northwind

--case insensitive
------------------------------------------------------------------------------

-- SELECT           -  Veri tabanından verileri çeker
-- UPDATE           -  Veri tabanındaki verileri düzenler
-- DELETE           -  Veri tabanından verileri siler
-- INSERT INTO      -  Yeni verileri veri tabanına ekler
-- CREATE DATABASE  -  Yeni bir veri tabanı oluşturur
-- ALTER DATABASE   -  Veri tabanını değiştirir
-- CREATE TABLE     -  Yeni bir tablo oluşturur
-- ALTER TABLE      -  Tabloyu değiştirir
-- DROP TABLE       -  Tabloyu siler
-- CREATE INDEX     -  Bir dizin oluşturur
-- DROP INDEX       -  Bir dizin siler

------------------------------------------------------------------------------

select * from Customers

select CompanyName, ContactName,City from Customers
select CompanyName Adi, ContactName SirketAdi,City Sehir from Customers

select * from Customers where City = 'London'
select * from Products where CategoryID = 1

select * from Products where CategoryID = 1 or CategoryID = 3
select * from Products where CategoryID = 1 and UnitPrice >= 10

--sıralama
select * from Products order by ProductName
select * from Products order by CategoryID, ProductName --önce CategoryID leri sıralayıp o ıd içinde ProductName i alfabetik sıraya göre sıralar

select * from Products order by UnitPrice  --default u asc fiyat artan sıralama
select * from Products order by UnitPrice desc  --fiyat azalan sıralama

select * from Products where CategoryID = 1 order by UnitPrice desc

select count(*) from Products --Ürün adedi
select count(*) from Products where CategoryID = 2
select count(*) Adet from Products where CategoryID = 2

select CategoryID from Products group by CategoryID  --Bütün categoryleri tekrar etmeyecek şekilde sıralar ->group by
select CategoryID, count(*) SayiAdedi from Products group by CategoryID  --Bütün categoryleri tekrar etmeyecek şekilde sıralar ->group by
select UnitPrice, count(*) Adedi from Products group by UnitPrice

select CategoryID, count(*) SayiAdedi from Products group by CategoryID having count(*) < 10  --İçerisinde 10 taneden az ürün çeşidi olan categoryleri ver


select CategoryID, count(*) SayiAdedi from Products where UnitPrice>20 group by CategoryID having count(*) < 10  --Önce her zaman where çalışır

--UnitPrice yazınca ürün sayısı azaldı böylece 10 dan küçük olanların sayısı artmış oldu
--inner join iki tabloda da eşleşen dataları getirir
select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID --on -> durumunda, şartında, koşul demek

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on
Products.CategoryID = Categories.CategoryID where Products.UnitPrice > 10

--left solda olup sağda olmayanları da getir
select * from Products p left join [Order Details] od on p.ProductID = od.ProductID -- [Order Details] arada boşluk olduğundan dolayı köşeli parantez içine alıyor

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null --solda olup sağda olmayanları getir sadece

--iki tabloyu joinlemek
select * from Products p left join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID


--Her bir üründen toplamda ne kadar para kazandığımızı bulunuz.
select ProductName,Sum(od.Quantity*od.UnitPrice) as TotalAmount from [Order Details] od inner join Products p on
od.ProductID = p.ProductID inner join Orders o on od.OrderID = o.OrderID group by ProductName
