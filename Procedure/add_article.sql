CREATE DEFINER=`root`@`localhost` PROCEDURE `add_article`(
	in Code integer, 
    in Name varchar(255), 
    in Picture varchar(255), 
    in SupplyPrice decimal(5,2), 
    in SalePrice decimal(5,2), 
    in Gid integer, 
    in Cid integer, 
    in Active tinyint)
BEGIN
	DECLARE i INT DEFAULT 37;
    
	IF (SELECT COUNT(*) FROM Article WHERE idArticle = Code) > 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Artikal sa istom šifrom već postoji.';
    ELSE
        INSERT INTO Article (idArticle, name, picture, supplyPrice, sellPrice, Gender_id, ArticleType_id, active)
        VALUES (Code, Name, Picture, SupplyPrice, SalePrice, Gid, Cid, Active);
        
        WHILE i <= 45 DO
            INSERT INTO ArticleItem (size, quantity, Article_idArticle)
            VALUES (i, 5, Code);
            SET i = i + 1;
        END WHILE;
    END IF;
END