/*
Navicat MySQL Data Transfer

Source Server         : HomeServer
Source Server Version : 50637
Source Host           : 192.168.1.1:3306
Source Database       : gym

Target Server Type    : MYSQL
Target Server Version : 50637
File Encoding         : 65001

Date: 2017-12-16 17:32:38
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for customers
-- ----------------------------
DROP TABLE IF EXISTS `customers`;
CREATE TABLE `customers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `surname` varchar(255) DEFAULT NULL,
  `conact` varchar(255) DEFAULT NULL,
  `gender` varchar(255) DEFAULT NULL,
  `workout` varchar(255) DEFAULT NULL,
  `height` double DEFAULT NULL,
  `weight` double DEFAULT NULL,
  `package` varchar(255) DEFAULT NULL,
  `health_problems` varchar(255) DEFAULT NULL,
  `previous_activity` varchar(255) DEFAULT NULL,
  `photo` varchar(255) DEFAULT NULL,
  `notes` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of customers
-- ----------------------------

-- ----------------------------
-- Table structure for payments
-- ----------------------------
DROP TABLE IF EXISTS `payments`;
CREATE TABLE `payments` (
  `id` int(11) NOT NULL,
  `subscription_id` int(11) DEFAULT NULL,
  `cost` double(3,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `subscriptions` (`subscription_id`),
  CONSTRAINT `subscriptions` FOREIGN KEY (`subscription_id`) REFERENCES `subscriptions` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of payments
-- ----------------------------

-- ----------------------------
-- Table structure for subscriptions
-- ----------------------------
DROP TABLE IF EXISTS `subscriptions`;
CREATE TABLE `subscriptions` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) NOT NULL,
  `start_date` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `end_date` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `customer` (`customer_id`),
  CONSTRAINT `customer` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of subscriptions
-- ----------------------------
