-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: amist-test-hd
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `EmployeeId` char(36) NOT NULL,
  `EmployeeCode` varchar(45) NOT NULL,
  `EmployeeName` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Gender` int DEFAULT NULL,
  `DateOfBirth` date DEFAULT NULL,
  `IdentifyId` varchar(12) DEFAULT NULL,
  `Position` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `CompanyName` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `BankAccount` varchar(12) DEFAULT NULL,
  `BankName` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `BankBranch` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`EmployeeId`),
  UNIQUE KEY `EmployeeId_UNIQUE` (`EmployeeId`),
  UNIQUE KEY `EmployeeCode_UNIQUE` (`EmployeeCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES ('055eddd7-bec3-11eb-a342-544810dacca7','MF039','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055ee51b-bec3-11eb-a342-544810dacca7','MF035','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055ee7fc-bec3-11eb-a342-544810dacca7','MF021','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055eea9b-bec3-11eb-a342-544810dacca7','MF005','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055ef815-bec3-11eb-a342-544810dacca7','MF020','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f0416-bec3-11eb-a342-544810dacca7','MF026','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f1abc-bec3-11eb-a342-544810dacca7','MF006','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f1dcf-bec3-11eb-a342-544810dacca7','MF023','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f203d-bec3-11eb-a342-544810dacca7','MF027','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f2266-bec3-11eb-a342-544810dacca7','MF025','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f256e-bec3-11eb-a342-544810dacca7','MF022','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f2850-bec3-11eb-a342-544810dacca7','MF024','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f2ac6-bec3-11eb-a342-544810dacca7','MF034','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f2d12-bec3-11eb-a342-544810dacca7','MF029','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f2f4f-bec3-11eb-a342-544810dacca7','MF028','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f318c-bec3-11eb-a342-544810dacca7','MF033','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f33a4-bec3-11eb-a342-544810dacca7','MF032','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f35b0-bec3-11eb-a342-544810dacca7','MF031','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f384c-bec3-11eb-a342-544810dacca7','MF030','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f3a60-bec3-11eb-a342-544810dacca7','MF008','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f3c73-bec3-11eb-a342-544810dacca7','MF036','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f3e97-bec3-11eb-a342-544810dacca7','MF002','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f40d5-bec3-11eb-a342-544810dacca7','MF004','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f4317-bec3-11eb-a342-544810dacca7','MF09','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f454e-bec3-11eb-a342-544810dacca7','MF007','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f476a-bec3-11eb-a342-544810dacca7','MF003','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f4987-bec3-11eb-a342-544810dacca7','MF017','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f4bfd-bec3-11eb-a342-544810dacca7','MF011','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f4e1f-bec3-11eb-a342-544810dacca7','MF016','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f502e-bec3-11eb-a342-544810dacca7','MF014','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f5362-bec3-11eb-a342-544810dacca7','MF013','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f570a-bec3-11eb-a342-544810dacca7','MF012','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f59f1-bec3-11eb-a342-544810dacca7','MF18','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('055f5c89-bec3-11eb-a342-544810dacca7','MF015','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA'),('9c720aa2-dc3d-411e-a9b7-26776ea48c90','MF042','Nguyễn Văn A2',1,'2000-01-03','4819481021','Nhân viên','Công ty Cổ phần MISa','112r1r11','MB','DBA');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-29 18:52:48
