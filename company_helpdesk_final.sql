-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 09, 2025 at 02:23 PM
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
  `userID` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
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
('ITHD001', 'John', 'Doe', '123', '123', 'admin', 'deactivated', 'unavailable'),
('ITHD002', 'Ben', 'Piñon', 'test', 'test', 'admin', 'active', 'available'),
('ITHD003', 'Ted', 'Kaczynski', 'user', '123', 'user', 'active', 'available'),
('ITHD004', 'Elliot', 'Alderson', 'admin1', '123', 'admin', 'active', 'unavailable');

-- --------------------------------------------------------

--
-- Table structure for table `tickets`
--

CREATE TABLE `tickets` (
  `ticket_id` int(11) NOT NULL,
  `user_id` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `title` varchar(255) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `category` varchar(100) DEFAULT NULL,
  `priority` varchar(50) DEFAULT NULL,
  `department` varchar(100) DEFAULT NULL,
  `status` varchar(50) DEFAULT 'Open',
  `on_hold_reason` varchar(255) DEFAULT NULL,
  `on_hold_until` datetime DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL,
  `completed_at` datetime DEFAULT NULL,
  `note` text DEFAULT NULL,
  `user_extra_remarks` text DEFAULT NULL,
  `resolve_remarks` text DEFAULT NULL,
  `assigned_to` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `tickets`
--

INSERT INTO `tickets` (`ticket_id`, `user_id`, `title`, `description`, `category`, `priority`, `department`, `status`, `on_hold_reason`, `on_hold_until`, `created_at`, `updated_at`, `completed_at`, `note`, `user_extra_remarks`, `resolve_remarks`, `assigned_to`) VALUES
(36, 'ITHD003', 'test remarks post', 'test', 'Technical Issue', 'Low', 'Human Resources', 'Closed', NULL, NULL, '2025-06-08 23:54:36', '2025-06-08 23:54:36', '2025-06-09 11:30:50', NULL, NULL, 'test', 'ITHD002'),
(37, 'ITHD003', 'Slow Internet', 'my browser wont open or loads slow some websites like facebook, reddit, twitter, github, etc.', 'Network Problem', 'Low', 'Human Resources', 'Closed', NULL, NULL, '2025-06-09 11:34:00', '2025-06-09 11:34:00', '2025-06-09 20:52:23', NULL, 'The speed is stable now i could now access the websites,  thanks a lot, will update if something goes wrong again!', 'done', 'ITHD002'),
(38, 'ITHD003', 'Computer wont boot', 'My computer wont boot, this was happening on separate events', 'Hardware Issue', 'High', 'Finance', 'Resolved', NULL, NULL, '2025-06-09 11:35:13', '2025-06-09 11:35:13', NULL, NULL, NULL, 'done', 'ITHD004'),
(39, 'ITHD003', 'Laptop no display', 'laptop turns on but no display', 'Hardware Issue', 'Urgent', 'Customer Service', 'Open', NULL, NULL, '2025-06-09 11:35:59', '2025-06-09 11:35:59', NULL, 'reassign test', NULL, NULL, 'ITHD004'),
(40, 'ITHD003', 'Need Photoshop', 'I need photoshop on my pc for editing', 'Software Request', 'Normal', 'Administration', 'Resolved', NULL, NULL, '2025-06-09 11:36:42', '2025-06-09 11:36:42', NULL, NULL, NULL, 'n/a', 'ITHD004'),
(41, 'ITHD003', 'test on hold', 'test', 'Technical Issue', 'Low', 'Human Resources', 'On Hold', 'Requesting material purchase', '2025-06-13 17:27:06', '2025-06-09 13:08:32', '2025-06-09 13:08:32', NULL, NULL, NULL, NULL, 'ITHD004'),
(42, 'ITHD003', 'Full Process Test', 'Full Process Test', 'Technical Issue', 'High', 'Human Resources', 'Closed', 'full process test', '2025-06-09 21:05:44', '2025-06-09 21:04:56', '2025-06-09 21:04:56', '2025-06-09 21:13:02', NULL, 'completed test', 'Full process test resolve', 'ITHD004'),
(43, 'ITHD003', 'what if unavailable', 'what if unavailable', 'Technical Issue', 'Low', 'Human Resources', 'Open', NULL, NULL, '2025-06-09 21:15:39', '2025-06-09 21:15:39', NULL, NULL, NULL, NULL, 'ITHD002'),
(44, 'ITHD003', 'what if unavailable', 'what if unavailable', 'Technical Issue', 'Low', 'Human Resources', 'Open', NULL, NULL, '2025-06-09 21:15:48', '2025-06-09 21:15:48', NULL, NULL, NULL, NULL, 'ITHD002'),
(45, 'ITHD003', 'what if unavailable', 'what if unavailable', 'Software Request', 'Low', 'Finance', 'Open', NULL, NULL, '2025-06-09 21:15:54', '2025-06-09 21:15:54', NULL, NULL, NULL, NULL, 'ITHD002');

-- --------------------------------------------------------

--
-- Table structure for table `ticket_progress_remarks`
--

CREATE TABLE `ticket_progress_remarks` (
  `remark_id` int(11) NOT NULL,
  `ticket_id` int(11) NOT NULL,
  `user_id` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
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
(1, 36, 'ITHD002', 'test', 'test', 'test', 'test', NULL, NULL, '2025-06-08 23:55:40', '2025-06-08 23:55:42', '2025-06-08 23:55:45', '2025-06-08 23:55:47', NULL, NULL),
(2, 38, 'ITHD004', 'Picked up computer unit', NULL, NULL, NULL, NULL, NULL, '2025-06-09 11:58:02', NULL, NULL, NULL, NULL, NULL),
(3, 40, 'ITHD004', 'will install 3:30 today', NULL, NULL, NULL, NULL, NULL, '2025-06-09 12:07:15', NULL, NULL, NULL, NULL, NULL),
(4, 37, 'ITHD002', 'Working on it', 'Contacted ISP service', 'Replaced Router', 'gonna be done soon idk', NULL, NULL, '2025-06-09 17:48:44', '2025-06-09 17:49:16', '2025-06-09 20:12:51', '2025-06-09 20:51:36', NULL, NULL),
(5, 42, 'ITHD004', 'test', 'full process test', NULL, NULL, NULL, NULL, '2025-06-09 21:11:13', '2025-06-09 21:11:19', NULL, NULL, NULL, NULL);

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
  ADD KEY `fk_tickets_user_id` (`user_id`),
  ADD KEY `fk_tickets_assigned_to` (`assigned_to`);

--
-- Indexes for table `ticket_progress_remarks`
--
ALTER TABLE `ticket_progress_remarks`
  ADD PRIMARY KEY (`remark_id`),
  ADD KEY `fk_ticket_id` (`ticket_id`),
  ADD KEY `fk_remarks_user_id` (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tickets`
--
ALTER TABLE `tickets`
  MODIFY `ticket_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT for table `ticket_progress_remarks`
--
ALTER TABLE `ticket_progress_remarks`
  MODIFY `remark_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tickets`
--
ALTER TABLE `tickets`
  ADD CONSTRAINT `fk_tickets_assigned_to` FOREIGN KEY (`assigned_to`) REFERENCES `accounts` (`userID`),
  ADD CONSTRAINT `fk_tickets_user_id` FOREIGN KEY (`user_id`) REFERENCES `accounts` (`userID`);

--
-- Constraints for table `ticket_progress_remarks`
--
ALTER TABLE `ticket_progress_remarks`
  ADD CONSTRAINT `fk_remarks_user_id` FOREIGN KEY (`user_id`) REFERENCES `accounts` (`userID`),
  ADD CONSTRAINT `fk_ticket_id` FOREIGN KEY (`ticket_id`) REFERENCES `tickets` (`ticket_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
