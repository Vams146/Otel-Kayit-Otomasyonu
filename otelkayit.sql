-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: otelkayit
-- ------------------------------------------------------
-- Server version	8.0.37

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
-- Table structure for table `guvenlik`
--

DROP TABLE IF EXISTS `guvenlik`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `guvenlik` (
  `idguvenlik` int NOT NULL AUTO_INCREMENT,
  `guv_soru` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idguvenlik`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `guvenlik`
--

LOCK TABLES `guvenlik` WRITE;
/*!40000 ALTER TABLE `guvenlik` DISABLE KEYS */;
INSERT INTO `guvenlik` VALUES (1,'İlkokul Öğretmeninizin Adı?'),(2,'İlkokul Numaranız?'),(3,'İlk Evcil Hayvanınız?');
/*!40000 ALTER TABLE `guvenlik` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `musteri`
--

DROP TABLE IF EXISTS `musteri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `musteri` (
  `idmusteri` int NOT NULL AUTO_INCREMENT,
  `tc` varchar(11) DEFAULT NULL,
  `ad` varchar(45) DEFAULT NULL,
  `soyad` varchar(45) DEFAULT NULL,
  `telefon` varchar(45) DEFAULT NULL,
  `e_posta` varchar(45) DEFAULT NULL,
  `bas_tar` varchar(45) DEFAULT NULL,
  `bit_tar` varchar(45) DEFAULT NULL,
  `y_sayi` varchar(45) DEFAULT NULL,
  `odano` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idmusteri`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `musteri`
--

LOCK TABLES `musteri` WRITE;
/*!40000 ALTER TABLE `musteri` DISABLE KEYS */;
/*!40000 ALTER TABLE `musteri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odalar`
--

DROP TABLE IF EXISTS `odalar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odalar` (
  `idodalar` int NOT NULL AUTO_INCREMENT,
  `odano` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idodalar`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odalar`
--

LOCK TABLES `odalar` WRITE;
/*!40000 ALTER TABLE `odalar` DISABLE KEYS */;
INSERT INTO `odalar` VALUES (1,'A101'),(2,'A102'),(3,'A103'),(4,'B101'),(5,'B102'),(6,'B103'),(7,'C101'),(8,'C102'),(9,'C103');
/*!40000 ALTER TABLE `odalar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personel`
--

DROP TABLE IF EXISTS `personel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personel` (
  `idpersonel` int NOT NULL AUTO_INCREMENT,
  `tc` varchar(45) DEFAULT NULL,
  `ad` varchar(45) DEFAULT NULL,
  `soyad` varchar(45) DEFAULT NULL,
  `telefon` varchar(45) DEFAULT NULL,
  `e_posta` varchar(45) DEFAULT NULL,
  `gorev` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idpersonel`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personel`
--

LOCK TABLES `personel` WRITE;
/*!40000 ALTER TABLE `personel` DISABLE KEYS */;
/*!40000 ALTER TABLE `personel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uyelik`
--

DROP TABLE IF EXISTS `uyelik`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `uyelik` (
  `iduyelik` int NOT NULL AUTO_INCREMENT,
  `ad` varchar(45) DEFAULT NULL,
  `soyad` varchar(45) DEFAULT NULL,
  `e_posta` varchar(150) DEFAULT NULL,
  `k_adi` varchar(45) DEFAULT NULL,
  `sifre` varchar(45) DEFAULT NULL,
  `guv_soru` varchar(150) DEFAULT NULL,
  `cevap` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`iduyelik`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uyelik`
--

LOCK TABLES `uyelik` WRITE;
/*!40000 ALTER TABLE `uyelik` DISABLE KEYS */;
INSERT INTO `uyelik` VALUES (1,'Burak Aydın','Erdem','burakaydinerdem@gmail.com','burak','123','İlkokul Öğretmeninizin Adı?','Mehtap');
/*!40000 ALTER TABLE `uyelik` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-01 17:32:12
