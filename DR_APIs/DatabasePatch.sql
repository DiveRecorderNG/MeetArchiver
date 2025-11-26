USE divereco_diverecorder;

ALTER TABLE `divereco_diverecorder`.`ME_Divers` 
CHANGE COLUMN `DRef` `DRef` INT NOT NULL AUTO_INCREMENT ,
ADD UNIQUE INDEX `DRef_UNIQUE` (`DRef` ASC),
ADD INDEX `FirstName` USING BTREE (`FirstName`),
ADD INDEX `LastName`USING BTREE  (`LastName`),
ADD INDEX `Representing` USING BTREE (`Representing`),
ADD INDEX `Sex` USING BTREE  (`Sex`),
ADD INDEX `TCode` USING BTREE (`TCode`),
ADD INDEX `Born` USING BTREE (`Born`);


ALTER TABLE `divereco_diverecorder`.`ME_Divers` 
CHANGE COLUMN `DRef` `DRef` INT NOT NULL AUTO_INCREMENT;


ALTER TABLE `divereco_diverecorder`.`ME_Divers` 
ADD COLUMN `InsertDT` DATETIME NULL;
ALTER TABLE `divereco_diverecorder`.`ME_Divers` 
ADD INDEX `inserttime` USING BTREE (`InsertDT`);


ALTER TABLE `divereco_diverecorder`.`ME_Meets` 
ADD COLUMN `MeetGUID` VARCHAR(45) NULL,
ADD COLUMN `owner` INT NOT NULL;

ALTER TABLE `divereco_diverecorder`.`ME_Meets` 
CHANGE COLUMN `MRef` `MRef` INT NOT NULL AUTO_INCREMENT ;

ALTER TABLE `divereco_diverecorder`.`ME_Events` 
ADD INDEX `meetref` USING BTREE (`MeetRef`),
ADD INDEX `eventref` USING BTREE (`ERef`);


ALTER TABLE `divereco_diverecorder`.`ME_Meets` 
ADD INDEX `meetref` USING BTREE (`MRef`);


CREATE TABLE `divereco_diverecorder`.`meetmanagers` (
  `pk` INT NOT NULL AUTO_INCREMENT,
  `APIKey` VARCHAR(128) NOT NULL,
  `UserEmail` VARCHAR(100) NOT NULL,
  `Role` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`pk`),
  UNIQUE INDEX `pk_UNIQUE` USING BTREE (`pk`),
  UNIQUE INDEX `APIKey_UNIQUE` USING BTREE (`APIKey`));