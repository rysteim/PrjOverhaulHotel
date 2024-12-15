/*
SQLyog Community v13.1.5  (64 bit)
MySQL - 10.4.28-MariaDB : Database - overhaul_hotel
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
/*Table structure for table `tblaccount` */

DROP TABLE IF EXISTS `tblaccount`;

CREATE TABLE `tblaccount` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `profileID` int(11) NOT NULL,
  `roleID` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `dateCreated` date NOT NULL,
  `lastOnline` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`,`password`),
  UNIQUE KEY `password` (`password`),
  KEY `customerID` (`profileID`),
  KEY `positionID` (`roleID`),
  CONSTRAINT `tblaccount_ibfk_1` FOREIGN KEY (`profileID`) REFERENCES `tblprofile` (`id`),
  CONSTRAINT `tblaccount_ibfk_2` FOREIGN KEY (`roleID`) REFERENCES `tblrole` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblaccount` */

insert  into `tblaccount`(`id`,`profileID`,`roleID`,`username`,`password`,`dateCreated`,`lastOnline`) values 
(1,1,1,'admin','1234','2024-10-29','2024-12-16 01:14:24'),
(2,2,2,'kyrelle','mitty','2024-11-05',NULL),
(3,3,1,'yoonzino','svt','2024-11-05',NULL),
(15,15,1,'soggycereal','bruh','2024-11-20','2024-12-15 19:28:57'),
(18,19,2,'kash','torino','2024-12-15','2024-12-15 20:27:24'),
(26,32,2,'kash','admin','2024-12-15','2024-12-16 01:09:00'),
(27,33,3,'bnd','koz','2024-12-15',NULL),
(28,34,4,'telepath','hehe','2024-12-16','2024-12-16 01:15:27'),
(29,35,5,'faker','f1','2024-12-16','2024-12-16 01:08:41');

/*Table structure for table `tblaccount_membership` */

DROP TABLE IF EXISTS `tblaccount_membership`;

CREATE TABLE `tblaccount_membership` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `accountID` int(11) NOT NULL,
  `membershipID` int(11) NOT NULL,
  `accountStatus` varchar(30) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `accountID` (`accountID`),
  KEY `membershipID` (`membershipID`),
  CONSTRAINT `tblaccount_membership_ibfk_1` FOREIGN KEY (`accountID`) REFERENCES `tblaccount` (`id`),
  CONSTRAINT `tblaccount_membership_ibfk_2` FOREIGN KEY (`membershipID`) REFERENCES `tblmembership` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblaccount_membership` */

insert  into `tblaccount_membership`(`id`,`accountID`,`membershipID`,`accountStatus`) values 
(1,1,1,'Inactive'),
(3,2,3,'Inactive'),
(4,3,2,'Inactive'),
(17,15,2,'Inactive');

/*Table structure for table `tbladdons` */

DROP TABLE IF EXISTS `tbladdons`;

CREATE TABLE `tbladdons` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `addonName` varchar(50) NOT NULL,
  `description` varchar(200) NOT NULL,
  `price` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tbladdons` */

insert  into `tbladdons`(`id`,`addonName`,`description`,`price`) values 
(1,'Food Service','Be served food 3 times a day in your room.',200),
(2,'Extra blankets','Adds an additional thick and comfortable blanket.',10),
(3,'Extra pillows','Adds a pillow.',10),
(4,'Extra towels','Adds additional towels.',5),
(5,'Pool Access','Grants access to all the pools in the hotel\'s vicinity.',250),
(6,'Gym Access','Grants access to the hotel\'s gym.',100),
(7,'Extra bathrobes','Enjoy a plush bathrobe for your comfort while lounging in your room or at the poolside.',1500),
(8,'Scented Bath Soap','Indulge in our artisanal scented bath soaps made from natural ingredients, perfect for a soothing bathing experience.',200),
(9,'Extra foam/mattress','Adds a high-quality foam.',30);

/*Table structure for table `tblemployee` */

DROP TABLE IF EXISTS `tblemployee`;

CREATE TABLE `tblemployee` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `accountID` int(11) NOT NULL,
  `workShift` varchar(30) NOT NULL,
  `salaryPerHour` double NOT NULL,
  `employmentDate` date NOT NULL,
  `status` varchar(30) NOT NULL,
  `lastLogin` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `accountID` (`accountID`),
  CONSTRAINT `tblemployee_ibfk_1` FOREIGN KEY (`accountID`) REFERENCES `tblaccount` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblemployee` */

insert  into `tblemployee`(`id`,`accountID`,`workShift`,`salaryPerHour`,`employmentDate`,`status`,`lastLogin`) values 
(12,26,'Whole Day',0,'2024-12-15','','2024-12-16 01:08:47'),
(13,27,'Morning',0,'2024-12-15','','0000-00-00 00:00:00'),
(14,28,'Afternoon',0,'2024-12-16','','2024-12-16 01:15:27'),
(15,29,'Whole Day',0,'2024-12-16','','2024-12-16 01:08:20');

/*Table structure for table `tblmembership` */

DROP TABLE IF EXISTS `tblmembership`;

CREATE TABLE `tblmembership` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `membershipStatus` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblmembership` */

insert  into `tblmembership`(`id`,`membershipStatus`) values 
(1,'Guest'),
(2,'VIP'),
(3,'Paid'),
(4,'Business'),
(5,'Partner'),
(6,'Vacation');

/*Table structure for table `tblprofile` */

DROP TABLE IF EXISTS `tblprofile`;

CREATE TABLE `tblprofile` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(50) NOT NULL,
  `middleName` varchar(50) DEFAULT NULL,
  `lastName` varchar(50) NOT NULL,
  `contactNo` varchar(15) NOT NULL,
  `emailAddress` varchar(40) NOT NULL,
  `address` varchar(100) NOT NULL,
  `gender` varchar(20) NOT NULL,
  `birthdate` date NOT NULL,
  `image` text DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `emailAddress` (`emailAddress`),
  UNIQUE KEY `contactNo` (`contactNo`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblprofile` */

insert  into `tblprofile`(`id`,`firstName`,`middleName`,`lastName`,`contactNo`,`emailAddress`,`address`,`gender`,`birthdate`,`image`) values 
(1,'Kashmir','Nimaria','Torino','09156855768','kashtorino@gmail.com','Mankilam, Tagum City','Male','2004-05-14','C:\\Users\\jazzy\\Downloads\\396532cad95b3bcffcf3159ef34ff3e1.jpg'),
(2,'Kyrelle','Talledo','Aquino','09913617230','k.aquino@gmail.com','Tagum City','Male','2002-11-15','C:\\Users\\jazzy\\Downloads\\4d84bb59074bf2df411c9cb7f2f0ff2c.jpg'),
(3,'Jeonghan','','Yoon','09123456789','svt@gmail.com','Seoul','Male','1996-09-07','C:\\Users\\jazzy\\Downloads\\461330633_496289853331233_6372511773470926964_n.jpg'),
(15,'Kyron','James','Sostino','09182736455','jameskyron@gmail.com','09182736455','Male','2003-04-01','C:\\Users\\jazzy\\Downloads\\5c8b18a1d95fce3c7740bed1a49fd7fd.jpg'),
(19,'Kashmir','Nimaria','Torino','09156855769','ktorino@gmail.com','Tagum City','Male','2004-05-14','C:\\Users\\jazzy\\Downloads\\UM.jpg'),
(26,'zach','','herron','0981612311','caroline','caroline','Male','1989-05-15','C:\\Users\\jazzy\\Downloads\\smartlogo.jpg'),
(27,'Kashmir','Nimaria','Torino','09978035772','kashtorino@yahoo.com','Tagum City','Male','2004-05-14','C:\\Users\\jazzy\\Downloads\\UM.jpg'),
(32,'Kashmir','Nimaria','Torino','09156855791','kashtorino@umindanao.edu.ph','Tagum City','Male','2004-05-14','C:\\Users\\jazzy\\Downloads\\UM.jpg'),
(33,'Boy','Next','Door','09182938471','bnd@email.com','kozent','Male','2023-05-30','C:\\Users\\jazzy\\Downloads\\d67bd1548e781b4a81a26ab2621c85b0.jpg'),
(34,'Anya','','Forger','09987654321','spyxfamily@gmail.com','Anime','Female','2009-11-26','C:\\Users\\jazzy\\Downloads\\5c8b18a1d95fce3c7740bed1a49fd7fd.jpg'),
(35,'Sanghyeok','','Lee','0913857191','lol@gmail.com','0913857191','Male','2005-11-18','C:\\Users\\jazzy\\OneDrive\\Pictures\\Camera Roll\\assignment-1711173766 (1).jpg');

/*Table structure for table `tblpromo` */

DROP TABLE IF EXISTS `tblpromo`;

CREATE TABLE `tblpromo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `promoName` varchar(50) NOT NULL,
  `description` varchar(200) NOT NULL,
  `discount` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblpromo` */

insert  into `tblpromo`(`id`,`promoName`,`description`,`discount`) values 
(1,'None','No promo.',0),
(2,'Merry Stays & Cozy Nights - Christmas Eve Deal','Book 3 nights during the Christmas season and get a discount and a free breakfast for the whole duration of your stay.',20),
(3,'Spooktacular Staycation - Halloween Spooky Deal','Stay 2 nights during the Halloween season and get a hefty discount.',15),
(4,'Work Hard, Relax Harder - Labor Day Deal','Celebrate Labor Day by rewarding hard-working guests with a special discounted stay package.',20),
(5,'Enchanted Evenings - Valentines Day Deal','Enjoy a cozy-night in with a romantic partner and feel the love with this discount.',20),
(6,'Birthday Bliss Staycation - Birthday Deal','Celebrate in style with a luxurious stay and enjoy the discount.',15),
(7,'New Year, New Staycation - New Year\'s Eve Deal','Celebrate the start of the year with a relaxing retreat. Enjoy festive decorations, special New Year\'s Eve dining, and a complimentary champagne toast at midnight.',20),
(8,'Thankful Family Staycation - Thanksgiving Deal','Give thanks and enjoy a warm and welcoming holiday experience with a special Thanksgiving dinner included with your stay.',15),
(9,'Leap into Spring - Spring Season Promo','Whether you\'re traveling for a weekend getaway, a long vacation, or a business trip, enjoy special rates and seasonal perks during this limited-time offer.',15);

/*Table structure for table `tblreservation` */

DROP TABLE IF EXISTS `tblreservation`;

CREATE TABLE `tblreservation` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `accountID` int(11) NOT NULL,
  `promoID` int(11) NOT NULL,
  `invoice` varchar(10) NOT NULL,
  `reservationStatus` varchar(20) DEFAULT NULL,
  `bookingDate` date NOT NULL,
  `totalDays` int(11) DEFAULT NULL,
  `totalAmount` double DEFAULT NULL,
  `paidAmount` double DEFAULT NULL,
  `remainingBalance` double DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `accountID` (`accountID`),
  KEY `promoID` (`promoID`),
  CONSTRAINT `tblreservation_ibfk_1` FOREIGN KEY (`accountID`) REFERENCES `tblaccount` (`id`),
  CONSTRAINT `tblreservation_ibfk_2` FOREIGN KEY (`promoID`) REFERENCES `tblpromo` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblreservation` */

insert  into `tblreservation`(`id`,`accountID`,`promoID`,`invoice`,`reservationStatus`,`bookingDate`,`totalDays`,`totalAmount`,`paidAmount`,`remainingBalance`) values 
(1,1,1,'INV213485','For Approval','2024-11-15',18,299000,20000,279000);

/*Table structure for table `tblreservation_addons` */

DROP TABLE IF EXISTS `tblreservation_addons`;

CREATE TABLE `tblreservation_addons` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `reservationID` int(11) NOT NULL,
  `addonsID` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `reservationID` (`reservationID`),
  KEY `addonsID` (`addonsID`),
  CONSTRAINT `tblreservation_addons_ibfk_1` FOREIGN KEY (`reservationID`) REFERENCES `tblreservation` (`id`),
  CONSTRAINT `tblreservation_addons_ibfk_2` FOREIGN KEY (`addonsID`) REFERENCES `tbladdons` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblreservation_addons` */

/*Table structure for table `tblreservation_room` */

DROP TABLE IF EXISTS `tblreservation_room`;

CREATE TABLE `tblreservation_room` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `reservationID` int(11) NOT NULL,
  `roomID` int(11) NOT NULL,
  `checkInDate` date NOT NULL,
  `checkOutDate` date NOT NULL,
  `totalRoomPrice` double NOT NULL,
  `roomStatus` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `reservationID` (`reservationID`),
  KEY `roomID` (`roomID`),
  CONSTRAINT `tblreservation_room_ibfk_1` FOREIGN KEY (`reservationID`) REFERENCES `tblreservation` (`id`),
  CONSTRAINT `tblreservation_room_ibfk_2` FOREIGN KEY (`roomID`) REFERENCES `tblroom` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblreservation_room` */

insert  into `tblreservation_room`(`id`,`reservationID`,`roomID`,`checkInDate`,`checkOutDate`,`totalRoomPrice`,`roomStatus`) values 
(18,1,18,'2024-11-08','2024-11-10',70000,'Available'),
(19,1,19,'2025-01-01','2025-01-03',70000,'Reserved'),
(20,1,8,'2024-12-30','2025-01-03',26000,'Reserved'),
(21,1,14,'2024-12-14','2024-12-16',30000,'Occupied'),
(22,1,5,'2024-12-13','2024-12-15',13000,'Available'),
(23,1,16,'2024-12-14','2024-12-20',90000,'Occupied');

/*Table structure for table `tblrole` */

DROP TABLE IF EXISTS `tblrole`;

CREATE TABLE `tblrole` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `roleName` varchar(20) NOT NULL,
  `salaryPerHour` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblrole` */

insert  into `tblrole`(`id`,`roleName`,`salaryPerHour`) values 
(1,'Guest','0'),
(2,'Administrator','N/A'),
(3,'Manager','1680.00 - 3360.00'),
(4,'Front Desk Staff','728.00 - 1008.00'),
(5,'Housekeeping Staff',' 672.00 - 896.00');

/*Table structure for table `tblroom` */

DROP TABLE IF EXISTS `tblroom`;

CREATE TABLE `tblroom` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `roomName` varchar(20) NOT NULL,
  `roomType` varchar(30) NOT NULL,
  `description` varchar(150) NOT NULL,
  `pricePerDay` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblroom` */

insert  into `tblroom`(`id`,`roomName`,`roomType`,`description`,`pricePerDay`) values 
(1,'D100','Deluxe Room','Standard luxury room with upscale décor, modern amenities, and often a city or garden view.',4000),
(2,'D101','Deluxe Room','Standard luxury room with upscale décor, modern amenities, and often a city or garden view.',4000),
(3,'D102','Deluxe Room','Standard luxury room with upscale décor, modern amenities, and often a city or garden view.',4000),
(4,'D103','Deluxe Room','Standard luxury room with upscale décor, modern amenities, and often a city or garden view.',4000),
(5,'P200','Premier Room','A step up from the Deluxe Room, usually featuring better views and more space.',6500),
(6,'P201','Premier Room','A step up from the Deluxe Room, usually featuring better views and more space.',6500),
(7,'P202','Premier Room','A step up from the Deluxe Room, usually featuring better views and more space.',6500),
(8,'P203','Premier Room','A step up from the Deluxe Room, usually featuring better views and more space.',6500),
(9,'J300','Junior Suite','Spacious room with a separate sitting area, but not necessarily a fully divided space. Ideal for guests seeking a bit more comfort.',9000),
(10,'J301','Junior Suite','Spacious room with a separate sitting area, but not necessarily a fully divided space. Ideal for guests seeking a bit more comfort.',9000),
(11,'J302','Junior Suite','Spacious room with a separate sitting area, but not necessarily a fully divided space. Ideal for guests seeking a bit more comfort.',9000),
(12,'J303','Junior Suite','Spacious room with a separate sitting area, but not necessarily a fully divided space. Ideal for guests seeking a bit more comfort.',9000),
(13,'E400','Executive Suite','Larger than the Junior Suite with a fully separate living room and bedroom, often used by business travelers or families.',15000),
(14,'E401','Executive Suite','Larger than the Junior Suite with a fully separate living room and bedroom, often used by business travelers or families.',15000),
(15,'E402','Executive Suite','Larger than the Junior Suite with a fully separate living room and bedroom, often used by business travelers or families.',15000),
(16,'E403','Executive Suite','Larger than the Junior Suite with a fully separate living room and bedroom, often used by business travelers or families.',15000),
(17,'R500','Royal Suite','The pinnacle of luxury, often with multiple rooms, private dining areas, and sometimes private pools or terraces. This suite is usually reserved for V',35000),
(18,'R501','Royal Suite','The pinnacle of luxury, often with multiple rooms, private dining areas, and sometimes private pools or terraces. This suite is usually reserved for V',35000),
(19,'R502','Royal Suite','The pinnacle of luxury, often with multiple rooms, private dining areas, and sometimes private pools or terraces. This suite is usually reserved for V',35000),
(20,'I600','Imperial Suite','Located on the top two floors, offering the best views and sometimes featuring exclusive facilities like a private terrace or pool.',60000),
(21,'I700','Imperial Suite','Located on the top two floors, offering the best views and sometimes featuring exclusive facilities like a private terrace or pool.',60000);

/*Table structure for table `tblshift` */

DROP TABLE IF EXISTS `tblshift`;

CREATE TABLE `tblshift` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeID` int(11) NOT NULL,
  `shiftStart` datetime NOT NULL,
  `shiftStop` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `employeeID` (`employeeID`),
  CONSTRAINT `tblshift_ibfk_1` FOREIGN KEY (`employeeID`) REFERENCES `tblemployee` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblshift` */

/* Procedure structure for procedure `proc_accountAdd` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_accountAdd` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_accountAdd`(p_profileID int,
						p_username varchar(50),
						p_password varchar(100),
						p_dateCreated date)
BEGIN
		insert into tblaccount (profileID,
					roleID,
					username,
					password,
					dateCreated)
				values (p_profileID,
					"1",
					p_username,
					p_password,
					p_dateCreated);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_accountData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_accountData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_accountData`()
BEGIN
		select * from tblaccount;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_accountDefaultMembership` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_accountDefaultMembership` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_accountDefaultMembership`(p_accountID int)
BEGIN
		insert into tblaccount_membership (accountID,
						membershipID,
						accountStatus)
					values (p_accountID,
						"1",
						"Inactive");
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_accountDelete` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_accountDelete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_accountDelete`(p_id int)
BEGIN
		delete from tblaccount where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_accountGetByID` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_accountGetByID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_accountGetByID`(p_accountID int)
BEGIN
		select * from view_account where ACCOUNTID = p_accountID;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_accountGetIDByUsername` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_accountGetIDByUsername` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_accountGetIDByUsername`(p_username	varchar(30))
BEGIN
		select * from tblaccount where username = p_username;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_accountSetMembership` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_accountSetMembership` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_accountSetMembership`(p_accountID int,
							p_membershipID int)
BEGIN
		update tblaccount_membership set membershipID = p_membershipID
					where accountID = p_accountID;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_accountSetStatus` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_accountSetStatus` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_accountSetStatus`(p_accountID int,
							p_status varchar(30))
BEGIN
		update tblaccount_membership set accountStatus = p_status
					where accountID = p_accountID;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_accountUpdate` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_accountUpdate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_accountUpdate`(p_id int,
						p_username varchar(50),
						p_password varchar(100))
BEGIN
		update tblaccount set username = p_username,
					password = p_password
				where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonAdd` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonAdd` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonAdd`(p_addonname varchar(50),
						p_description varchar(200),
						p_price double)
BEGIN
		insert into tbladdons (addonname,
					description,
					price)
				values (p_addonname,
					p_description,
					p_price);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonData`()
BEGIN
		select * from tbladdons;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonDelete` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonDelete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonDelete`(p_id int)
BEGIN
		delete from tbladdons where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonGetByID` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonGetByID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonGetByID`(p_id int)
BEGIN
		select * from tbladdons where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonGetByName` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonGetByName` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonGetByName`(p_addonName varchar(50))
begin
		select * from tbladdons where addonName = p_addonName;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonReservationAdd` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonReservationAdd` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonReservationAdd`(p_reservationID int,
									p_addonsID int)
begin
		insert into tblreservation_addons (reservationID,
							addonsID)
						values (p_reservationID,
							p_addonsID);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonReservationData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonReservationData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonReservationData`(p_id	int)
BEGIN
		select * from view_addonreservations where RID = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonReservationDelete` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonReservationDelete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonReservationDelete`(p_id int)
begin
		delete from tblreservation_addons where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonReservationUpdate` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonReservationUpdate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonReservationUpdate`(p_id int,
									p_reservationID int,
									p_addonsID int)
begin
		update tblreservation_addons set reservationID = p_reservationID,
						addonsID = p_addonsID
					where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonsData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonsData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonsData`()
BEGIN
		select * from tbladdons;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonSearch` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonSearch` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonSearch`(p_addonName varchar(50))
BEGIN
		select * from tbladdons where addonName like concat("%", p_addonName,"%");
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_addonUpdate` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_addonUpdate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addonUpdate`(p_id int,
						p_addonname varchar(50),
						p_description varchar(200),
						p_price double)
BEGIN
		update tbladdons set addonname = p_addonname,
					description = p_description,
					price = p_price
				where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_employeeAdd` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_employeeAdd` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_employeeAdd`(p_firstName varchar(50),
								p_middleName varchar(50),
								p_lastName varchar(50),
								p_contactNo varchar(15),
								p_emailAdd varchar(40),
								p_address varchar(100),
								p_gender varchar(20),
								p_birthdate date,
								p_image text,
								p_username varchar(50),
								p_password varchar(100),
								p_roleName varchar(20),
								p_workShift varchar(20),
								p_dateCreated date)
BEGIN
		DECLARE p_profileID INT;
		DECLARE p_roleID INT;
		DECLARE p_accountID INT;
		DECLARE p_employeeID INT;
		DECLARE emailExists INT;
		declare usernameExists int;
		declare passwordExists int;
		
		INSERT INTO tblprofile (firstName, middleName, lastName, contactNo, emailAddress, address, gender, birthdate, image)
		VALUES (p_firstName, p_middleName, p_lastName, p_contactNo, p_emailAdd, p_address, p_gender, p_birthdate, p_image);
		
		set p_profileID = (Select id from tblprofile where lastName = p_lastName and emailAddress = p_emailAdd);
		
		set p_roleID = (select id from tblrole where roleName = p_roleName);
		
		INSERT INTO tblaccount (profileID,
					roleID,
					username,
					PASSWORD,
					dateCreated)
				VALUES (p_profileID,
					p_roleID,
					p_username,
					p_password,
					p_dateCreated);
		
		set p_accountID = (select id from tblaccount where profileID = p_profileID);
		
		insert into tblemployee (accountID,
					workShift,
					employmentDate)
				values (p_accountID,
					p_workShift,
					p_dateCreated);
					
		set p_employeeID = (select id from tblemployee where accountID = p_accountID);
		
		select * from tblemployee where id = p_employeeID;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_employeeCheckAvailability` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_employeeCheckAvailability` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_employeeCheckAvailability`(p_firstName VARCHAR(50),
								p_middleName VARCHAR(50),
								p_lastName VARCHAR(50),
								p_contactNo VARCHAR(15),
								p_emailAdd VARCHAR(40),
								p_address VARCHAR(100),
								p_gender VARCHAR(20),
								p_birthdate DATE,
								p_image TEXT,
								p_username VARCHAR(50),
								p_password VARCHAR(100),
								p_roleName VARCHAR(20),
								p_workShift VARCHAR(20),
								p_dateCreated DATE)
BEGIN
    DECLARE emailExists INT;
    DECLARE usernameExists INT;
    DECLARE contactExists INT;

    -- Check if the email already exists
    SELECT COUNT(*) INTO emailExists
    FROM tblprofile
    WHERE emailAddress = p_emailAdd;

    -- Check if the username already exists
    SELECT COUNT(*) INTO usernameExists
    FROM tblaccount
    WHERE username = p_username;

    -- Check if the contact number already exists
    SELECT COUNT(*) INTO contactExists
    FROM tblprofile
    WHERE contactNo = p_contactNo;

    -- Evaluate the results
    IF emailExists > 0 THEN
        SELECT 'Email already exists' AS message, p_emailAdd AS conflict;
    ELSEIF usernameExists > 0 THEN
        SELECT 'Username already exists' AS message, p_username AS conflict;
    ELSEIF contactExists > 0 THEN
        SELECT 'Contact number already exists' AS message, p_contactNo AS conflict;
    ELSE
        SELECT 'All details are available' AS message;
    END IF;

	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_employeeData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_employeeData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_employeeData`()
BEGIN
		select * from view_employee;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_employeeDelete` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_employeeDelete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_employeeDelete`(p_id int)
BEGIN
		DECLARE p_accountID INT;
		DECLARE p_profileID INT;
		declare p_employeeID int;
		
		SET p_profileID = (SELECT profileID FROM tblaccount WHERE id = p_id);
		set p_employeeID = (select id from tblemployee where accountID = p_id);
		SET p_accountID = p_id;
		
		delete from tblshift where employeeID = p_employeeID;
		delete from tblemployee where accountID = p_accountID;
		delete from tblaccount_membership where accountID = p_id;
		DELETE FROM tblaccount WHERE id = p_accountID;
		DELETE FROM tblprofile WHERE id = p_profileID;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_employeeGetByAccountID` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_employeeGetByAccountID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_employeeGetByAccountID`(p_id int)
BEGIN
		select * from view_employee where AID = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_employeeGetShiftByEmployeeID` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_employeeGetShiftByEmployeeID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_employeeGetShiftByEmployeeID`(p_id int)
BEGIN
		select * from tblshift where employeeID = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_employeeLastOnline` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_employeeLastOnline` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_employeeLastOnline`(p_id int,
							p_lastOnline datetime)
BEGIN
		update tblemployee set lastLogin = p_lastOnline
				where accountID = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_employeeSearch` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_employeeSearch` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_employeeSearch`(p_fullName varchar(100),
						p_role varchar(40),
						p_workshift varchar(30))
BEGIN
		select * from view_employee where FULLNAME LIKE CONCAT("%", p_fullname, "%")
					AND ROLE LIKE CONCAT(p_role, "%")
					AND WORKSHIFT LIKE CONCAT(p_workshift, "%");
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_employeeUpdate` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_employeeUpdate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_employeeUpdate`(p_id int,
						p_firstName varchar(30),
						p_middleName varchar(30),
						p_lastName varchar(30),
						p_username varchar(30),
						p_password varchar(30),
						p_roleName varchar(20),
						p_workShift varchar(20),
						p_hourlyRate double,
						p_contactNo varchar(15),
						p_emailAdd varchar(100),
						p_address varchar(200),
						p_gender varchar(20),
						p_birthdate date,
						p_image text)
BEGIN
		declare p_profileID int;
		declare p_roleID int;
		
		set p_profileID = (select profileID from tblaccount where id = p_id limit 1);
		set p_roleID = (select id from tblrole where roleName = p_roleName limit 1);
		
		call proc_profileUpdate(p_profileID, p_firstName, p_middleName, p_lastName, p_contactNo, p_emailAdd, p_address, p_gender, p_birthdate, p_image);
		
		update tblaccount set username = p_username,
					`password` = p_password,
					roleID = p_roleID
				where id = p_id;
				
		update tblemployee set workShift = p_workShift,
					salaryPerHour = p_hourlyRate
				where accountID = p_id;
					
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_guestActive` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_guestActive` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_guestActive`(p_id int, p_lastOnline datetime)
BEGIN
		update tblaccount set lastOnline = p_lastOnline
				where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_guestData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_guestData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_guestData`()
BEGIN
		select * from view_guest;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_guestDelete` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_guestDelete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_guestDelete`(p_id int)
BEGIN
		declare p_accountID int;
		declare p_profileID int;
		
		set p_profileID = (SELECT profileID FROM tblaccount WHERE id = p_id);
		set p_accountID = p_id;
		
		DELETE FROM tblaccount_membership WHERE accountID = p_accountID;
		DELETE FROM tblaccount WHERE id = p_accountID;
		DELETE FROM tblprofile WHERE id = p_profileID;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_guestGetByAccountID` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_guestGetByAccountID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_guestGetByAccountID`(p_accountID int)
BEGIN
		select * from view_guest where AID = p_accountID;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_guestSearch` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_guestSearch` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_guestSearch`(p_fullname varchar(100),
						p_membership varchar(20),
						p_status varchar(30))
BEGIN
		SELECT * FROM view_guest WHERE FULLNAME LIKE CONCAT("%", p_fullname, "%")
					AND MEMBERSHIP LIKE CONCAT(p_membership, "%")
					AND STATUS LIKE CONCAT(p_status, "%");
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_guestUpdate` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_guestUpdate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_guestUpdate`(p_aid int,
						p_firstName varchar(40),
						p_middleName varchar(40),
						p_lastName varchar(40),
						p_contactNo varchar(15),
						p_emailAddress varchar(40),
						p_address varchar(100),
						p_gender varchar(20),
						p_birthdate date,
						p_image text,
						p_membership int,
						p_username varchar(50),
						p_password varchar(100))
BEGIN
		DECLARE p_accountID INT;
		DECLARE p_profileID INT;
		
		SET p_profileID = (SELECT profileID FROM tblaccount WHERE id = p_aid);
		SET p_accountID = p_aid;
		
		update tblprofile set firstName = p_firstName,
					middleName = p_middleName,
					lastName = p_lastName,
					contactNo = p_contactNo,
					emailAddress = p_emailAddress,
					address = p_contactNo,
					gender = p_gender,
					birthdate = p_birthdate,
					image = p_image
				where id = p_profileID;
		update tblaccount set username = p_username,
					password = p_password
				where id = p_accountID;
		update tblaccount_membership set membershipID = p_membership
				where accountID = p_accountID;
					
					
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_logIn` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_logIn` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_logIn`(p_username varchar(50),
						p_password varchar(100))
BEGIN
		select * from view_account where USERNAME = p_username
						and PASSWORD = p_password;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_membershipData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_membershipData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_membershipData`()
BEGIN
		select * from tblmembership;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_profileAdd` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_profileAdd` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_profileAdd`(p_firstname varchar(50),
						p_middlename varchar(50),
						p_lastname varchar(50),
						p_contactno varchar(15),
						p_emailaddress varchar(40),
						p_address varchar(100),
						p_gender varchar(20),
						p_birthdate date,
						p_image text)
BEGIN
		insert into tblprofile (firstname,
					middlename,
					lastname,
					contactno,
					emailaddress,
					address,
					gender,
					birthdate,
					image)
				values (p_firstname,
					p_middlename,
					p_lastname,
					p_contactno,
					p_emailaddress,
					p_address,
					p_gender,
					p_birthdate,
					p_image);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_profileData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_profileData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_profileData`()
BEGIN
		select * from tblprofile;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_profileDelete` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_profileDelete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_profileDelete`(p_id int)
BEGIN
		delete from tblprofile where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_profileGetIDByFullName` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_profileGetIDByFullName` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_profileGetIDByFullName`(p_firstname VARCHAR(50),
						p_middlename VARCHAR(50),
						p_lastname VARCHAR(50),
						p_emailadd varchar(100))
BEGIN
		select * from tblprofile where firstname = p_firstname 
					and middlename = p_middlename
					and lastname = p_lastname
					and emailAddress = p_emailadd;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_profileUpdate` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_profileUpdate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_profileUpdate`(p_id int,
						p_firstname varchar(50),
						p_middlename varchar(50),
						p_lastname varchar(50),
						p_contactno varchar(15),
						p_emailaddress varchar(40),
						p_address varchar(100),
						p_gender varchar(20),
						p_birthdate date,
						p_image text)
BEGIN
		update tblprofile set firstname = p_firstname,
					middlename = p_middlename,
					lastname = p_lastname,
					contactno = p_contactno,
					emailaddress = p_emailaddress,
					address = p_address,
					gender = p_gender,
					birthdate = p_birthdate,
					image = p_image
				where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_promoAdd` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_promoAdd` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_promoAdd`(p_promoname varchar(50),
						p_description varchar(200),
						p_discount double)
BEGIN
		insert into tblpromo (promoname,
					description,
					discount)
				values (p_promoname,
					p_description,
					p_discount);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_promoData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_promoData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_promoData`()
BEGIN
		select * from tblpromo;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_promoDelete` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_promoDelete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_promoDelete`(p_id int)
BEGIN
		delete from tblpromo where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_promoGetByID` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_promoGetByID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_promoGetByID`(p_id int)
BEGIN
		select * from tblpromo where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_promoSearch` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_promoSearch` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_promoSearch`(p_promoName varchar(50))
BEGIN
		select * from tblpromo where promoName like concat("%", p_promoName,"%");
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_promoUpdate` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_promoUpdate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_promoUpdate`(p_id int,
						p_promoname varchar(50),
						p_description varchar(200),
						p_discount double)
BEGIN
		update tblpromo set promoname = p_promoname,
					description = p_description,
					discount = p_discount
				where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationAdd` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationAdd` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationAdd`(p_accountID int,
						p_promoID int,
						p_invoice varchar(9),
						p_bookingDate date)
BEGIN
		insert into tblreservation (accountID,
						promoID,
						invoice,
						reservationStatus,
						bookingDate,
						totalDays,
						totalAmount,
						paidAmount,
						remainingBalance)
					values (p_accountID,
						p_promoID,
						p_invoice,
						"For Approval",
						p_bookingDate,
						0,
						0,
						0,
						0);
						
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationApprove` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationApprove` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationApprove`(p_id int, p_date datetime)
BEGIN
		update tblreservation set reservationStatus = 'Approved'
					where id = p_id;
		call proc_roomCheckRoomStatus(p_date);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationData`()
BEGIN
		select * from view_reservation;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationDelete` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationDelete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationDelete`(p_id int)
BEGIN
		delete from tblreservation_addons where reservationID = p_id;
		delete from tblreservation_room where reservationID = p_id;
		DELETE FROM tblreservation WHERE id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationGetAccountID` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationGetAccountID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationGetAccountID`(p_id int)
BEGIN
		select * from view_reservation where RESERVATION_ID = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationGetByAccountID` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationGetByAccountID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationGetByAccountID`(p_id int)
BEGIN
		select * from tblreservation where accountID = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationGetByID` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationGetByID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationGetByID`(p_id int)
BEGIN
		select * from tblreservation where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationGetTotalAmount` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationGetTotalAmount` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationGetTotalAmount`(p_id int)
BEGIN
		declare totalPrice double;
		set totalPrice = (SELECT SUM(totalRoomPrice) AS "TOTAL ROOM PRICE" FROM tblreservation_room WHERE reservationID = p_id);
		
		Update tblreservation set totalAmount = totalPrice,
					remainingBalance = (totalAmount - paidAmount)
			where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationGetTotalDays` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationGetTotalDays` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationGetTotalDays`(p_id int)
BEGIN
		SELECT sum(DATEDIFF(checkOutDate, checkInDate)) AS "TOTAL DAYS" FROM tblreservation_room WHERE reservationID = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationSearchByName` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationSearchByName` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationSearchByName`(p_name varchar(30))
BEGIN
		SELECT * from view_reservation where FULL_NAME like CONCAT("%", p_name, "%");
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationSetPaidAmount` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationSetPaidAmount` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationSetPaidAmount`(p_id int,
								p_paidAmount double)
BEGIN
		UPDATE tblreservation SET paidAmount = p_paidAmount,
						remainingBalance = totalAmount - p_paidAmount
					WHERE id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationSetTotalAmount` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationSetTotalAmount` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationSetTotalAmount`(p_id int,
								p_totalRoomPrice double)
BEGIN
		UPDATE tblreservation SET totalAmount = p_totalAmount,
					remainingBalance = p_totalAmount
					WHERE id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_reservationSetTotalDays` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_reservationSetTotalDays` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_reservationSetTotalDays`(p_id int,
							p_totalDays int)
BEGIN
		update tblreservation set totalDays = p_totalDays
					where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roleData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roleData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roleData`()
BEGIN
		select * from tblrole WHERE ID <> 1;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomActive` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomActive` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomActive`(p_date date)
BEGIN
		SELECT room.roomName
		FROM tblreservation_room rr,
		tblroom room
		WHERE rr.roomID = room.id and p_date BETWEEN checkInDate AND checkOutDate;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomAdd` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomAdd` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomAdd`(p_roomname varchar(20),
						p_roomtype varchar(30),
						p_description varchar(150),
						p_priceperday double)
BEGIN
		insert into tblroom (roomname,
					roomtype,
					description,
					priceperday)
				values (p_roomname,
					p_roomtype,
					p_description,
					p_priceperday);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomAvailable` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomAvailable` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomAvailable`()
BEGIN
		select * from view_room where ROOM_STATUS = "Available";
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomAvailableStatus` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomAvailableStatus` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomAvailableStatus`(p_id int)
BEGIN
		update tblroom set status = "Available"
				where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomCheckAvailability` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomCheckAvailability` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomCheckAvailability`(p_roomID int,
								p_date date)
BEGIN
		SELECT room.roomName,
			CASE 
				WHEN p_date BETWEEN checkInDate AND checkOutDate THEN 'Occupied'
				ELSE 'Available'
			END AS room_status
		FROM tblreservation_room rr,
		tblroom room
		WHERE rr.roomID = room.id AND 
		room.id = 18;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomCheckRoomStatus` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomCheckRoomStatus` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomCheckRoomStatus`(p_date DATETIME)
BEGIN
    -- Mark 'Reserved' for dates before checkInDate
    UPDATE tblreservation_room 
    SET roomStatus = 'Reserved'
    WHERE p_date < checkInDate;

    -- Mark 'Available' for dates after checkOutDate
    UPDATE tblreservation_room 
    SET roomStatus = 'Available'
    WHERE p_date > checkOutDate;

    -- Mark 'Occupied' for dates between checkInDate and checkOutDate
    UPDATE tblreservation_room 
    SET roomStatus = 'Occupied'
    WHERE p_date BETWEEN checkInDate AND checkOutDate;
END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomData`()
BEGIN
		select *
		 from view_room;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomDelete` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomDelete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomDelete`(p_id int)
BEGIN
		delete from tblroom where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomGetByID` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomGetByID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomGetByID`(p_roomID int)
BEGIN
		select * from tblroom where id = p_roomID;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomGetByName` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomGetByName` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomGetByName`(p_roomName varchar(30))
BEGIN
		select * from tblroom where roomName = p_roomName;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomOccupiedStatus` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomOccupiedStatus` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomOccupiedStatus`(p_id int)
BEGIN
		update tblroom set status = "Occupied"
				where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomReservationAdd` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomReservationAdd` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomReservationAdd`(p_reservationID int,
							p_roomID int,
							p_checkIn date,
							p_checkOut date,
							p_totalRoomPrice double)
BEGIN
		insert into tblreservation_room (reservationID,
						roomID,
						checkInDate,
						checkOutDate,
						totalRoomPrice)
					values (p_reservationID,
						p_roomID,
						p_checkIn,
						p_checkOut,
						p_totalRoomPrice);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomReservationData` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomReservationData` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomReservationData`(p_reservationID int)
BEGIN
		select * from view_roomreservations where RID = p_reservationID;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomReservationDelete` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomReservationDelete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomReservationDelete`(p_rrid int)
BEGIN
		delete from tblreservation_room where id = p_rrid;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomReservationUpdate` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomReservationUpdate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomReservationUpdate`(p_id int,
								p_reservationID int,
								p_roomID INT,
								p_checkIn date,
								p_checkOut date,
								p_totalRoomPrice double)
BEGIN
		update tblreservation_room set reservationID = p_reservationID,
						roomID = p_roomID,
						checkInDate = p_checkIn,
						checkOutDate = p_checkOut,
						totalRoomPrice = p_totalRoomPrice
					where id = p_id;
					
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomReserveStatus` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomReserveStatus` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomReserveStatus`(p_id int)
BEGIN
		update tblroom set status = "Reserved"
				where id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomSearch` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomSearch` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomSearch`(p_roomName varchar(100),
						p_roomType varchar(50),
						p_status varchar(20))
BEGIN
		select * from view_room where room_Name LIKE concat(p_roomName, "%")
					and room_Type LIKE CONCAT(p_roomType, "%")
					and room_status LIKE CONCAT(p_status, "%");
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomTypes` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomTypes` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomTypes`()
BEGIN
		select distinct roomType from tblroom;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `proc_roomUpdate` */

/*!50003 DROP PROCEDURE IF EXISTS  `proc_roomUpdate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_roomUpdate`(p_id int,
						p_roomname varchar(20),
						p_roomtype varchar(30),
						p_description varchar(150),
						p_priceperday double)
BEGIN
		update tblroom set roomname = p_roomname,
					roomtype = p_roomtype,
					description = p_description,
					priceperday = p_priceperday
				where id = p_id;
	END */$$
DELIMITER ;

/*Table structure for table `view_account` */

DROP TABLE IF EXISTS `view_account`;

/*!50001 DROP VIEW IF EXISTS `view_account` */;
/*!50001 DROP TABLE IF EXISTS `view_account` */;

/*!50001 CREATE TABLE  `view_account`(
 `ACCOUNTID` int(11) ,
 `FIRST NAME` varchar(50) ,
 `MIDDLE NAME` varchar(50) ,
 `LAST NAME` varchar(50) ,
 `ROLE` varchar(20) ,
 `USERNAME` varchar(50) ,
 `PASSWORD` varchar(100) ,
 `CONTACT NUMBER` varchar(15) ,
 `EMAIL ADDRESS` varchar(40) ,
 `ADDRESS` varchar(100) ,
 `GENDER` varchar(20) ,
 `BIRTHDATE` date ,
 `ACCOUNT CREATED ON` date ,
 `IMAGE` text 
)*/;

/*Table structure for table `view_addonreservations` */

DROP TABLE IF EXISTS `view_addonreservations`;

/*!50001 DROP VIEW IF EXISTS `view_addonreservations` */;
/*!50001 DROP TABLE IF EXISTS `view_addonreservations` */;

/*!50001 CREATE TABLE  `view_addonreservations`(
 `RAID` int(11) ,
 `RID` int(11) ,
 `ADDON NAME` varchar(50) ,
 `DESCRIPTION` varchar(200) ,
 `PRICE` double 
)*/;

/*Table structure for table `view_employee` */

DROP TABLE IF EXISTS `view_employee`;

/*!50001 DROP VIEW IF EXISTS `view_employee` */;
/*!50001 DROP TABLE IF EXISTS `view_employee` */;

/*!50001 CREATE TABLE  `view_employee`(
 `AID` int(11) ,
 `FULLNAME` varchar(152) ,
 `FIRST NAME` varchar(50) ,
 `MIDDLE NAME` varchar(50) ,
 `LAST NAME` varchar(50) ,
 `USERNAME` varchar(50) ,
 `PASSWORD` varchar(100) ,
 `ROLE` varchar(20) ,
 `EMPLOYEE STATUS` varchar(30) ,
 `EMPLOYEE LAST ONLINE` datetime ,
 `WORKSHIFT` varchar(30) ,
 `HOURLY RATE` double ,
 `CONTACT NUMBER` varchar(15) ,
 `EMAIL ADDRESS` varchar(40) ,
 `ADDRESS` varchar(100) ,
 `GENDER` varchar(20) ,
 `BIRTHDATE` date ,
 `EMPLOYMENT DATE` date ,
 `IMAGE` text 
)*/;

/*Table structure for table `view_guest` */

DROP TABLE IF EXISTS `view_guest`;

/*!50001 DROP VIEW IF EXISTS `view_guest` */;
/*!50001 DROP TABLE IF EXISTS `view_guest` */;

/*!50001 CREATE TABLE  `view_guest`(
 `AID` int(11) ,
 `FULLNAME` varchar(152) ,
 `FIRST NAME` varchar(50) ,
 `MIDDLE NAME` varchar(50) ,
 `LAST NAME` varchar(50) ,
 `MEMBERSHIP` varchar(50) ,
 `STATUS` varchar(30) ,
 `USERNAME` varchar(50) ,
 `PASSWORD` varchar(100) ,
 `CONTACT NUMBER` varchar(15) ,
 `EMAIL ADDRESS` varchar(40) ,
 `ADDRESS` varchar(100) ,
 `GENDER` varchar(20) ,
 `BIRTHDATE` date ,
 `ACCOUNT CREATED ON` date ,
 `IMAGE` text 
)*/;

/*Table structure for table `view_reservation` */

DROP TABLE IF EXISTS `view_reservation`;

/*!50001 DROP VIEW IF EXISTS `view_reservation` */;
/*!50001 DROP TABLE IF EXISTS `view_reservation` */;

/*!50001 CREATE TABLE  `view_reservation`(
 `RESERVATION_ID` int(11) ,
 `FULL_NAME` varchar(152) ,
 `FIRST_NAME` varchar(50) ,
 `MIDDLE_NAME` varchar(50) ,
 `LAST_NAME` varchar(50) ,
 `TOTAL ROOMS` bigint(21) ,
 `PROMO NAME` varchar(50) ,
 `TOTAL ADDONS` bigint(21) ,
 `INVOICE` varchar(10) ,
 `RESERVATION STATUS` varchar(20) ,
 `BOOKING DATE` date ,
 `TOTAL DAYS` int(11) ,
 `TOTAL AMOUNT` double ,
 `PAID AMOUNT` double ,
 `REMAINING BALANCE` double ,
 `IMAGE` text 
)*/;

/*Table structure for table `view_room` */

DROP TABLE IF EXISTS `view_room`;

/*!50001 DROP VIEW IF EXISTS `view_room` */;
/*!50001 DROP TABLE IF EXISTS `view_room` */;

/*!50001 CREATE TABLE  `view_room`(
 `ROOM_ID` int(11) ,
 `ROOM_NAME` varchar(20) ,
 `ROOM_TYPE` varchar(30) ,
 `PRICE_PER_DAY` double ,
 `ROOM_STATUS` varchar(30) 
)*/;

/*Table structure for table `view_roomreservations` */

DROP TABLE IF EXISTS `view_roomreservations`;

/*!50001 DROP VIEW IF EXISTS `view_roomreservations` */;
/*!50001 DROP TABLE IF EXISTS `view_roomreservations` */;

/*!50001 CREATE TABLE  `view_roomreservations`(
 `RRID` int(11) ,
 `RID` int(11) ,
 `ROOM_ID` int(11) ,
 `ROOM_NAME` varchar(20) ,
 `ROOM_TYPE` varchar(30) ,
 `PRICE_PER_DAY` double ,
 `TOTAL_PRICE` double ,
 `ROOM_STATUS` varchar(30) ,
 `CHECK-IN_DATE` date ,
 `CHECK-OUT_DATE` date 
)*/;

/*View structure for view view_account */

/*!50001 DROP TABLE IF EXISTS `view_account` */;
/*!50001 DROP VIEW IF EXISTS `view_account` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_account` AS select `acc`.`id` AS `ACCOUNTID`,`pro`.`firstName` AS `FIRST NAME`,`pro`.`middleName` AS `MIDDLE NAME`,`pro`.`lastName` AS `LAST NAME`,`role`.`roleName` AS `ROLE`,`acc`.`username` AS `USERNAME`,`acc`.`password` AS `PASSWORD`,`pro`.`contactNo` AS `CONTACT NUMBER`,`pro`.`emailAddress` AS `EMAIL ADDRESS`,`pro`.`address` AS `ADDRESS`,`pro`.`gender` AS `GENDER`,`pro`.`birthdate` AS `BIRTHDATE`,`acc`.`dateCreated` AS `ACCOUNT CREATED ON`,`pro`.`image` AS `IMAGE` from ((`tblaccount` `acc` join `tblprofile` `pro`) join `tblrole` `role`) where `acc`.`profileID` = `pro`.`id` and `acc`.`roleID` = `role`.`id` */;

/*View structure for view view_addonreservations */

/*!50001 DROP TABLE IF EXISTS `view_addonreservations` */;
/*!50001 DROP VIEW IF EXISTS `view_addonreservations` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_addonreservations` AS (select `ra`.`id` AS `RAID`,`ra`.`reservationID` AS `RID`,`add`.`addonName` AS `ADDON NAME`,`add`.`description` AS `DESCRIPTION`,`add`.`price` AS `PRICE` from ((`tblreservation` `res` join `tbladdons` `add`) join `tblreservation_addons` `ra`) where `res`.`id` = `ra`.`reservationID` and `add`.`id` = `ra`.`addonsID`) */;

/*View structure for view view_employee */

/*!50001 DROP TABLE IF EXISTS `view_employee` */;
/*!50001 DROP VIEW IF EXISTS `view_employee` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_employee` AS select `acc`.`id` AS `AID`,concat(`pro`.`firstName`,' ',`pro`.`middleName`,' ',`pro`.`lastName`) AS `FULLNAME`,`pro`.`firstName` AS `FIRST NAME`,`pro`.`middleName` AS `MIDDLE NAME`,`pro`.`lastName` AS `LAST NAME`,`acc`.`username` AS `USERNAME`,`acc`.`password` AS `PASSWORD`,`role`.`roleName` AS `ROLE`,`emp`.`status` AS `EMPLOYEE STATUS`,`emp`.`lastLogin` AS `EMPLOYEE LAST ONLINE`,`emp`.`workShift` AS `WORKSHIFT`,`emp`.`salaryPerHour` AS `HOURLY RATE`,`pro`.`contactNo` AS `CONTACT NUMBER`,`pro`.`emailAddress` AS `EMAIL ADDRESS`,`pro`.`address` AS `ADDRESS`,`pro`.`gender` AS `GENDER`,`pro`.`birthdate` AS `BIRTHDATE`,`emp`.`employmentDate` AS `EMPLOYMENT DATE`,`pro`.`image` AS `IMAGE` from (((`tblprofile` `pro` join `tblaccount` `acc`) join `tblemployee` `emp`) join `tblrole` `role`) where `pro`.`id` = `acc`.`profileID` and `role`.`id` = `acc`.`roleID` and `acc`.`id` = `emp`.`accountID` */;

/*View structure for view view_guest */

/*!50001 DROP TABLE IF EXISTS `view_guest` */;
/*!50001 DROP VIEW IF EXISTS `view_guest` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_guest` AS select `acc`.`id` AS `AID`,concat(`pro`.`firstName`,' ',`pro`.`middleName`,' ',`pro`.`lastName`) AS `FULLNAME`,`pro`.`firstName` AS `FIRST NAME`,`pro`.`middleName` AS `MIDDLE NAME`,`pro`.`lastName` AS `LAST NAME`,`mem`.`membershipStatus` AS `MEMBERSHIP`,`am`.`accountStatus` AS `STATUS`,`acc`.`username` AS `USERNAME`,`acc`.`password` AS `PASSWORD`,`pro`.`contactNo` AS `CONTACT NUMBER`,`pro`.`emailAddress` AS `EMAIL ADDRESS`,`pro`.`address` AS `ADDRESS`,`pro`.`gender` AS `GENDER`,`pro`.`birthdate` AS `BIRTHDATE`,`acc`.`dateCreated` AS `ACCOUNT CREATED ON`,`pro`.`image` AS `IMAGE` from ((((`tblaccount` `acc` join `tblprofile` `pro`) join `tblmembership` `mem`) join `tblaccount_membership` `am`) join `tblrole` `role`) where `acc`.`id` = `am`.`accountID` and `acc`.`profileID` = `pro`.`id` and `acc`.`roleID` = `role`.`id` and `mem`.`id` = `am`.`membershipID` */;

/*View structure for view view_reservation */

/*!50001 DROP TABLE IF EXISTS `view_reservation` */;
/*!50001 DROP VIEW IF EXISTS `view_reservation` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_reservation` AS select `res`.`id` AS `RESERVATION_ID`,concat(`pro`.`firstName`,' ',`pro`.`middleName`,' ',`pro`.`lastName`) AS `FULL_NAME`,`pro`.`firstName` AS `FIRST_NAME`,`pro`.`middleName` AS `MIDDLE_NAME`,`pro`.`lastName` AS `LAST_NAME`,coalesce(`rooms`.`total_rooms`,0) AS `TOTAL ROOMS`,`promo`.`promoName` AS `PROMO NAME`,coalesce(`addons`.`total_addons`,0) AS `TOTAL ADDONS`,`res`.`invoice` AS `INVOICE`,`res`.`reservationStatus` AS `RESERVATION STATUS`,`res`.`bookingDate` AS `BOOKING DATE`,`res`.`totalDays` AS `TOTAL DAYS`,`res`.`totalAmount` AS `TOTAL AMOUNT`,`res`.`paidAmount` AS `PAID AMOUNT`,`res`.`remainingBalance` AS `REMAINING BALANCE`,`pro`.`image` AS `IMAGE` from (((((`tblreservation` `res` join `tblaccount` `acc` on(`acc`.`id` = `res`.`accountID`)) join `tblprofile` `pro` on(`pro`.`id` = `acc`.`profileID`)) join `tblpromo` `promo` on(`promo`.`id` = `res`.`promoID`)) left join (select `tblreservation_room`.`reservationID` AS `reservationID`,count(`tblreservation_room`.`roomID`) AS `total_rooms` from `tblreservation_room` group by `tblreservation_room`.`reservationID`) `rooms` on(`res`.`id` = `rooms`.`reservationID`)) left join (select `tblreservation_addons`.`reservationID` AS `reservationID`,count(`tblreservation_addons`.`addonsID`) AS `total_addons` from `tblreservation_addons` group by `tblreservation_addons`.`reservationID`) `addons` on(`res`.`id` = `addons`.`reservationID`)) group by `res`.`id` */;

/*View structure for view view_room */

/*!50001 DROP TABLE IF EXISTS `view_room` */;
/*!50001 DROP VIEW IF EXISTS `view_room` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_room` AS (select `room`.`id` AS `ROOM_ID`,`room`.`roomName` AS `ROOM_NAME`,`room`.`roomType` AS `ROOM_TYPE`,`room`.`pricePerDay` AS `PRICE_PER_DAY`,ifnull(`rr`.`roomStatus`,'Available') AS `ROOM_STATUS` from (`tblroom` `room` left join `tblreservation_room` `rr` on(`room`.`id` = `rr`.`roomID`)) order by `room`.`roomName`) */;

/*View structure for view view_roomreservations */

/*!50001 DROP TABLE IF EXISTS `view_roomreservations` */;
/*!50001 DROP VIEW IF EXISTS `view_roomreservations` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_roomreservations` AS (select `rr`.`id` AS `RRID`,`rr`.`reservationID` AS `RID`,`room`.`id` AS `ROOM_ID`,`room`.`roomName` AS `ROOM_NAME`,`room`.`roomType` AS `ROOM_TYPE`,`room`.`pricePerDay` AS `PRICE_PER_DAY`,`rr`.`totalRoomPrice` AS `TOTAL_PRICE`,`rr`.`roomStatus` AS `ROOM_STATUS`,`rr`.`checkInDate` AS `CHECK-IN_DATE`,`rr`.`checkOutDate` AS `CHECK-OUT_DATE` from ((`tblreservation` `res` join `tblroom` `room`) join `tblreservation_room` `rr`) where `res`.`id` = `rr`.`reservationID` and `room`.`id` = `rr`.`roomID`) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
