CREATE TABLE Operative_Procedure (
  Procedure_ID INTEGER  NOT NULL   IDENTITY ,
  Procedure_Name VARCHAR      ,
PRIMARY KEY(Procedure_ID));
GO




CREATE TABLE Doctor (
  DoctorID VARCHAR  NOT NULL   IDENTITY ,
  LoginPassword VARCHAR      ,
PRIMARY KEY(DoctorID));
GO




CREATE TABLE Pateint (
  Pateint_ID INTEGER  NOT NULL   IDENTITY ,
  Doctor_DoctorID VARCHAR  NOT NULL  ,
  MR_Number VARCHAR    ,
  Patient_Name VARCHAR    ,
  Age VARCHAR    ,
  Sex VARCHAR      ,
PRIMARY KEY(Pateint_ID, Doctor_DoctorID)  ,
  FOREIGN KEY(Doctor_DoctorID)
    REFERENCES Doctor(DoctorID));
GO


CREATE INDEX Pateint_FKIndex1 ON Pateint (Doctor_DoctorID);
GO


CREATE INDEX IFK_Rel_02 ON Pateint (Doctor_DoctorID);
GO


CREATE TABLE Record (
  Record_ID VARCHAR  NOT NULL   IDENTITY ,
  Pateint_ID INTEGER  NOT NULL  ,
  Pateint_Doctor_DoctorID VARCHAR  NOT NULL  ,
  Operative_Procedure_Procedure_ID INTEGER  NOT NULL  ,
  DOA DATE    ,
  DOD DATE    ,
  Brief_History VARCHAR    ,
  Investigations VARCHAR    ,
  Diagnosis VARCHAR    ,
  Pics_OperativeProcedure BLOB    ,
  Date_Procedure DATE    ,
  Complications VARCHAR    ,
  FollowUp VARCHAR      ,
PRIMARY KEY(Record_ID, Pateint_ID, Pateint_Doctor_DoctorID, Operative_Procedure_Procedure_ID)    ,
  FOREIGN KEY(Pateint_ID, Pateint_Doctor_DoctorID)
    REFERENCES Pateint(Pateint_ID, Doctor_DoctorID),
  FOREIGN KEY(Operative_Procedure_Procedure_ID)
    REFERENCES Operative_Procedure(Procedure_ID));
GO


CREATE INDEX Record_FKIndex1 ON Record (Pateint_ID, Pateint_Doctor_DoctorID);
GO
CREATE INDEX Record_FKIndex2 ON Record (Operative_Procedure_Procedure_ID);
GO


CREATE INDEX IFK_Rel_03 ON Record (Pateint_ID, Pateint_Doctor_DoctorID);
GO
CREATE INDEX IFK_Rel_05 ON Record (Operative_Procedure_Procedure_ID);
GO



