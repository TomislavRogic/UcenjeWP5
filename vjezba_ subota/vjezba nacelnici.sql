USE master;
GO

CREATE DATABASE bazaopcine;
GO

USE bazaopcine;
GO

CREATE TABLE Nacelnici (
    sifra INT PRIMARY KEY IDENTITY(1,1),
    Ime VARCHAR(50) NOT NULL,
    Prezime VARCHAR(50) NOT NULL,
    Datumrodenja DATE
);
GO

-- Prikaz svih podataka iz tablice Nacelnici
SELECT * FROM Nacelnici;

-- Umetanje podataka u tablicu Nacelnici
INSERT INTO Nacelnici (Ime, Prezime, Datumrodenja) VALUES
('Marko', 'Peric', '1954-05-06'),
('Luka', 'Simin', '1982-02-25'),
('Ivo', 'Lole', '1961-12-21');
GO


