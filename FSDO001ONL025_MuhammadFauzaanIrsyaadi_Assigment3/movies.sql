
CREATE TABLE `movies` (
  `id` int(11) NOT NULL,
  `Name` text DEFAULT NULL,
  `genre` text DEFAULT NULL,
  `duration` text DEFAULT NULL,
  `ReleaseDate` datetime NOT NULL,
  `price` int(11) NOT NULL,
  `act` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20211016092443_test table', '5.0.11');


--
-- Indexes for table `movies`
--
ALTER TABLE `movies`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

ALTER TABLE `movies`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

