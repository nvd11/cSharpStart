use compass;

DROP procedure IF EXISTS `proc_1`;

DELIMITER 

CREATE PROCEDURE `proc_1` ()
BEGIN
	if exists(select 1 from INFORMATION_SCHEMA.TABLES where table_schema='compass' and table_name ='tClient') then
		select 1 from tClient;
	end if;
END

