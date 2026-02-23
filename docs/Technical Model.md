Relation Model


```mermaid
erDiagram  
EMPLOYEE {  
EmployeeId int PK
E_Status varchar()
Name varchar()
Role varchar()
PhoneNr varchar()  
}  
  
VEHICLE {  
VehicleId int PK  
NumberPlate varchar  
V_Status varchar()
NextServiceDate date
NextInspectionDate date  
}

ASSIGNMENT {
AssignmentId int
StartDate date
EndDate date
StreetName 
HouseNr 


}



