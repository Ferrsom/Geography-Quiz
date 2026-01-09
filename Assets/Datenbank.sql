-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: quiz
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `capital`
--

DROP TABLE IF EXISTS `capital`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `capital` (
  `caID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`caID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `capital`
--

LOCK TABLES `capital` WRITE;
/*!40000 ALTER TABLE `capital` DISABLE KEYS */;
INSERT INTO `capital` VALUES (1,'Berlin'),(2,'Paris'),(3,'Rome'),(4,'Madrid'),(5,'Lisbon'),(6,'Brasilia'),(7,'BuenosAires'),(8,'Washington'),(9,'Ottawa'),(10,'MexicoCity'),(11,'Tokyo'),(12,'Beijing'),(13,'NewDelhi'),(14,'Canberra'),(15,'Cairo'),(16,'Pretoria'),(17,'Abuja'),(18,'Nairobi'),(19,'Moscow'),(20,'Oslo');
/*!40000 ALTER TABLE `capital` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `continent`
--

DROP TABLE IF EXISTS `continent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `continent` (
  `coID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`coID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `continent`
--

LOCK TABLES `continent` WRITE;
/*!40000 ALTER TABLE `continent` DISABLE KEYS */;
INSERT INTO `continent` VALUES (1,'Africa'),(2,'Europe'),(3,'Asia'),(4,'NorthAmerica'),(5,'SouthAmerica'),(6,'Australia'),(7,'Antarctica');
/*!40000 ALTER TABLE `continent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `country`
--

DROP TABLE IF EXISTS `country`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `country` (
  `couID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) DEFAULT NULL,
  `flagID` int(11) DEFAULT NULL,
  `capitalID` int(11) DEFAULT NULL,
  `continentID` int(11) DEFAULT NULL,
  PRIMARY KEY (`couID`),
  KEY `flagID` (`flagID`),
  KEY `capitalID` (`capitalID`),
  KEY `continentID` (`continentID`),
  CONSTRAINT `country_ibfk_1` FOREIGN KEY (`flagID`) REFERENCES `flag` (`fID`),
  CONSTRAINT `country_ibfk_2` FOREIGN KEY (`capitalID`) REFERENCES `capital` (`caID`),
  CONSTRAINT `country_ibfk_3` FOREIGN KEY (`continentID`) REFERENCES `continent` (`coID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `country`
--

LOCK TABLES `country` WRITE;
/*!40000 ALTER TABLE `country` DISABLE KEYS */;
INSERT INTO `country` VALUES (1,'Germany',1,1,2),(2,'France',2,2,2),(3,'Italy',3,3,2),(4,'Spain',4,4,2),(5,'Portugal',5,5,2),(6,'Brazil',6,6,5),(7,'Argentina',7,7,5),(8,'USA',8,8,4),(9,'Canada',9,9,4),(10,'Mexico',10,10,4),(11,'Japan',11,11,3),(12,'China',12,12,3),(13,'India',13,13,3),(14,'Australia',14,14,6),(15,'Egypt',15,15,1),(16,'SouthAfrica',16,16,1),(17,'Nigeria',17,17,1),(18,'Kenya',18,18,1),(19,'Russia',19,19,2),(20,'Norway',20,20,2);
/*!40000 ALTER TABLE `country` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flag`
--

DROP TABLE IF EXISTS `flag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flag` (
  `fID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`fID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flag`
--

LOCK TABLES `flag` WRITE;
/*!40000 ALTER TABLE `flag` DISABLE KEYS */;
INSERT INTO `flag` VALUES (1,'Germany Flag'),(2,'France Flag'),(3,'Italy Flag'),(4,'Spain Flag'),(5,'Portugal Flag'),(6,'Brazil Flag'),(7,'Argentina Flag'),(8,'USA Flag'),(9,'Canada Flag'),(10,'Mexico Flag'),(11,'Japan Flag'),(12,'China Flag'),(13,'India Flag'),(14,'Australia Flag'),(15,'Egypt Flag'),(16,'SouthAfrica Flag'),(17,'Nigeria Flag'),(18,'Kenya Flag'),(19,'Russia Flag'),(20,'Norway Flag');
/*!40000 ALTER TABLE `flag` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `game`
--

DROP TABLE IF EXISTS `game`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `game` (
  `gID` int(11) NOT NULL AUTO_INCREMENT,
  `Score` int(5) DEFAULT NULL,
  `playerID` int(11) DEFAULT NULL,
  PRIMARY KEY (`gID`),
  KEY `playerID` (`playerID`),
  CONSTRAINT `game_ibfk_1` FOREIGN KEY (`playerID`) REFERENCES `player` (`pID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `game`
--

LOCK TABLES `game` WRITE;
/*!40000 ALTER TABLE `game` DISABLE KEYS */;
INSERT INTO `game` VALUES (1,850,1),(2,920,2),(3,640,3),(4,1000,1),(5,780,4),(6,560,5),(7,890,2),(8,710,3);
/*!40000 ALTER TABLE `game` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `player`
--

DROP TABLE IF EXISTS `player`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `player` (
  `pID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) DEFAULT NULL,
  `Vorname` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`pID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `player`
--

LOCK TABLES `player` WRITE;
/*!40000 ALTER TABLE `player` DISABLE KEYS */;
INSERT INTO `player` VALUES (1,'DanielK',NULL),(2,'NeoArcade',NULL),(3,'PlayerOne',NULL),(4,'X7Frost',NULL),(5,'LunaByte',NULL);
/*!40000 ALTER TABLE `player` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-01-06 13:37:43
