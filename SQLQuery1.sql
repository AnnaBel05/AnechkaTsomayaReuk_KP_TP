drop table students;
CREATE TABLE students
(
    Id int identity,
    Last_name varchar(256) NOT NULL,
    First_name varchar(256) NOT NULL,
    Middle_name varchar(256) NOT NULL,
    Birth_date datetime NOT NULL,
    Phone_number varchar(256) NOT NULL,
    Credit_card_number varchar(256) NOT NULL,
    
    Educational_form int NOT NULL,
    Basis_of_training int NOT NULL
);