# TBS_Sales_Suit_App

Twinkle Book Store Sales Suit Application

# Description

Twinkle Book Store (TBS) Application is a bookstore sales software. TBS is a very historical bookstore with large loyal customer base. The average annual sales per customer is greater than Fifteen thousand rupees annually. The purpose of developing this Application, “TBS Sales Suit” is to serve customers efficiently.

# Pre-requisites

1.	MS SQL Server and Management Studio
2.	.NET Framework 4.7.1

# System Requirements

1.	Operating System: Windows 7 SP1, Windows 8.1, Windows 10, Windows Server 2008 R2 SP1, Windows Server 2012 R2, Windows Server 2016
2.	Hardware: 1GHz or above processor, 512 MB or above RAM, 5 GB or more free Hard disk space.

# Installation

1.	To run the Application, make sure MS SQL Server and Management Studio is installed on the target machine.

2.	To build the Application in Visual Studio, install following NuGet packages:
•	Entity Framework (v6)
•	iTextSharp (v5)
•	Microsoft Office Interop Excel (v15)

3.	Modify the connectionString named “TBSDbContext” in the TBS_Sales_Suit_App.exe.config file with the valid connection string of the target machine SQL server connection.

NOTE: An empty database gets created automatically when the Application is first launched. The Application will take some to load the very first time as it creates the database first. As a first step make sure to Import data using Excel or CSV format to get sample data.

4.	Make sure the below mentioned Input files are in the same folder as the exe:
TwinkleBookStoreExcelData.xlsx
TwinkleBookStore_CustomersCsv.csv
TwinkleBookStore_BooksCsv.csv
TwinkleBookStore_PurchasehistoryCsv.csv

 
