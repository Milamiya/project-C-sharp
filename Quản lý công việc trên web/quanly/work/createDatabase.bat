
rem === change root folder ===
cd\

rem === change drive 'c' ===
c:

rem === change directory ===
cd mysql\bin

rem === create database 'CongViec' ===
mysql < c:\jakarta-tomcat\webapps\work\database\database.sql

rem === insert data into tables ===
mysql < c:\jakarta-tomcat\webapps\work\database\data.txt

rem === end of file ===