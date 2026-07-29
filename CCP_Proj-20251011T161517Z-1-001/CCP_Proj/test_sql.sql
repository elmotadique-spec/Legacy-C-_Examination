-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 12, 2022 at 05:24 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `test_sql`
--

-- --------------------------------------------------------

--
-- Table structure for table `actionhistory`
--

CREATE TABLE `actionhistory` (
  `TransID` int(11) NOT NULL,
  `Action` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Date` varchar(50) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `actionhistory`
--

INSERT INTO `actionhistory` (`TransID`, `Action`, `Date`) VALUES
(2, 'Added Teacher', '11/21/2022 11:43:40 AM'),
(3, 'Edited Teacher Maria', '11/21/2022 2:47:37 PM'),
(4, 'Edited Teacher John Johnny', '11/23/2022 2:26:57 PM'),
(5, 'Added Teacher Ethan Bert', '11/23/2022 2:57:29 PM'),
(6, 'Edited Teacher John Johner', '11/23/2022 3:27:20 PM');

-- --------------------------------------------------------

--
-- Table structure for table `actionhistoryexam`
--

CREATE TABLE `actionhistoryexam` (
  `TransID` int(11) NOT NULL,
  `Action` varchar(100) NOT NULL,
  `Subject` varchar(100) NOT NULL,
  `Date` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `actionhistoryexam`
--

INSERT INTO `actionhistoryexam` (`TransID`, `Action`, `Subject`, `Date`) VALUES
(1, 'Edited question 1', 'History', '11/22/2022 2:23:17 PM'),
(2, 'Edited question 3', 'Science', '11/22/2022 3:03:55 PM'),
(3, 'Edited question 2', 'History', '11/23/2022 9:40:06 AM'),
(4, 'Edited question 2', 'History', '11/23/2022 9:40:27 AM'),
(5, 'Edited question 2', 'History', '11/23/2022 9:45:03 AM'),
(6, 'Edited question 2', 'History', '11/23/2022 9:45:11 AM'),
(7, 'Edited question 7', 'History', '11/23/2022 10:00:42 AM'),
(8, 'Edited question 4', 'History', '11/23/2022 2:17:59 PM'),
(9, 'Edited question 7', 'History', '11/30/2022 2:14:14 PM'),
(10, 'Edited question 15', 'History', '12/12/2022 9:12:35 AM'),
(11, 'Edited question 1', 'History', '12/12/2022 11:50:26 AM'),
(12, 'Added Question ', 'History', '12/12/2022 12:11:06 PM'),
(13, 'Edited question 18', 'History', '12/12/2022 12:11:33 PM');

-- --------------------------------------------------------

--
-- Table structure for table `actionhistorystudent`
--

CREATE TABLE `actionhistorystudent` (
  `TransID` int(11) NOT NULL,
  `Action` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Date` varchar(50) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `actionhistorystudent`
--

INSERT INTO `actionhistorystudent` (`TransID`, `Action`, `Date`) VALUES
(1, 'Edited Zetsuo Yagoo', '11/29/2022 3:53:38 PM'),
(2, 'Added Walter White', '11/30/2022 5:21:58 PM'),
(3, 'Added Jessie Pinkman', '12/11/2022 8:02:19 PM'),
(4, 'Added Hank Schrader', '12/11/2022 8:14:17 PM'),
(5, 'Added Madiha Franklin', '12/11/2022 8:15:25 PM'),
(6, 'Added Brogan Ramsey', '12/11/2022 8:16:12 PM'),
(7, 'Added Moshe Khan', '12/11/2022 8:17:12 PM'),
(8, 'Added Grover Vang', '12/11/2022 8:19:48 PM'),
(9, 'Added Anthony Savage', '12/11/2022 8:20:50 PM'),
(10, 'Added Hana Benton', '12/11/2022 8:21:41 PM'),
(11, 'Added Mike Osmoll ', '12/11/2022 8:22:42 PM'),
(12, 'Added Samir Smith', '12/11/2022 8:23:53 PM'),
(13, 'Added Jean Challace', '12/11/2022 8:27:27 PM'),
(14, 'Added Sebastiano McFeate', '12/11/2022 8:28:02 PM'),
(15, 'Added Skylar Schall', '12/11/2022 8:28:50 PM'),
(16, 'Added Jonathon Faas', '12/11/2022 8:29:20 PM'),
(17, 'Added Tabatha Martel', '12/11/2022 8:30:07 PM'),
(18, 'Added Ruggiero Dumingos', '12/11/2022 8:30:42 PM'),
(19, 'Added Lolita Pogosian', '12/11/2022 8:31:18 PM'),
(20, 'Added Emmery Georgi', '12/11/2022 8:32:14 PM'),
(21, 'Added Chandra Spelsbury', '12/11/2022 8:32:47 PM'),
(22, 'Added Pierson Deneve', '12/11/2022 8:33:38 PM'),
(23, 'Added Malinda Trever', '12/11/2022 8:34:11 PM'),
(24, 'Added Walther Wadeson', '12/11/2022 8:34:42 PM'),
(25, 'Added Brendis Abramski', '12/11/2022 8:35:28 PM'),
(26, 'Added Rufus Bulled', '12/11/2022 8:36:06 PM'),
(27, 'Added Mic Creber', '12/11/2022 8:36:43 PM'),
(28, 'Added Hugh Mong', '12/11/2022 8:37:39 PM'),
(29, 'Added Sumting Wong', '12/11/2022 8:38:29 PM'),
(30, 'Added Dani Godfroy', '12/11/2022 8:41:16 PM'),
(31, 'Added Wilona Ventom', '12/11/2022 8:41:46 PM'),
(32, 'Added Cybill Spatari', '12/11/2022 8:42:21 PM'),
(33, 'Added Kev Kilsby', '12/11/2022 8:42:50 PM'),
(34, 'Added Ludwig Konig', '12/11/2022 8:43:18 PM'),
(35, 'Added Takashi Agata', '12/11/2022 8:44:23 PM'),
(36, 'Added Clevey Lugton', '12/11/2022 8:44:46 PM'),
(37, 'Added Lia Yi', '12/11/2022 8:46:10 PM'),
(38, 'Added Dyane Yeowell', '12/11/2022 8:46:45 PM'),
(39, 'Added Denis Paris', '12/11/2022 8:47:38 PM'),
(40, 'Added Vlad Siddmeir ', '12/11/2022 8:48:24 PM'),
(41, 'Added Mat Philipps ', '12/11/2022 8:49:07 PM'),
(42, 'Added Ivan Tonkista', '12/11/2022 8:51:09 PM'),
(43, 'Added Coop Sedwick', '12/11/2022 8:51:49 PM'),
(44, 'Added Jon Smithy', '12/11/2022 8:53:03 PM'),
(45, 'Added Ethan West22222', '12/12/2022 10:37:55 AM'),
(46, 'Edited Ethan West22222', '12/12/2022 10:38:07 AM'),
(47, 'Edited Ethan West', '12/12/2022 10:38:16 AM'),
(48, 'Added Weasel Brown', '12/12/2022 10:50:42 AM'),
(49, 'Edited Weasel Brown', '12/12/2022 10:54:34 AM'),
(50, 'Added Kim Un', '12/12/2022 10:55:35 AM'),
(51, 'Edited Kim Un', '12/12/2022 10:55:57 AM'),
(52, 'Added Ethan Crew', '12/12/2022 12:09:46 PM'),
(53, 'Added Res', '12/12/2022 12:17:31 PM');

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `TransID` int(11) NOT NULL,
  `Name` varchar(1000) COLLATE utf8mb4_bin NOT NULL,
  `Email` varchar(1000) COLLATE utf8mb4_bin NOT NULL,
  `Pass` varchar(1000) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`TransID`, `Name`, `Email`, `Pass`) VALUES
(1, 'Bro', 'c', 'c');

-- --------------------------------------------------------

--
-- Table structure for table `englishexam`
--

CREATE TABLE `englishexam` (
  `TransID` int(11) NOT NULL,
  `Question` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `A` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `B` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `C` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `D` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `CorrectAns` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `englishexam`
--

INSERT INTO `englishexam` (`TransID`, `Question`, `A`, `B`, `C`, `D`, `CorrectAns`) VALUES
(1, 'Action word is also known as?', 'Verb', 'Noun', 'Pronoun', 'Conjunction', 'Verb'),
(2, 'Synonym of loud', 'Sober', 'Strident', 'Still', 'Tranquil', 'Strident'),
(3, 'Modifies a noun or pronoun', 'Adjective', 'Constants', 'Conjunction', 'Noun', 'Adjective'),
(4, 'Past Simple tense of read', 'Rode', 'Readed', 'Red', 'Read', 'Read'),
(5, 'Past tense of Drive\r\n', 'Drove', 'Drived', 'Drift', 'Driven', 'Drove'),
(6, ' ____________ Language tends to be more conservative and old fashioned', 'Written', 'Spoken', 'Email', 'Electronic', 'Written'),
(7, 'Semantics is the study of ___________ ?', 'Language', 'Figures of speech', 'Words', 'History', 'Language'),
(8, 'Figure of speech that uses less harsh words', 'Euphemism', 'Simile', 'Irony', 'Hyperbole', 'Euphemism'),
(9, 'Two unlikely things are explicitly compared', 'Euphemism', 'Simile', 'Irony', 'Hyperbole', 'Simile'),
(10, 'Statement by over-statement', 'Euphemism', 'Simile', 'Hyperbole', 'Irony', 'Hyperbole'),
(11, 'Real meanings used are different from the intended meanings', 'Euphemism', 'Simile', 'Hyperbole', 'Irony', 'Irony'),
(12, '_____________ is meant for repeating the same idea in different words', 'Tautology', 'Onomatopoeia', 'Antithesis', 'Anticlimax', 'Tautology'),
(13, 'The formation of a word resembling a sound', 'Tautology', 'Onomatopoeia', 'Antithesis', 'Anticlimax', 'Onomatopoeia'),
(14, 'A striking opposition is made in the same sentence', 'Tautology', 'Onomatopoeia', 'Antithesis', 'Anticlimax', 'Antithesis'),
(15, 'Signifies a descent', 'Tautology', 'Onomatopoeia', 'Antithesis', 'Anticlimax', 'Anticlimax');

-- --------------------------------------------------------

--
-- Table structure for table `englishexamtakers`
--

CREATE TABLE `englishexamtakers` (
  `TransID` int(11) NOT NULL,
  `Name` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Date` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `englishgrade`
--

CREATE TABLE `englishgrade` (
  `TransID` int(11) NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Email` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Assign1` int(100) NOT NULL,
  `Assign2` int(100) NOT NULL,
  `Q1` int(100) NOT NULL,
  `Q2` int(100) NOT NULL,
  `Proj` int(100) NOT NULL,
  `ExamRS` int(100) NOT NULL,
  `ExamItem` int(100) NOT NULL,
  `ExamFS` int(100) NOT NULL,
  `FinalGrade` int(100) NOT NULL,
  `FinalGradeEquiv` varchar(100) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `englishgrade`
--

INSERT INTO `englishgrade` (`TransID`, `Name`, `Email`, `Assign1`, `Assign2`, `Q1`, `Q2`, `Proj`, `ExamRS`, `ExamItem`, `ExamFS`, `FinalGrade`, `FinalGradeEquiv`) VALUES
(1, 'Zetsuo Yagoo', 'a234', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(2, 'Walter White', 'clean@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(3, 'Jessie Pinkman', 'b3333333333333tch@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(4, 'Hank Schrader', 'Minerals@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(5, 'Madiha Franklin', 'Maddz34bleh@yahoo.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(6, 'Brogan Ramsey', 'DemoDogs@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(7, 'Moshe Khan', 'BatuKhan@yahoo.net', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(8, 'Grover Vang', 'Piece90@yahoo.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(9, 'Anthony Savage', 'Ytterical78@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(10, 'Hana Benton', 'Wesker101@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(11, 'Mike Osmoll ', 'verybig404@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(12, 'Samir Smith', 'Vydja90@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(13, 'Jean Challace', 'jchallace0@cocolog-nifty.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(14, 'Sebastiano McFeate', 'smcfeate1@disqus.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(15, 'Skylar Schall', 'sschall3@macromedia.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(16, 'Jonathon Faas', 'jfaas8@army.mil', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(17, 'Tabatha Martel', 'tmartelv@pagesperso-orange.fr', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(18, 'Ruggiero Dumingos', 'rdumingos11@trellian.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(19, 'Lolita Pogosian', 'lpogosian18@ask.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(20, 'Emmery Georgi', 'egeorgit@slate.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(21, 'Chandra Spelsbury', 'cspelsburyf@harvard.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(22, 'Pierson Deneve', 'pdeneved@icq.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(23, 'Malinda Trever', 'mtrever9@cdbaby.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(24, 'Walther Wadeson', 'wwadeson2@google.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(25, 'Brendis Abramski', 'babramski4@nsw.gov.au', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(26, 'Rufus Bulled', 'rbulled10@163.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(27, 'Mic Creber', 'mcreber14@is.gd', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(28, 'Hugh Mong', 'Hmong@yahoo.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(29, 'Sumting Wong', 'S23wong@pen.io', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(30, 'Dani Godfroy', 'dgodfroyy@uol.com.br', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(31, 'Wilona Ventom', 'wventomx@yahoo.co.jp', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(32, 'Cybill Spatari', 'cspatario@fema.gov', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(33, 'Kev Kilsby', 'kkilsby7@hud.gov', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(34, 'Ludwig Konig', 'LKonig@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(35, 'Takashi Agata', 'TkAgata@msu.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(36, 'Clevey Lugton', 'clugtonb@51.la', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(37, 'Lia Yi', 'Yi123@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(38, 'Dyane Yeowell', 'dyeowellh@sogou.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(39, 'Denis Paris', 'dparisq@npr.org', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(40, 'Vlad Siddmeir ', 'VSidd23@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(41, 'Mat Philipps ', 'Mphilipps@psu.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(42, 'Ivan Tonkista', 'ITonkista@howstuffworks.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(43, 'Coop Sedwick', 'csedwickk@cnbc.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(44, 'Jon Smithy', 'JSmith@ph.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(45, 'Ethan West22222', 'Ew@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(46, 'Weasel Brown', 'Wbr@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(47, 'Kim Un', 'KUn@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(48, 'Ethan Crew', 'Ec@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(49, 'Res', 'Res', 50, 50, 50, 50, 50, 0, 0, 50, 50, '');

-- --------------------------------------------------------

--
-- Table structure for table `examinfo`
--

CREATE TABLE `examinfo` (
  `TransID` int(11) NOT NULL,
  `Subject` varchar(50) COLLATE utf8mb4_bin NOT NULL,
  `ExamItems` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `examinfo`
--

INSERT INTO `examinfo` (`TransID`, `Subject`, `ExamItems`) VALUES
(1, 'history', 10),
(2, 'math', 10),
(3, 'science', 10),
(4, 'english', 10);

-- --------------------------------------------------------

--
-- Table structure for table `historyexam`
--

CREATE TABLE `historyexam` (
  `TransID` int(11) NOT NULL,
  `Question` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `A` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `B` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `C` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `D` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `CorrectAns` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `historyexam`
--

INSERT INTO `historyexam` (`TransID`, `Question`, `A`, `B`, `C`, `D`, `CorrectAns`) VALUES
(1, 'Operation Overlord saw the landings at which beach? ', 'Kherson', 'Stalingrad', 'Florence', 'Normandy', 'Normandy'),
(2, 'The first Nuclear bomb was dropped at which city in Japan?', 'Hiroshima', 'Nagasaki', 'Tokyo', 'Honshu', 'Hiroshima'),
(3, 'Which battle is also known as the bloodiest war, with 633,00 casualties?', 'Battle of the Somme', 'Battle of Stalingrad', 'D-day landings', 'Battle of Waterloo', 'Battle of Stalingrad'),
(4, 'First republic in History is attributed to which country?', 'United States of America', 'United Kingdom', 'Canada', 'China', 'United States of America'),
(5, 'Also known as the largest Naval battle, which resulted into decisive victory for the Americans against the Japanese', 'Battle of Iwo Jima', 'Battle of Leyte Gulf', 'Battle of Midway', 'Battle of Okinawa', 'Battle of Leyte Gulf'),
(6, 'He said the famous line \"I shall return\"', 'George S. Patton', 'Douglas MacArthur', 'Omar Nelson Bradley', 'Dwight D. Eisenhower', 'Douglas MacArthur'),
(7, 'What research and development project produced the first nuclear weapons during World War II?', 'Stargate Project', 'Project Azorian', 'MKUltra project', 'Manhattan Project', 'Manhattan Project'),
(8, 'First two west european countries that Germany occupied during ww2?', 'Norway and Denmark', 'Finland and Denmark', 'France and Denmark', 'France and Belgium', 'Norway and Denmark'),
(9, 'Also known as Germany\'s plan in attacking the USSR', 'Operation Overlord', 'Operation Sealion', 'Operation Blitz', 'Operation Barbarossa', 'Operation Barbarossa'),
(10, 'Who broke the Enigma code? ', 'Alan Turing', 'Douglas MacArthur', 'Benito Mussolini ', 'Bernard Montgomery', 'Alan Turing'),
(11, 'The Ardennes Offensive which is also known as the Battle of the ______________, saw as the last german offensive operation in the west', 'Carrantan', 'Bulge', 'Rhein', 'Salient', 'Bulge'),
(12, 'The United States bought Alaska from which country?', 'France', 'England', 'Canada', 'Russia', 'Russia'),
(13, 'Which era marked a switch from agricultural practices to industrial practices?', 'The Industrial Revolution', 'The Industrial Renaissance ', 'The Industrial Wars', 'The Industrial Revelation', 'The Industrial Revolution'),
(14, 'What is the world’s oldest recorded civilization?', 'Mesopotamia', 'Byzantine', 'Xin', 'Saskatchewan', 'Mesopotamia'),
(15, 'What is considered the largest empire in history?', 'Roman Empire', 'Mongol Empire', 'Holy Roman Empire', 'Byzantine Empire', 'Mongol Empire'),
(16, 'How many years did the 100 years war last?', '100', '116', '79', '108', '116'),
(17, 'How many U.S. presidents have been assassinated?', 'None', '2', '3', '4', '4'),
(18, 'lorem ipsum lorem ipsum testing', 'A', 'B', 'C', 'D', 'D');

-- --------------------------------------------------------

--
-- Table structure for table `historyexamtakers`
--

CREATE TABLE `historyexamtakers` (
  `TransID` int(11) NOT NULL,
  `Name` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Date` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `historyexamtakers`
--

INSERT INTO `historyexamtakers` (`TransID`, `Name`, `Date`) VALUES
(7, 'Walter White', '12/12/2022 9:17:13 AM'),
(8, 'Jonathon Faas', '12/12/2022 9:26:06 AM'),
(9, 'Hana Benton', '12/12/2022 9:31:54 AM'),
(10, 'Zetsuo Yagoo', '12/12/2022 9:38:28 AM'),
(11, 'Emmery Georgi', '12/12/2022 9:58:02 AM'),
(12, 'Skylar Schall', '12/12/2022 10:06:47 AM'),
(13, 'Grover Vang', '12/12/2022 12:04:35 PM');

-- --------------------------------------------------------

--
-- Table structure for table `historygrade`
--

CREATE TABLE `historygrade` (
  `TransID` int(11) NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Email` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Assign1` int(100) NOT NULL,
  `Assign2` int(100) NOT NULL,
  `Q1` int(100) NOT NULL,
  `Q2` int(100) NOT NULL,
  `Proj` int(100) NOT NULL,
  `ExamRS` int(100) NOT NULL,
  `ExamItem` int(100) NOT NULL,
  `ExamFS` int(100) NOT NULL,
  `FinalGrade` int(100) NOT NULL,
  `FinalGradeEquiv` varchar(100) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `historygrade`
--

INSERT INTO `historygrade` (`TransID`, `Name`, `Email`, `Assign1`, `Assign2`, `Q1`, `Q2`, `Proj`, `ExamRS`, `ExamItem`, `ExamFS`, `FinalGrade`, `FinalGradeEquiv`) VALUES
(6, 'Zetsuo Yagoo', 'a234', 50, 50, 50, 50, 50, 10, 10, 100, 50, ''),
(7, 'Walter White', 'clean@gmail.com', 87, 99, 72, 90, 85, 10, 10, 100, 91, '1.25'),
(8, 'Jessie Pinkman', 'b3333333333333tch@gmail.com', 100, 100, 90, 99, 99, 0, 0, 50, 79, '1.75'),
(9, 'Hank Schrader', 'Minerals@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(10, 'Madiha Franklin', 'Maddz34bleh@yahoo.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(11, 'Brogan Ramsey', 'DemoDogs@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(12, 'Moshe Khan', 'BatuKhan@yahoo.net', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(13, 'Grover Vang', 'Piece90@yahoo.com', 90, 77, 100, 89, 90, 8, 10, 90, 90, '1.25'),
(14, 'Anthony Savage', 'Ytterical78@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(15, 'Hana Benton', 'Wesker101@gmail.com', 67, 80, 78, 90, 85, 7, 10, 85, 78, '1.75'),
(16, 'Mike Osmoll ', 'verybig404@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(17, 'Samir Smith', 'Vydja90@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(18, 'Jean Challace', 'jchallace0@cocolog-nifty.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(19, 'Sebastiano McFeate', 'smcfeate1@disqus.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(20, 'Skylar Schall', 'sschall3@macromedia.com', 50, 50, 50, 50, 50, 10, 10, 100, 70, '2.25'),
(21, 'Jonathon Faas', 'jfaas8@army.mil', 90, 78, 100, 91, 79, 9, 10, 90, 87, '1.50'),
(22, 'Tabatha Martel', 'tmartelv@pagesperso-orange.fr', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(23, 'Ruggiero Dumingos', 'rdumingos11@trellian.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(24, 'Lolita Pogosian', 'lpogosian18@ask.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(25, 'Emmery Georgi', 'egeorgit@slate.com', 90, 89, 100, 86, 85, 9, 10, 95, 91, '1.25'),
(26, 'Chandra Spelsbury', 'cspelsburyf@harvard.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(27, 'Pierson Deneve', 'pdeneved@icq.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(28, 'Malinda Trever', 'mtrever9@cdbaby.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(29, 'Walther Wadeson', 'wwadeson2@google.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(30, 'Brendis Abramski', 'babramski4@nsw.gov.au', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(31, 'Rufus Bulled', 'rbulled10@163.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(32, 'Mic Creber', 'mcreber14@is.gd', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(33, 'Hugh Mong', 'Hmong@yahoo.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(34, 'Sumting Wong', 'S23wong@pen.io', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(35, 'Dani Godfroy', 'dgodfroyy@uol.com.br', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(36, 'Wilona Ventom', 'wventomx@yahoo.co.jp', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(37, 'Cybill Spatari', 'cspatario@fema.gov', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(38, 'Kev Kilsby', 'kkilsby7@hud.gov', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(39, 'Ludwig Konig', 'LKonig@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(40, 'Takashi Agata', 'TkAgata@msu.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(41, 'Clevey Lugton', 'clugtonb@51.la', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(42, 'Lia Yi', 'Yi123@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(43, 'Dyane Yeowell', 'dyeowellh@sogou.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(44, 'Denis Paris', 'dparisq@npr.org', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(45, 'Vlad Siddmeir ', 'VSidd23@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(46, 'Mat Philipps ', 'Mphilipps@psu.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(47, 'Ivan Tonkista', 'ITonkista@howstuffworks.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(48, 'Coop Sedwick', 'csedwickk@cnbc.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(49, 'Jon Smithy', 'JSmith@ph.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(50, 'Ethan West22222', 'Ew@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(51, 'Weasel Brown', 'Wbr@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(52, 'Kim Un', 'KUn@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(53, 'Ethan Crew', 'Ec@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(54, 'Res', 'Res', 50, 50, 50, 50, 50, 0, 0, 50, 50, '');

-- --------------------------------------------------------

--
-- Table structure for table `mathexam`
--

CREATE TABLE `mathexam` (
  `TransID` int(11) NOT NULL,
  `Question` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `A` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `B` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `C` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `D` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `CorrectAns` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mathexam`
--

INSERT INTO `mathexam` (`TransID`, `Question`, `A`, `B`, `C`, `D`, `CorrectAns`) VALUES
(1, '1+1 = ?', '2', '3', '11', '0', '2'),
(2, '33 + 77 = ?', '100', '101', '110', '3377', '110'),
(3, '23 - 32 =?', '-11', '-9', '-13', '-7', '-9'),
(4, '2 x 91', '188', '189', '199', '182', '182'),
(5, '0 x 5 = ?', '0', '5', '1', 'Undefined', '0'),
(6, '21 + 9 = ?', '23', '219', '30', '27', '30'),
(7, '17  + 7', '24', '21', '34', '28', '24'),
(8, 'A positive number multiplied by a negative number results into what number?', 'Positive number', 'Negative number', 'Positive and Negative number', 'Undefined number', 'Negative number'),
(9, '2 cube is equals to ?', '2 ', '4', '6', '8', '8'),
(10, 'in Pythagorean Theorem, C stands for? \r\n', 'Hypotenuse ', 'Legs', 'Constant', 'Perimeter', 'Hypotenuse'),
(11, 'One six sided dice was thrown . What is the probability that a 6 is thrown? \r\n', '1/6', '1/3', '2/3', '1', '1/6'),
(12, 'Which of the following equations represent a straight line?', 'y = ax²', 'y = mx + b', 'y = a² + b² ', 'y = a² - 2ab - b²', 'y = mx + b'),
(13, 'The corresponding formula \" A = l², wherein l = the length of the shapes size \" solves for the area of which shape?', 'Triangle', 'Sphere', 'Trapezoid', 'Square', 'Square'),
(14, '96 / 8 = ?', '16', '13', '8', '12', '12'),
(15, '50% of 10 is what?', '5', '2', '10', '50', '5');

-- --------------------------------------------------------

--
-- Table structure for table `mathexamtakers`
--

CREATE TABLE `mathexamtakers` (
  `TransID` int(11) NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Date` varchar(100) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Table structure for table `mathgrade`
--

CREATE TABLE `mathgrade` (
  `TransID` int(11) NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Email` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Assign1` int(100) NOT NULL,
  `Assign2` int(100) NOT NULL,
  `Q1` int(100) NOT NULL,
  `Q2` int(100) NOT NULL,
  `Proj` int(100) NOT NULL,
  `ExamRS` int(100) NOT NULL,
  `ExamItem` int(100) NOT NULL,
  `ExamFS` int(100) NOT NULL,
  `FinalGrade` int(100) NOT NULL,
  `FinalGradeEquiv` varchar(100) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `mathgrade`
--

INSERT INTO `mathgrade` (`TransID`, `Name`, `Email`, `Assign1`, `Assign2`, `Q1`, `Q2`, `Proj`, `ExamRS`, `ExamItem`, `ExamFS`, `FinalGrade`, `FinalGradeEquiv`) VALUES
(2, 'Zetsuo Yagoo', 'a234', 50, 50, 50, 50, 50, 4, 10, 0, 50, ''),
(3, 'Walter White', 'clean@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(4, 'Jessie Pinkman', 'b3333333333333tch@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(5, 'Hank Schrader', 'Minerals@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(6, 'Madiha Franklin', 'Maddz34bleh@yahoo.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(7, 'Brogan Ramsey', 'DemoDogs@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(8, 'Moshe Khan', 'BatuKhan@yahoo.net', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(9, 'Grover Vang', 'Piece90@yahoo.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(10, 'Anthony Savage', 'Ytterical78@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(11, 'Hana Benton', 'Wesker101@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(12, 'Mike Osmoll ', 'verybig404@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(13, 'Samir Smith', 'Vydja90@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(14, 'Jean Challace', 'jchallace0@cocolog-nifty.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(15, 'Sebastiano McFeate', 'smcfeate1@disqus.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(16, 'Skylar Schall', 'sschall3@macromedia.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(17, 'Jonathon Faas', 'jfaas8@army.mil', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(18, 'Tabatha Martel', 'tmartelv@pagesperso-orange.fr', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(19, 'Ruggiero Dumingos', 'rdumingos11@trellian.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(20, 'Lolita Pogosian', 'lpogosian18@ask.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(21, 'Emmery Georgi', 'egeorgit@slate.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(22, 'Chandra Spelsbury', 'cspelsburyf@harvard.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(23, 'Pierson Deneve', 'pdeneved@icq.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(24, 'Malinda Trever', 'mtrever9@cdbaby.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(25, 'Walther Wadeson', 'wwadeson2@google.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(26, 'Brendis Abramski', 'babramski4@nsw.gov.au', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(27, 'Rufus Bulled', 'rbulled10@163.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(28, 'Mic Creber', 'mcreber14@is.gd', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(29, 'Hugh Mong', 'Hmong@yahoo.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(30, 'Sumting Wong', 'S23wong@pen.io', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(31, 'Dani Godfroy', 'dgodfroyy@uol.com.br', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(32, 'Wilona Ventom', 'wventomx@yahoo.co.jp', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(33, 'Cybill Spatari', 'cspatario@fema.gov', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(34, 'Kev Kilsby', 'kkilsby7@hud.gov', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(35, 'Ludwig Konig', 'LKonig@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(36, 'Takashi Agata', 'TkAgata@msu.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(37, 'Clevey Lugton', 'clugtonb@51.la', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(38, 'Lia Yi', 'Yi123@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(39, 'Dyane Yeowell', 'dyeowellh@sogou.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(40, 'Denis Paris', 'dparisq@npr.org', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(41, 'Vlad Siddmeir ', 'VSidd23@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(42, 'Mat Philipps ', 'Mphilipps@psu.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(43, 'Ivan Tonkista', 'ITonkista@howstuffworks.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(44, 'Coop Sedwick', 'csedwickk@cnbc.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(45, 'Jon Smithy', 'JSmith@ph.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(46, 'Ethan West22222', 'Ew@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(47, 'Weasel Brown', 'Wbr@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(48, 'Kim Un', 'KUn@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(49, 'Ethan Crew', 'Ec@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(50, 'Res', 'Res', 50, 50, 50, 50, 50, 0, 0, 50, 50, '');

-- --------------------------------------------------------

--
-- Table structure for table `scienceexam`
--

CREATE TABLE `scienceexam` (
  `TransID` int(11) NOT NULL,
  `Question` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `A` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `B` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `C` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `D` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `CorrectAns` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `scienceexam`
--

INSERT INTO `scienceexam` (`TransID`, `Question`, `A`, `B`, `C`, `D`, `CorrectAns`) VALUES
(1, 'Element with the Element Symbol of W in the periodic table', 'Tin', 'Mercury', 'Tungsten', 'Silver', 'Tungsten'),
(2, 'Element with the Atomic number 6 in the periodic table', 'Oxygen', 'Carbon', 'Magnesium', 'Boron', 'Carbon'),
(3, 'Which one of these elements is not a Halogen', 'Bromine', 'Iodine', 'Lithium', 'Chlorine', 'Lithium'),
(4, 'Which one of these elements is a Noble Gas?', 'Argon', 'Boron', 'Carbon', 'Sulfur', 'Argon'),
(5, 'It is the thermodynamic state function that is a measure of randomness', 'Entropy', 'Enthalpy', 'Resonance Hybridization', 'Isothermal Compressability', 'Entropy'),
(6, 'Name the element discovered upon its extraction from pitchblende', 'Platinum', 'Plutonium', 'Uranium', 'Radium', 'Uranium'),
(7, 'Which is the most abundant element in the universe?\r\n', 'Hydrogen', 'Iron', 'Helium', 'Carbon', 'Hydrogen'),
(8, 'Sounds travel fastest in ____________?\r\n', 'Vacuum', 'Gases', 'Solids', 'Liquids', 'Solids'),
(9, 'A material that will not carry an electrical charge called?', 'Super Conductor', 'Insulator', 'Circuit', 'Conductor', 'Insulator'),
(10, 'The force acting between two point charges can be computed using which of the following laws?', 'First Law of Thermodynamics', 'Coulomb\'s Law', 'Zeroth Law of Thermodynamics', 'Murphy\'s Law', 'Coulomb\'s Law'),
(11, 'Shockley, Brattain and Bardeen won a Nobel prize for what small invention?\r\n', 'Microscope', 'Node', 'Microchip', 'Transistor', 'Transistor'),
(12, 'What is the name of the temperature and pressure conditions at which water can be in the solid, liquid and gas phases simultaneously?', 'Triple Point', 'Super Critical Fluid', 'Critical Point', 'Condensation', 'Triple Point'),
(13, 'The first law of thermodynamics is concerned with the conservation of  _______?\r\n', 'Energy', 'Mass', 'Space', 'Speed', 'Energy'),
(14, 'The wave nature of light is demonstrated by which of the following?\r\n', 'Metamorphosis ', 'Fusion', 'Diffraction', 'Diffusion', 'Diffraction'),
(15, 'Largest desert is ?', 'Antarctic Desert\r\n', 'Arctic Desert', 'Gobi Desert', 'Sahara Desert', 'Antarctic Desert\r\n');

-- --------------------------------------------------------

--
-- Table structure for table `scienceexamtakers`
--

CREATE TABLE `scienceexamtakers` (
  `TransID` int(11) NOT NULL,
  `Name` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Date` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sciencegrade`
--

CREATE TABLE `sciencegrade` (
  `TransID` int(11) NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Email` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Assign1` int(100) NOT NULL,
  `Assign2` int(100) NOT NULL,
  `Q1` int(100) NOT NULL,
  `Q2` int(100) NOT NULL,
  `Proj` int(100) NOT NULL,
  `ExamRS` int(100) NOT NULL,
  `ExamItem` int(100) NOT NULL,
  `ExamFS` int(100) NOT NULL,
  `FinalGrade` int(100) NOT NULL,
  `FinalGradeEquiv` varchar(100) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `sciencegrade`
--

INSERT INTO `sciencegrade` (`TransID`, `Name`, `Email`, `Assign1`, `Assign2`, `Q1`, `Q2`, `Proj`, `ExamRS`, `ExamItem`, `ExamFS`, `FinalGrade`, `FinalGradeEquiv`) VALUES
(1, 'Zetsuo Yagoo', 'a234', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(2, 'Walter White', 'clean@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(3, 'Jessie Pinkman', 'b3333333333333tch@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(4, 'Hank Schrader', 'Minerals@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(5, 'Madiha Franklin', 'Maddz34bleh@yahoo.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(6, 'Brogan Ramsey', 'DemoDogs@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(7, 'Moshe Khan', 'BatuKhan@yahoo.net', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(8, 'Grover Vang', 'Piece90@yahoo.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(9, 'Anthony Savage', 'Ytterical78@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(10, 'Hana Benton', 'Wesker101@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(11, 'Mike Osmoll ', 'verybig404@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(12, 'Samir Smith', 'Vydja90@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(13, 'Jean Challace', 'jchallace0@cocolog-nifty.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(14, 'Sebastiano McFeate', 'smcfeate1@disqus.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(15, 'Skylar Schall', 'sschall3@macromedia.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(16, 'Jonathon Faas', 'jfaas8@army.mil', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(17, 'Tabatha Martel', 'tmartelv@pagesperso-orange.fr', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(18, 'Ruggiero Dumingos', 'rdumingos11@trellian.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(19, 'Lolita Pogosian', 'lpogosian18@ask.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(20, 'Emmery Georgi', 'egeorgit@slate.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(21, 'Chandra Spelsbury', 'cspelsburyf@harvard.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(22, 'Pierson Deneve', 'pdeneved@icq.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(23, 'Malinda Trever', 'mtrever9@cdbaby.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(24, 'Walther Wadeson', 'wwadeson2@google.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(25, 'Brendis Abramski', 'babramski4@nsw.gov.au', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(26, 'Rufus Bulled', 'rbulled10@163.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(27, 'Mic Creber', 'mcreber14@is.gd', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(28, 'Hugh Mong', 'Hmong@yahoo.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(29, 'Sumting Wong', 'S23wong@pen.io', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(30, 'Dani Godfroy', 'dgodfroyy@uol.com.br', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(31, 'Wilona Ventom', 'wventomx@yahoo.co.jp', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(32, 'Cybill Spatari', 'cspatario@fema.gov', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(33, 'Kev Kilsby', 'kkilsby7@hud.gov', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(34, 'Ludwig Konig', 'LKonig@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(35, 'Takashi Agata', 'TkAgata@msu.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(36, 'Clevey Lugton', 'clugtonb@51.la', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(37, 'Lia Yi', 'Yi123@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(38, 'Dyane Yeowell', 'dyeowellh@sogou.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(39, 'Denis Paris', 'dparisq@npr.org', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(40, 'Vlad Siddmeir ', 'VSidd23@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(41, 'Mat Philipps ', 'Mphilipps@psu.edu', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(42, 'Ivan Tonkista', 'ITonkista@howstuffworks.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(43, 'Coop Sedwick', 'csedwickk@cnbc.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(44, 'Jon Smithy', 'JSmith@ph.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(45, 'Ethan West22222', 'Ew@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(46, 'Weasel Brown', 'Wbr@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(47, 'Kim Un', 'KUn@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(48, 'Ethan Crew', 'Ec@gmail.com', 50, 50, 50, 50, 50, 0, 0, 50, 50, ''),
(49, 'Res', 'Res', 50, 50, 50, 50, 50, 0, 0, 50, 50, '');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `TransID` int(11) NOT NULL,
  `Name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Pass` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Section` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`TransID`, `Name`, `Email`, `Pass`, `Section`) VALUES
(7, 'Zetsuo Yagoo', 'a2345', 'a2345', 'BSIT'),
(8, 'Walter White', 'clean@gmail.com', 'thedanger101', 'BSIT'),
(9, 'Jessie Pinkman', 'b3333333333333tch@gmail.com', 'xdddddddsNuts', 'BSIT'),
(10, 'Hank Schrader', 'Minerals@gmail.com', 'testmyDomicile', 'BSIT'),
(11, 'Madiha Franklin', 'Maddz34bleh@yahoo.com', 'quertyBoss2', 'BSIT'),
(12, 'Brogan Ramsey', 'DemoDogs@gmail.com', 'solomonking', 'BSIT'),
(13, 'Moshe Khan', 'BatuKhan@yahoo.net', '23top34bot56', 'BSIT'),
(14, 'Grover Vang', 'Piece90@yahoo.com', '1234567890', 'BSIT'),
(15, 'Anthony Savage', 'Ytterical78@gmail.com', 'gbzSgfw3234q6', 'BSIT'),
(16, 'Hana Benton', 'Wesker101@gmail.com', 'asdfgh101', 'BSIT'),
(17, 'Mike Osmoll ', 'verybig404@gmail.com', 'verybig404', 'BSIT'),
(18, 'Samir Smith', 'Vydja90@gmail.com', 'bbbb3322', 'BSIT'),
(19, 'Jean Challace', 'jchallace0@cocolog-nifty.com', 'Challence21', 'BSIT'),
(20, 'Sebastiano McFeate', 'smcfeate1@disqus.com', 'McFeate101', 'BSIT'),
(21, 'Skylar Schall', 'sschall3@macromedia.com', 'Reach4Sky', 'BSIT'),
(22, 'Jonathon Faas', 'jfaas8@army.mil', 'LoveJfaas2', 'BSIT'),
(23, 'Tabatha Martel', 'tmartelv@pagesperso-orange.fr', 'Tabby45', 'BSIT'),
(24, 'Ruggiero Dumingos', 'rdumingos11@trellian.com', 'Dommy661', 'BSIT'),
(25, 'Lolita Pogosian', 'lpogosian18@ask.com', 'Legal456', 'BSIT'),
(26, 'Emmery Georgi', 'egeorgit@slate.com', 'Egor11111', 'BSIT'),
(27, 'Chandra Spelsbury', 'cspelsburyf@harvard.edu', 'SpelburyQ23', 'BSIT'),
(28, 'Pierson Deneve', 'pdeneved@icq.com', 'Denver246', 'BSIT'),
(29, 'Malinda Trever', 'mtrever9@cdbaby.com', 'Trever11111', 'BSIT'),
(30, 'Walther Wadeson', 'wwadeson2@google.com', 'WaltherW101', 'BSIT'),
(31, 'Brendis Abramski', 'babramski4@nsw.gov.au', 'Brendy45', 'BSIT'),
(32, 'Rufus Bulled', 'rbulled10@163.com', 'RBM416', 'BSIT'),
(33, 'Mic Creber', 'mcreber14@is.gd', 'Crebbs111', 'BSIT'),
(34, 'Hugh Mong', 'Hmong@yahoo.com', 'Mong10101', 'BSIT'),
(35, 'Sumting Wong', 'S23wong@pen.io', 'WongPop34', 'BSIT'),
(36, 'Dani Godfroy', 'dgodfroyy@uol.com.br', 'Goddess101', 'BSIT'),
(37, 'Wilona Ventom', 'wventomx@yahoo.co.jp', 'Ventom123', 'BSIT'),
(38, 'Cybill Spatari', 'cspatario@fema.gov', 'Spartan676', 'BSIT'),
(39, 'Kev Kilsby', 'kkilsby7@hud.gov', 'Killerbee', 'BSIT'),
(40, 'Ludwig Konig', 'LKonig@gmail.com', 'Konigsplatz', 'BSIT'),
(41, 'Takashi Agata', 'TkAgata@msu.edu', 'AgataQuerty', 'BSIT'),
(42, 'Clevey Lugton', 'clugtonb@51.la', 'clugton51', 'BSIT'),
(43, 'Lia Yi', 'Yi123@gmail.com', '67LiaRest', 'BSIT'),
(44, 'Dyane Yeowell', 'dyeowellh@sogou.com', 'SogouD2', 'BSIT'),
(45, 'Denis Paris', 'dparisq@npr.org', '12345Paris', 'BSIT'),
(46, 'Vlad Siddmeir ', 'VSidd23@gmail.com', 'Sidd123Vlad', 'BSIT'),
(47, 'Mat Philipps ', 'Mphilipps@psu.edu', 'Mpu12345', 'BSIT'),
(48, 'Ivan Tonkista', 'ITonkista@howstuffworks.com', 'TonkWT101', 'BSIT'),
(49, 'Coop Sedwick', 'csedwickk@cnbc.com', 'BlueWick', 'BSIT'),
(50, 'Jon Smithy', 'JSmith@ph.com', 'JSmith999999', 'BSIT'),
(51, 'Ethan West', 'Ew@gmail.com', '234565457', 'BSIT'),
(52, 'Weasel Brown', 'Wbr@gmail.com', '23345ggb', 'BSIT'),
(53, 'Kim Un', 'KUn@gmail.com', 'nukedawest', 'BSIT'),
(54, 'Ethan Crew', 'Ec@gmail.com', '2234324gfdsg', 'BSIT'),
(55, 'Res', 'Res', 'res', 'BSIT');

-- --------------------------------------------------------

--
-- Table structure for table `teachers`
--

CREATE TABLE `teachers` (
  `TransID` int(11) NOT NULL,
  `Name` varchar(1000) COLLATE utf8mb4_bin NOT NULL,
  `Email` varchar(1000) COLLATE utf8mb4_bin NOT NULL,
  `Pass` varchar(1000) COLLATE utf8mb4_bin NOT NULL,
  `Subject` varchar(1000) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `teachers`
--

INSERT INTO `teachers` (`TransID`, `Name`, `Email`, `Pass`, `Subject`) VALUES
(1, 'Emma', 'b', 'b', 'History'),
(4, 'Sylvia', 'b2', 'b2', 'Math'),
(5, 'Maria', 'b3', 'b3', 'English'),
(7, 'Ethan Bert', 'b6', 'b6', 'English'),
(8, 'Will Anderson', 'WAndy@gmail.com', '12345Set', 'Science');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `actionhistory`
--
ALTER TABLE `actionhistory`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `actionhistoryexam`
--
ALTER TABLE `actionhistoryexam`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `actionhistorystudent`
--
ALTER TABLE `actionhistorystudent`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `englishexam`
--
ALTER TABLE `englishexam`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `englishexamtakers`
--
ALTER TABLE `englishexamtakers`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `englishgrade`
--
ALTER TABLE `englishgrade`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `examinfo`
--
ALTER TABLE `examinfo`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `historyexam`
--
ALTER TABLE `historyexam`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `historyexamtakers`
--
ALTER TABLE `historyexamtakers`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `historygrade`
--
ALTER TABLE `historygrade`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `mathexam`
--
ALTER TABLE `mathexam`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `mathexamtakers`
--
ALTER TABLE `mathexamtakers`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `mathgrade`
--
ALTER TABLE `mathgrade`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `scienceexam`
--
ALTER TABLE `scienceexam`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `scienceexamtakers`
--
ALTER TABLE `scienceexamtakers`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `sciencegrade`
--
ALTER TABLE `sciencegrade`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`TransID`);

--
-- Indexes for table `teachers`
--
ALTER TABLE `teachers`
  ADD PRIMARY KEY (`TransID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `actionhistory`
--
ALTER TABLE `actionhistory`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `actionhistoryexam`
--
ALTER TABLE `actionhistoryexam`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `actionhistorystudent`
--
ALTER TABLE `actionhistorystudent`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `englishexam`
--
ALTER TABLE `englishexam`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `englishexamtakers`
--
ALTER TABLE `englishexamtakers`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `englishgrade`
--
ALTER TABLE `englishgrade`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `examinfo`
--
ALTER TABLE `examinfo`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `historyexam`
--
ALTER TABLE `historyexam`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `historyexamtakers`
--
ALTER TABLE `historyexamtakers`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `historygrade`
--
ALTER TABLE `historygrade`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT for table `mathexam`
--
ALTER TABLE `mathexam`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `mathexamtakers`
--
ALTER TABLE `mathexamtakers`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `mathgrade`
--
ALTER TABLE `mathgrade`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `scienceexam`
--
ALTER TABLE `scienceexam`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `scienceexamtakers`
--
ALTER TABLE `scienceexamtakers`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `sciencegrade`
--
ALTER TABLE `sciencegrade`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;

--
-- AUTO_INCREMENT for table `teachers`
--
ALTER TABLE `teachers`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
