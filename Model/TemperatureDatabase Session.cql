CREATE KEYSPACE TemperatureDatabase
    WITH REPLICATION = { 
        'class' : 'SimpleStrategy', 
        'replication_factor' : 1 
    };

USE TemperatureDatabase;

CREATE TABLE Temperature(
  IdTemperature INT,
  TemperatureData FLOAT,
  Time TIMESTAMP,
  PRIMARY KEY(IdTemperature)
);

SELECT
  *
FROM Temperature;
-- DROP Table Temperature;