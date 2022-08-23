CREATE PROCEDURE GetOldNinjas
As
SELECT * From Ninjas WHERE DateOfBirth <='1/1/2000'