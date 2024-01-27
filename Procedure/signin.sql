CREATE DEFINER=`root`@`localhost` PROCEDURE `signin`(in uname VARCHAR(45), in pass VARCHAR(45), out signin boolean, out IdEmployee INTEGER, out N VARCHAR(45), out LastN VARCHAR(45), out Em VARCHAR(255), out PhoneN VARCHAR(45), out R VARCHAR(45), out A boolean, out L integer, out T INTEGER)
BEGIN
	SELECT count(*)>0, id, name, lastname, email, phoneNumber, role, active, language, theme
    INTO signin, IdEmployee, N, LastN, Em, PhoneN, R, A, L, T FROM Employee
	WHERE username=uname AND password=pass
    GROUP BY id, name, lastname, email, phoneNumber, role, active;
END