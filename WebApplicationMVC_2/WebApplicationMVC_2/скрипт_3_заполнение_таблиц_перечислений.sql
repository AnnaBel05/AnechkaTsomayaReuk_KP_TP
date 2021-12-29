USE [demobd]
GO

insert into [dbo].[EducationalForms](id,name) values(1,'Бюджет') ;  
insert into [dbo].[EducationalForms](id,name) values(2,'Контракт');
insert into [dbo].[EducationalForms](id,name) values(3,'Целевое направление');

insert into [dbo].[TrainingTypes](id,name) values(1,'Очная форма');
insert into [dbo].[TrainingTypes](id,name) values(2,'Заочная форма');
insert into [dbo].[TrainingTypes](id,name) values(3,'Очно-заочная форма');

insert into [dbo].[WorkStatuses](id,name) values(1,'В процессе');
insert into [dbo].[WorkStatuses](id,name) values(2,'Завершена');

insert into [dbo].[Reasons](id,name) values(1,'Уважительная причина');
insert into [dbo].[Reasons](id,name) values(2,'Нет уважительной причины');

insert into [dbo].[ScholarshipTypes](id,name) values(1,'Обычная стипендия');
insert into [dbo].[ScholarshipTypes](id,name) values(2,'Социальная стипендия');
insert into [dbo].[ScholarshipTypes](id,name) values(3,'Президентская стипендия');
insert into [dbo].[ScholarshipTypes](id,name) values(4,'Нет');

insert into [dbo].[MarkTypes](id,name) values(1,'Рейтинг');
insert into [dbo].[MarkTypes](id,name) values(2,'Лабораторная работа');
insert into [dbo].[MarkTypes](id,name) values(3,'СРС');
insert into [dbo].[MarkTypes](id,name) values(4,'Экзамен');



insert into [dbo].[ActivityTypes](id,name) values(1,'Статья');
insert into [dbo].[ActivityTypes](id,name) values(2,'Олимпиада');
insert into [dbo].[ActivityTypes](id,name) values(3,'Волонтёрство'); 

insert into [dbo].[Values](id,name) values(5,'Отлично');
insert into [dbo].[Values](id,name) values(4,'Хорошо');
insert into [dbo].[Values](id,name) values(3,'Удовлетворительно'); 
insert into [dbo].[Values](id,name) values(2,'Неудовлетворительно'); 

insert into [dbo].[Roles](id,name,fullname) values(1,'admin','Администратор');
insert into [dbo].[Roles](id,name,fullname) values(2,'employee','Преподаватель');
insert into [dbo].[Roles](id,name,fullname) values(3,'student','Студент'); 