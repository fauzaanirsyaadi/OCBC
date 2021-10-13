--A
CREATE DATABASE staff;
-- B
CREATE TABLE data_staff(
	nik int PRIMARY KEY,
	nama varchar(50),
	alamat varchar(200),
	handphone varchar(15)
);

--C & D
INSERT INTO data_staff(nik, nama, alamat, handphone) VALUES 
(1, 'fauzaan', 'Banyumas', '0123456789'),
(2, 'irsyaadi', 'Banyumas', '0123456789'),
(3, 'muhammad', 'Banyumas', '0123456789'),
(4, 'MFI', 'Purwokerto', '0123456789'),
(5, 'OZAN', 'Purwokerto', '0123456789');

--E
ALTER TABLE data_staff ADD joinDate date;

INSERT INTO data_staff(nik, nama, alamat, handphone, joinDate) VALUES (6, 'JKL', 'Yogyakarta', '786546873', GETDATE());

--F
SELECT TOP 2 * FROM data_staff;

--G
SELECT TOP 3 * FROM data_staff;

--H
CREATE TABLE staffOutSource(
	nik int PRIMARY KEY,
	nama varchar(50),
	alamat varchar(200),
	handphone varchar(15),
	joinDate date
);


--I
INSERT INTO staffOutSource VALUES 
(1, 'Dummy1', 'Kota1', '1234567890', '2021-10-1'),
(2, 'Dummy2', 'Kota2', '1234567890', '2021-10-2'),
(3, 'Dummy3', 'Kota3', '1234567890', '2021-10-3'),
(4, 'Dummy4', 'Kota4', '1234567890', '2021-10-4'),
(5, 'Dummy5', 'Kota5', '1234567890', '2021-10-5'),
(6, 'Dummy5', 'Kota6', '1234567890', '2021-10-6'),
(7, 'Dummy5', 'Kota7', '1234567890', '2021-10-7'),
(8, 'Dummy5', 'Kota8', '1234567890', '2021-10-8'),
(9, 'Dummy5', 'Kota9', '1234567890', '2021-10-9'),
(10, 'Dummy5', 'Kota10', '1234567890', '2021-10-10')

--J
SELECT s.*, d.* FROM data_staff d JOIN staffOutSource s ON s.joinDate = d.joinDate WHERE s.joinDate = d.joinDate;

--K
SELECT d.* FROM data_staff d RIGHT JOIN staffOutSource s ON s.joinDate = d.joinDate;

--L
SELECT s.* FROM data_staff d LEFT JOIN staffOutSource s ON s.joinDate = d.joinDate;

--M
SELECT s.*, d.* FROM data_staff d FULL JOIN staffOutSource s ON s.joinDate = d.joinDate;