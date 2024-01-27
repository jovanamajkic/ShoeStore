CREATE DEFINER=`root`@`localhost` PROCEDURE `getArticlePrice`(
	IN a_id INT,
    OUT a_price DECIMAL(5, 2),
    OUT a_itemId INT
)
BEGIN
	DECLARE res_price DECIMAL(5, 2);
    DECLARE res_id INT;
    
    SELECT supplyPrice
    INTO res_price
    FROM Article
    WHERE idArticle = a_id;
    
    SELECT id
    INTO res_id
    FROM ArticleItem
    WHERE Article_idArticle = a_id
    LIMIT 1;
    
    IF FOUND_ROWS() > 0 THEN
        SET a_price = res_price;
        SET a_itemId = res_id;
    ELSE
        SET a_price = NULL;
        SET a_itemId = NULL;
    END IF;
END