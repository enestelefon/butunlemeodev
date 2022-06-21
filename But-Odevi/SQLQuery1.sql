/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Arac_Markasi]
      ,[Arac_Modeli]
      ,[Arac_Sase_No]
      ,[Arac_Uretim_Yili]
      ,[Aracin_Fiyati]
  FROM [liste].[dbo].[Table]

INSERT INTO [liste].[dbo].[Table](Arac_Markasi, Arac_Modeli, Arac_Sase_No, Arac_Uretim_Yili, Aracin_Fiyati) VALUES ('WMB', '63E', 123, 2012, 20000);