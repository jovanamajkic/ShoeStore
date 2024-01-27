CREATE DEFINER=`root`@`localhost` PROCEDURE `add_bill`(
	in Date datetime,
    in EmpId integer,
    in ArtId1 integer,
    in ArtId2 integer,
    in ArtId3 integer
)
BEGIN
	DECLARE totPrice DECIMAL(10,2) DEFAULT 0.00;
    DECLARE currPrice DECIMAL(5,2);
    DECLARE itemId INT;
    DECLARE newBillId INT;
    DECLARE i INT DEFAULT 1;
    
	INSERT INTO Bill (date, totalPrice, Employee_id)
    VALUES (Date, 0.00, EmpId);
    
    SET newBillId = LAST_INSERT_ID();
    
    CALL getArticlePrice(ArtId1, currPrice, itemId);
    INSERT INTO BillItem (quantity, price, Bill_id, ArticleItem_id)
	VALUES (2, currPrice, newBillId, itemId);
	SET totPrice = totPrice + (currPrice * 2);
    
    CALL getArticlePrice(ArtId2, currPrice, itemId);
    INSERT INTO BillItem (quantity, price, Bill_id, ArticleItem_id)
	VALUES (3, currPrice, newBillId, itemId);
	SET totPrice = totPrice + (currPrice * 3);
    
    CALL getArticlePrice(ArtId3, currPrice, itemId);
    INSERT INTO BillItem (quantity, price, Bill_id, ArticleItem_id)
	VALUES (1, currPrice, newBillId, itemId);
	SET totPrice = totPrice + currPrice;
    
    UPDATE Bill SET totalPrice = totPrice WHERE id = newBillId;
END