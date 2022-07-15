// we use many to many relationship here
var query_1 = @"CREATE TABLE Teacher (
    ID int NOT NULL PRIMARY KEY,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Subject varchar(255),
    Gender varchar(50)
);";

var query_2 = @"CREATE TABLE Pupil (
    ID int NOT NULL PRIMARY KEY,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Gender varchar(50)
    Class varchar(10);
);";

var query_3 = @"Create Table PupilAndTeacher
                PupilId int,
                TeacherId int";

var query_4 = @"ALTER TABLE PupilAndTeacher
                ADD CONSTRAINT FK_Pupil FOREIGN KEY (PupilId) REFERENCES Pupil(ID) ";

var query_5 = @"ALTER TABLE PupilAndTeacher
                ADD CONSTRAINT FK_Pupil FOREIGN KEY (PupilId) REFERENCES Pupil(ID)";

var query_6 = @"SELECT t.* FROM Teacher t 
            JOIN PupilAndTeacher pt ON pt.TeacherId = t.ID 
            JOIN Pupil p ON pt.PupilId = p.ID 
            WHERE p.FirstName == 'Giorgi'";


