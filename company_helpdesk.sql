-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 12, 2025 at 07:18 PM
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
  `account_status` enum('active','deactivated') NOT NULL DEFAULT 'active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`userID`, `firstname`, `lastname`, `username`, `password`, `role`, `account_status`) VALUES
(1, 'John', 'Doe', 'admin', '123', 'admin', 'active'),
(2, 'Jade', 'Dy', 'user1', '123', 'user', 'active'),
(3, 'Frank', 'Ocean', 'admin2', '123', 'admin', 'active'),
(4, 'Aubrey', 'Plaza', 'admin3', '123', 'admin', 'active'),
(5, 'Felay', 'Minion', 'user2', '123', 'user', 'deactivated'),
(7, 'Da', 'Baus', 'test', '123', 'admin', 'active'),
(8, 'John', 'Pork', 'johnpork123', '123', 'user', 'active');

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
(4, 2, 'Laptop Overheating', 'Lenovo G40 overheats after an hour', 'Technical Issue', 'Low', 'Administration', 'closed', '2025-05-09 19:07:08', '2025-05-09 19:07:08', '2025-05-12 22:15:57', 'Dipped the Laptop in cold water', 1),
(8, 2, 'Computer Not Booting', 'No lights when turning on', 'Technical Issue', 'Low', 'Human Resources', 'Closed', '2025-05-12 09:11:11', '2025-05-12 09:11:11', '2025-05-12 21:53:56', 'this is already finished', 7),
(9, 2, 'Some keyboard keys not working', 'i think this needs replacement', 'Technical Issue', 'Low', 'Human Resources', 'open', '2025-05-12 09:11:46', '2025-05-12 09:11:46', NULL, NULL, 1),
(10, 2, 'Mouse is inverted', 'It\'s been like this for weeks ', 'Technical Issue', 'Low', 'Human Resources', 'closed', '2025-05-12 09:12:09', '2025-05-12 09:12:09', '2025-05-12 22:56:35', 'You\'re using it the other way around', 1),
(11, 2, 'Test Note', 'test for reassignment', 'Technical Issue', 'Low', 'Human Resources', 'Open', '2025-05-12 18:52:00', '2025-05-12 18:52:00', NULL, NULL, 1),
(12, 2, 'test desc edit', 'test desc edit*', 'Technical Issue', 'Low', 'Finance', 'Open', '2025-05-12 19:00:23', '2025-05-12 19:00:23', NULL, 'I\'m currently full on ', 7),
(13, 8, 'why can\'t i open 4chan?', 'i wanna wojack or something', 'Network Problem', 'Urgent', 'Customer Service', 'closed', '2025-05-13 01:43:22', '2025-05-13 01:43:22', '2025-05-13 01:44:01', 'yea they got hacked lil bro', 3);

-- --------------------------------------------------------

--
-- Table structure for table `ticket_reassignments`
--

CREATE TABLE `ticket_reassignments` (
  `id` int(11) NOT NULL,
  `ticket_id` int(11) NOT NULL,
  `old_admin_id` int(11) NOT NULL,
  `new_admin_id` int(11) NOT NULL,
  `reason` text DEFAULT NULL,
  `reassigned_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

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
-- Indexes for table `ticket_reassignments`
--
ALTER TABLE `ticket_reassignments`
  ADD PRIMARY KEY (`id`),
  ADD KEY `ticket_id` (`ticket_id`),
  ADD KEY `old_admin_id` (`old_admin_id`),
  ADD KEY `new_admin_id` (`new_admin_id`);

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
  MODIFY `ticket_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `ticket_reassignments`
--
ALTER TABLE `ticket_reassignments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

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
-- Constraints for table `ticket_reassignments`
--
ALTER TABLE `ticket_reassignments`
  ADD CONSTRAINT `ticket_reassignments_ibfk_1` FOREIGN KEY (`ticket_id`) REFERENCES `tickets` (`ticket_id`),
  ADD CONSTRAINT `ticket_reassignments_ibfk_2` FOREIGN KEY (`old_admin_id`) REFERENCES `accounts` (`userID`),
  ADD CONSTRAINT `ticket_reassignments_ibfk_3` FOREIGN KEY (`new_admin_id`) REFERENCES `accounts` (`userID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
