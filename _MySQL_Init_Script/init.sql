CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
                                                       `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
                                                       `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
                                                       CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `GeomShape_Drawing` (
                                     `Id` char(36) COLLATE ascii_general_ci NOT NULL,
                                     `Name` longtext CHARACTER SET utf8mb4 NULL,
                                     `Description` longtext CHARACTER SET utf8mb4 NULL,
                                     CONSTRAINT `PK_Drawing` PRIMARY KEY (`Id`)
) CHARACTER SET utf8mb4;

CREATE TABLE `GeomShape_Shape` (
                                   `Id` char(36) COLLATE ascii_general_ci NOT NULL,
                                   `DrawingId` char(36) COLLATE ascii_general_ci NOT NULL,
                                   `OffsetX` double NOT NULL,
                                   `OffsetY` double NOT NULL,
                                   CONSTRAINT `PK_Shape` PRIMARY KEY (`Id`),
                                   CONSTRAINT `FK_Shape_Drawing_DrawingId` FOREIGN KEY (`DrawingId`) REFERENCES `GeomShape_Drawing` (`Id`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;

CREATE TABLE `GeomShape_Circle` (
                                    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
                                    `Radius` float NOT NULL,
                                    CONSTRAINT `PK_Circle` PRIMARY KEY (`Id`),
                                    CONSTRAINT `FK_Circle_Shape_Id` FOREIGN KEY (`Id`) REFERENCES `GeomShape_Shape` (`Id`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;

CREATE TABLE `GeomShape_Rectangle` (
                                       `Id` char(36) COLLATE ascii_general_ci NOT NULL,
                                       `LengthA` float NOT NULL,
                                       `LengthB` float NOT NULL,
                                       CONSTRAINT `PK_Rectangle` PRIMARY KEY (`Id`),
                                       CONSTRAINT `FK_Rectangle_Shape_Id` FOREIGN KEY (`Id`) REFERENCES `GeomShape_Shape` (`Id`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;

CREATE TABLE `GeomShape_Triangle` (
                                      `Id` char(36) COLLATE ascii_general_ci NOT NULL,
                                      `LengthA` float NOT NULL,
                                      `LengthB` float NOT NULL,
                                      `LengthC` float NOT NULL,
                                      CONSTRAINT `PK_Triangle` PRIMARY KEY (`Id`),
                                      CONSTRAINT `FK_Triangle_Shape_Id` FOREIGN KEY (`Id`) REFERENCES `GeomShape_Shape` (`Id`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;

CREATE INDEX `IX_Shape_DrawingId` ON `GeomShape_Shape` (`DrawingId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210914100813_InitialMigration', '5.0.9');

COMMIT;
