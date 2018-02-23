CREATE TABLE Invoice (ID int constraint Invoice_PK primary key IDENTITY, Date VARCHAR(MAX) NOT NULL, Client VARCHAR(MAX) NOT NULL, Money float NOT NULL)
drop table Invoice

INSERT INTO Invoice VALUES ('01.01.2018', 'John Smith', 15000.56)
INSERT INTO Invoice VALUES ('04.11.2017', 'John Smith', 16000.44)
INSERT INTO Invoice VALUES ('09.11.2017', 'El Diego', 10000.00)
INSERT INTO Invoice VALUES ('10.24.2017', 'Ivan Ivanov', 150000.56)
INSERT INTO Invoice VALUES ('02.08.2018', 'Petya Stepanov', 13456.78)
INSERT INTO Invoice VALUES ('02.08.2018', 'Alin Woth', 12355.56)
INSERT INTO Invoice VALUES ('02.22.2018', 'Katy West', 260.36)
INSERT INTO Invoice VALUES ('02.21.2018', 'Jimy Hellman', 1712.59)
INSERT INTO Invoice VALUES ('02.16.2018', 'Anton Romov', 15.99)
INSERT INTO Invoice VALUES ('06.23.2018', 'Harison Red', 123002.00)
INSERT INTO Invoice VALUES ('03.01.2017', 'Ann Bin', 306024.12)
select * from Invoice