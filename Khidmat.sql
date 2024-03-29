CREATE TABLE [patientInfo] (
	patientMR varchar(255) NOT NULL,
	patientName varchar(255) NOT NULL,
	sex varchar(255) NOT NULL,
	age integer NOT NULL,
	history varchar(255),
	contact varchar(MAX),
	occupation varchar(255),
	address varchar(255),
  CONSTRAINT [PK_PATIENTINFO] PRIMARY KEY CLUSTERED
  (
  [patientMR] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [operativeProcedurePatient] (
	oppID varchar(255) NOT NULL,
	patientMR varchar(255) NOT NULL,
	procedureID varchar(255) NOT NULL,
	diagnosisID varchar(255),
	doctorID varchar(255) NOT NULL,
	doctorComments varchar(MAX),
	assistant varchar(255),
	anaesthetist varchar(255),
	anesthesiaType varchar(255),
	dateOfAdmission date NOT NULL,
	dateOfDischarge date,
	wardNumber varchar(MAX),
	roomNumber varchar(MAX),
	bedNumber varchar(MAX),
  CONSTRAINT [PK_OPERATIVEPROCEDUREPATIENT] PRIMARY KEY CLUSTERED
  (
  [oppID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [operativeProcedure] (
	procedureID varchar(255) NOT NULL,
	operationName varchar(255) NOT NULL,
	subProcedure varchar(255),
	description varchar(MAX),
  CONSTRAINT [PK_OPERATIVEPROCEDURE] PRIMARY KEY CLUSTERED
  (
  [procedureID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [diagnosis] (
	diagnosisID varchar(255) NOT NULL,
	diagnosisName varchar(255) NOT NULL,
	description varchar(255),
  CONSTRAINT [PK_DIAGNOSIS] PRIMARY KEY CLUSTERED
  (
  [diagnosisID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [followUps] (
	followUpID varchar(255) NOT NULL,
	oppID varchar(255) NOT NULL,
	followUpDate date,
  CONSTRAINT [PK_FOLLOWUPS] PRIMARY KEY CLUSTERED
  (
  [followUpID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [operativeProcedureImages] (
	imagesID varchar(255) NOT NULL,
	patientMR varchar(255) NOT NULL,
	procedureID varchar(255) NOT NULL,
	image1 image,
  CONSTRAINT [PK_OPERATIVEPROCEDUREIMAGES] PRIMARY KEY CLUSTERED
  (
  [imagesID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [doctor] (
	doctorID varchar(255) NOT NULL,
	doctorName varchar(255) NOT NULL,
	sex varchar(255) NOT NULL,
	specialization varchar(255) NOT NULL,
  CONSTRAINT [PK_DOCTOR] PRIMARY KEY CLUSTERED
  (
  [doctorID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [operativeProcedurePatient] WITH CHECK ADD CONSTRAINT [operativeProcedurePatient_fk0] FOREIGN KEY ([patientMR]) REFERENCES [patientInfo]([patientMR])
ON UPDATE CASCADE
GO
ALTER TABLE [operativeProcedurePatient] CHECK CONSTRAINT [operativeProcedurePatient_fk0]
GO
ALTER TABLE [operativeProcedurePatient] WITH CHECK ADD CONSTRAINT [operativeProcedurePatient_fk1] FOREIGN KEY ([procedureID]) REFERENCES [operativeProcedure]([procedureID])
ON UPDATE CASCADE
GO
ALTER TABLE [operativeProcedurePatient] CHECK CONSTRAINT [operativeProcedurePatient_fk1]
GO
ALTER TABLE [operativeProcedurePatient] WITH CHECK ADD CONSTRAINT [operativeProcedurePatient_fk2] FOREIGN KEY ([diagnosisID]) REFERENCES [diagnosis]([diagnosisID])
ON UPDATE CASCADE
GO
ALTER TABLE [operativeProcedurePatient] CHECK CONSTRAINT [operativeProcedurePatient_fk2]
GO
ALTER TABLE [operativeProcedurePatient] WITH CHECK ADD CONSTRAINT [operativeProcedurePatient_fk3] FOREIGN KEY ([doctorID]) REFERENCES [doctor]([doctorID])
ON UPDATE CASCADE
GO
ALTER TABLE [operativeProcedurePatient] CHECK CONSTRAINT [operativeProcedurePatient_fk3]
GO



ALTER TABLE [followUps] WITH CHECK ADD CONSTRAINT [followUps_fk0] FOREIGN KEY ([oppID]) REFERENCES [operativeProcedurePatient]([oppID])
ON UPDATE CASCADE
GO
ALTER TABLE [followUps] CHECK CONSTRAINT [followUps_fk0]
GO

ALTER TABLE [operativeProcedureImages] WITH CHECK ADD CONSTRAINT [operativeProcedureImages_fk0] FOREIGN KEY ([patientMR]) REFERENCES [patientInfo]([patientMR])
ON UPDATE CASCADE
GO
ALTER TABLE [operativeProcedureImages] CHECK CONSTRAINT [operativeProcedureImages_fk0]
GO
ALTER TABLE [operativeProcedureImages] WITH CHECK ADD CONSTRAINT [operativeProcedureImages_fk1] FOREIGN KEY ([procedureID]) REFERENCES [operativeProcedure]([procedureID])
ON UPDATE CASCADE
GO
ALTER TABLE [operativeProcedureImages] CHECK CONSTRAINT [operativeProcedureImages_fk1]
GO

Alter table operativeProcedurePatient
Add outcome varchar(255), 
formtype varchar(255) not null


