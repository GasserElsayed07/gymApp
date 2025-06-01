-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 02, 2025 at 01:23 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `usersdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `trainers`
--

CREATE TABLE `trainers` (
  `trainerID` int(11) NOT NULL,
  `trianerName` varchar(31) NOT NULL,
  `trianerPassword` varchar(31) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `trainers`
--

INSERT INTO `trainers` (`trainerID`, `trianerName`, `trianerPassword`) VALUES
(1, 'admin', 'admin'),
(2, 'karim', '123'),
(3, 'shorse', 'shorse123');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userID` int(5) NOT NULL,
  `userFirstName` varchar(15) NOT NULL,
  `userLastName` varchar(15) NOT NULL,
  `userBirthDate` date NOT NULL,
  `userJoinDate` date NOT NULL,
  `userWeight` float NOT NULL,
  `userPhone` varchar(15) NOT NULL,
  `userAddress` varchar(255) NOT NULL,
  `userGender` varchar(10) NOT NULL,
  `userJoinReason` text NOT NULL,
  `userHeight` int(11) NOT NULL,
  `userPlan` varchar(100) NOT NULL,
  `userImage` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userID`, `userFirstName`, `userLastName`, `userBirthDate`, `userJoinDate`, `userWeight`, `userPhone`, `userAddress`, `userGender`, `userJoinReason`, `userHeight`, `userPlan`, `userImage`) VALUES
(1, 'm', 'v', '2004-06-16', '2025-05-31', 100, '0155555555', '123123', 'Female', 'Lose Weight', 120, '', 0x89504e470d0a1a0a0000000d4948445200000040000000400806000000aa6971de000000017352474200aece1ce90000000467414d410000b18f0bfc61050000043549444154785eed9abf4b1c411cc5ed8c81e4f4d480ff830421048434563145a290402c92224daac42e8d292c4d95ca544995ca2e858d2868612188a65230a0888597c24605b1d3c9bc61def9bdd9d9ddf3f62e7babf3e0c3eecd7c77fdbeb7733fd8b5a30ea9247eff789f88ae29bc22a6253ed3125d5378454c4b7ca625baa6f08a9896f84c4b744de115312df19996e89ac22b625ae2332dd1358557c4b4c4675aa26b0aaf886989cfb444d7b4bd22a624fd7d7d89f88eb926b9cbd754151a9557f5c6063037fdca20cd82ef9f9e1be4eb5b1540e56fc598e56bec634cd6001e2fcf5907b92b62a451dc0071ee3ac857d2401abadce09b6b14d3449ef23515c7d70f4f0dbeb946b16de4275f53ff13db46fb686ab44749f8694f6c59ac6627fa55120b0b0beaf0f0506d6c6ca8adad2d353f3faf969696d4f6f6b65a5d5d4d3dffe448b79220c4b9e997d5ad2d6b5cad0ee0e4e444552a15b5bbbbab4e4f4fd5caca8a3a3f3f37e39b9b9beaf2f232f16f4c3dd37d090a17c0cece8e31bebfbfafd6d7d7cd6a383b3b33811c1d1da5063033deab08ce57b800969797d5c1c1813a3e3e567b7b7beae2e2422d2e2eaab5b535f396b0a789957bbecc01c0e4c791929a785c3286912cc708e6b0c5f8bbe17bd5fd99b1ab2bc12d6affe8f733e82f970d7c8d39d6f1989ed27df579b4acbe8cf7a9d9d70f0cd8c718dfe758eaee7118c31cc7088f21d666bc9202a0f1a400d810b730c410ee74761a681eb846500f9a15008e232d0940eefb560003000c80af51c33a1e8326dd00304e03f7bb4be603125bf2adbb4bfd2c77a95fbd776bc65927e7adcd78650d409ac716300419c0db372faaf3be008019172b004863d802699063b9054043728bc6e54a406d5200ac67083c070370895b01be796b335ed2ac31a5ffb81c4b0bc035cfe6514753a8e5b959eb0680abce7ab902d2aeb01c676d5bac00d4e1aacb1030c73a5f0058feacc7183f03485a00a46d56c0a4ae0334c5f9d800302e42c01cb8ceb780fc0cc1bcb519afac01b031b9651d56802f04368bfd9a0074f318c7be0ca1a501a0d12cb8bf1425438f860cbe3942a371f88e91f88e91589bf17a3838a892181818a8e1c9f0700dbea6483302c04fdc2c589bf1f23525710370e77daba299f84cc9dffe6973d66650505050505050505050505050505050eb84fb8112f7068a2d8b15eee3490a7783236b00b8d929b97501f0ae2fb9950148da3e009894cf0e08c6cdfd7bbde59c191bbb7aee8047edae61bcefb1f4712cc7cc79f498fbf9006c1bf9c90da0c66c8b02c0430f62dbc84f5902c0b8fb5c0fcff3f05c0fcff7e438ebdc79db467e6a5600d802699063373a009890c4ad80b879db467eca1a40da1596f3c05d21b68dfc94350098ab270072e35680fc0600f57e0bf071ba6d233fddfa0060220beee370f797a38b5b6fdbc84feee373dfff1848dcff2fc0cfdb2cd836f2931b80efaa25e11a727ffbfb9035b68d06d5d1f10fcfcf063e0088495c0000000049454e44ae426082);

-- --------------------------------------------------------

--
-- Table structure for table `userplan`
--

CREATE TABLE `userplan` (
  `ID` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `tier` varchar(255) NOT NULL,
  `duration` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `userplan`
--

INSERT INTO `userplan` (`ID`, `name`, `tier`, `duration`) VALUES
(1, '@_name', '@_tier', '@_duration'),
(2, '@_name', '@_tier', '@_duration'),
(3, 'test', 'est', 'test');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `trainers`
--
ALTER TABLE `trainers`
  ADD PRIMARY KEY (`trainerID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userID`);

--
-- Indexes for table `userplan`
--
ALTER TABLE `userplan`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `trainers`
--
ALTER TABLE `trainers`
  MODIFY `trainerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `userplan`
--
ALTER TABLE `userplan`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
