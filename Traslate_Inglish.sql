--Consulta de demostración de TOP con lista ORDER BY única

SELECT TOP (5) orderid, orderdate, custid, empid FROM Sales.Orders
ORDER BY orderdate DESC, orderid DESC;