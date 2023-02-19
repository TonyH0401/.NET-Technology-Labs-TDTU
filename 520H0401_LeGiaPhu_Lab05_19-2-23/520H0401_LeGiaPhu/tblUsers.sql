CREATE TABLE [tblUsers](
	[UserID] [nchar](10) primary key NOT NULL,
	[UserName] [nchar](50) NULL,
	[Password] [nchar](15) NULL,
	[IsActive] [bit] NULL,
	[CreateDate] [datetime] NULL,
)
GO

Insert Into [tblUsers](UserID,UserName,Password,IsActive,CreateDate) VALUES ('User01','Trung Pham','123',1,'2022-01-01')
Insert Into [tblUsers](UserID,UserName,Password,IsActive,CreateDate) VALUES ('User02','Trung Thai','321',1,'2022-02-02')

select * from tblUsers