
CREATE TABLE `movies` (
  `id` int(11) NOT NULL,
  `Name` text DEFAULT NULL,
  `genre` text DEFAULT NULL,
  `duration` text DEFAULT NULL,
  `ReleaseDate` datetime NOT NULL,
  `price` int(11) NOT NULL,
  `act` tinyint(1) NOT NULL
)

ALTER TABLE `movies`
  ADD PRIMARY KEY (`id`);

-- isi tabel database 
INSERT INTO `movies` (`id`, `Name`, `genre`, `duration`, `ReleaseDate`, `price`, `act`) VALUES
(1, 'Bad Boys for Life', 'Action/Comedy', '2h 5mins', '2020-01-23 00:00:00', 1000, 1),
(2, 'John Wick', 'Action/Thriller', '1h 41m', '2014-10-24 00:00:00', 2000, 1),
(3, 'The Martian', 'Sci-fi/Drama', '2h 31m', '2015-10-02 00:00:00', 3000, 1),
(4, 'How to Train Your Dragon : The Hidden World', 'Animation/Family', '2h 8m', '2019-02-22 00:00:00', 4000, 1);






