CREATE DATABASE stock_management

CREATE TABLE connexion (
    username VARCHAR (30),
    password VARCHAR (30)
);

CREATE TABLE connexion_admin (
    username VARCHAR (30),
    password VARCHAR (30)
);

INSERT INTO connexion VALUES('admin','admin')
INSERT INTO connexion_admin VALUES('respo','respo')

CREATE TABLE products (
    id_product		INT IDENTITY (1, 1),
    name			VARCHAR (100),
    quantity_total	INT,
    price			INT,
    description		VARCHAR (MAX)
);

