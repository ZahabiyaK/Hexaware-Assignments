--Create Database
Create Database FMSDB;

--Create Schema

Create Table Users(
	user_id INT PRIMARY KEY IDENTITY,
	username varchar(50) NOT NULL,
	password varchar(10) NOT NULL,
	email varchar(max)
);

Create Table ExpenseCategories(
	category_id INT PRIMARY KEY IDENTITY,
	category_name varchar(100)
);

Create Table Expenses(
	expense_id INT PRIMARY KEY IDENTITY,
	amount decimal(10,2),
	date DATE,
	description varchar(max),
	user_id INT,
	category_id INT,
	Foreign Key(user_id) References Users(user_id),
	Foreign Key(category_id) References ExpenseCategories(category_id)
);
