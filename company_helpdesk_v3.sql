-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 28, 2025 at 07:26 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `company_helpdesk`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `userID` int(5) NOT NULL,
  `firstname` varchar(30) NOT NULL,
  `lastname` varchar(30) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `role` varchar(10) NOT NULL,
  `account_status` enum('active','deactivated') NOT NULL DEFAULT 'active',
  `eeStatus` enum('available','unavailable') DEFAULT 'available'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`userID`, `firstname`, `lastname`, `username`, `password`, `role`, `account_status`, `eeStatus`) VALUES
(1, 'John', 'Doe', 'admin', '123', 'admin', 'active', 'unavailable'),
(2, 'Jade', 'Dy', 'user1', '123', 'user', 'active', 'available'),
(3, 'Frank', 'Ocean', 'admin2', '123', 'admin', 'active', 'unavailable'),
(4, 'Aubrey', 'Plaza', 'admin3', '123', 'admin', 'active', 'unavailable'),
(5, 'Felay', 'Minion', 'user2', '123', 'user', 'deactivated', 'available'),
(7, 'Da', 'Baus', 'test', '123', 'admin', 'active', 'available'),
(8, 'John', 'Pork', 'johnpork123', '123', 'user', 'active', 'available');

-- --------------------------------------------------------

--
-- Table structure for table `tickets`
--

CREATE TABLE `tickets` (
  `ticket_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `title` varchar(255) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `category` varchar(100) DEFAULT NULL,
  `priority` varchar(50) DEFAULT NULL,
  `department` varchar(100) DEFAULT NULL,
  `status` varchar(50) DEFAULT 'Open',
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL,
  `completed_at` datetime DEFAULT NULL,
  `note` text DEFAULT NULL,
  `assigned_to` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `tickets`
--

INSERT INTO `tickets` (`ticket_id`, `user_id`, `title`, `description`, `category`, `priority`, `department`, `status`, `created_at`, `updated_at`, `completed_at`, `note`, `assigned_to`) VALUES
(23, 2, 'on hover test', 'on hover test', 'Technical Issue', 'Low', 'Human Resources', 'In Progress', '2025-05-29 01:55:58', '2025-05-29 01:55:58', NULL, NULL, 7),
(24, 2, 'on hover test 2', 'on hover test 2', 'Technical Issue', 'Low', 'Human Resources', 'Assigned', '2025-05-29 02:03:02', '2025-05-29 02:03:02', NULL, NULL, 7),
(25, 2, 'remarkTest4', 'a', 'Technical Issue', 'Low', 'Human Resources', 'In Progress', '2025-05-29 02:18:17', '2025-05-29 02:18:17', NULL, NULL, 7);

-- --------------------------------------------------------

--
-- Table structure for table `ticket_progress_remarks`
--

CREATE TABLE `ticket_progress_remarks` (
  `remark_id` int(11) NOT NULL,
  `ticket_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `remark1` text DEFAULT NULL,
  `remark2` text DEFAULT NULL,
  `remark3` text DEFAULT NULL,
  `remark4` text DEFAULT NULL,
  `remark5` text DEFAULT NULL,
  `remark6` text DEFAULT NULL,
  `remark1_created_at` datetime DEFAULT NULL,
  `remark2_created_at` datetime DEFAULT NULL,
  `remark3_created_at` datetime DEFAULT NULL,
  `remark4_created_at` datetime DEFAULT NULL,
  `remark5_created_at` datetime DEFAULT NULL,
  `remark6_created_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ticket_progress_remarks`
--

INSERT INTO `ticket_progress_remarks` (`remark_id`, `ticket_id`, `user_id`, `remark1`, `remark2`, `remark3`, `remark4`, `remark5`, `remark6`, `remark1_created_at`, `remark2_created_at`, `remark3_created_at`, `remark4_created_at`, `remark5_created_at`, `remark6_created_at`) VALUES
(4, 25, 7, 'test', 'test', NULL, NULL, NULL, NULL, '2025-05-29 02:23:08', '2025-05-29 02:23:13', NULL, NULL, NULL, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`userID`);

--
-- Indexes for table `tickets`
--
ALTER TABLE `tickets`
  ADD PRIMARY KEY (`ticket_id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `assigned_to` (`assigned_to`);

--
-- Indexes for table `ticket_progress_remarks`
--
ALTER TABLE `ticket_progress_remarks`
  ADD PRIMARY KEY (`remark_id`),
  ADD KEY `fk_ticket_id` (`ticket_id`),
  ADD KEY `fk_user_id` (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `userID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tickets`
--
ALTER TABLE `tickets`
  MODIFY `ticket_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `ticket_progress_remarks`
--
ALTER TABLE `ticket_progress_remarks`
  MODIFY `remark_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tickets`
--
ALTER TABLE `tickets`
  ADD CONSTRAINT `tickets_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `accounts` (`userID`),
  ADD CONSTRAINT `tickets_ibfk_2` FOREIGN KEY (`assigned_to`) REFERENCES `accounts` (`userID`);

--
-- Constraints for table `ticket_progress_remarks`
--
ALTER TABLE `ticket_progress_remarks`
  ADD CONSTRAINT `fk_ticket_id` FOREIGN KEY (`ticket_id`) REFERENCES `tickets` (`ticket_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_user_id` FOREIGN KEY (`user_id`) REFERENCES `accounts` (`userID`) ON DELETE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
