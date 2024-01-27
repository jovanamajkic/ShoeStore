CREATE DEFINER=`root`@`localhost` PROCEDURE `add_supply`(
	in Date datetime,
    in EmpId integer,
    in SId integer,
    in ArtId integer
)
BEGIN
	DECLARE totPrice DECIMAL(10,2) DEFAULT 0.00;
    DECLARE currPrice DECIMAL(5,2);
    DECLARE itemId INT;
    DECLARE newSupplyId INT;
    DECLARE i INT DEFAULT 1;
    
	INSERT INTO Supply (date, totalPrice, Employee_id, Supplier_id)
    VALUES (Date, 0.00, EmpId, SId);
    
    SET newSupplyId = LAST_INSERT_ID();
    
    CALL getArticlePrice(ArtId, currPrice, itemId);
    IF currPrice IS NULL OR itemId IS NULL THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'getArticlePrice nije uspešna.';
	ELSE
		WHILE i <= 5 DO
			INSERT INTO SupplyItem (quantity, price, ArticleItem_id, Supply_idSupply)
			VALUES (5, currPrice, itemId, newSupplyId);
			SET totPrice = totPrice + (currPrice * 5);
			SET itemId = itemId + 1;
			SET i = i + 1;
		END WHILE;
    
		UPDATE Supply SET totalPrice = totPrice WHERE idSupply = newSupplyId;
    END IF;
END