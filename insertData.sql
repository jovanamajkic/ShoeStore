call add_article('101', 'Addidas papuce', 'papuce1.jpg', '29.00', '49.99', '1', '3', '1');
call add_article('102', 'Roze papuce', 'papuce2.jpg', '35.00', '55.99', '1', '3', '1');
call add_article('103', 'Nike japanke', 'papuce3.jpg', '10.20', '21.99', '2', '3', '1');
call add_article('104', 'Kroksice', 'papuce4.jpg', '27.00', '39.99', '2', '3', '1');
call add_article('105', 'Nike patike', 'patike1.jpg', '80.00', '110.00', '1', '1', '1');
call add_article('106', 'Balenciaga patike', 'patike2.jpg', '179.00', '245.99', '1', '1', '1');
call add_article('107', 'Vans patike', 'patike3.jpg', '84.00', '132.99', '2', '1', '1');
call add_article('108', 'Salonke', 'stikle1.jpg', '25.00', '39.99', '1', '5', '1');
call add_article('109', 'Crvene salonke', 'stikle2.jpg', '27.00', '42.99', '1', '5', '1');
call add_article('110', 'Stikle na vezanje', 'stikle3.jpg', '22.00', '40.00', '1', '5', '1');
call add_article('111', 'Martinke', 'cizme1.jpg', '170.00', '219.99', '1', '2', '1');
call add_article('112', 'Uggs cizme', 'cizme2.jpg', '71.99', '99.99', '1', '2', '1');
call add_article('113', 'Kanadjanke', 'cizme4.jpg', '150.00', '199.99', '2', '2', '1');
call add_article('114', 'Cizme na vezanje', 'cizme3.jpg', '89.00', '111.99', '2', '2', '1');
call add_article('115', 'Braon cipele', 'cipele1.jpg', '95.00', '150.00', '2', '7', '1');
call add_article('116', 'Crne cipele', 'cipele2.jpg', '81.00', '130.00', '2', '7', '1');
call add_article('117', 'Mokasine', 'cipele3.jpg', '54.00', '91.00', '1', '7', '1');
call add_article('118', 'Elegantne cipele', 'cipele4.jpg', '77.00', '134.00', '2', '7', '1');
call add_article('119', 'Crne sandale', 'sandale1.jpg', '13.00', '29.99', '2', '4', '1');
call add_article('120', 'Roze sandale', 'sandale2.jpg', '11.00', '25.99', '1', '4', '1');

call add_supply('2024-01-18 13:17:00', 1, 1, 104);
call add_supply('2024-01-19 13:17:00', 1, 2, 101);
call add_supply('2024-01-20 13:17:00', 2, 3, 102);
call add_supply('2024-01-21 13:17:00', 2, 4, 103);

call add_bill('2024-01-18 13:17:00', 3, 101, 102, 103);
call add_bill('2024-01-19 13:17:00', 3, 106, 104, 105);
call add_bill('2024-01-20 13:17:00', 4, 109, 107, 108);
call add_bill('2024-01-21 13:17:00', 4, 110, 111, 112);