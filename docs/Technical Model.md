Relation Model


```mermaid
erDiagram  
Employee {  
EmployeeId int PK
E_Status varchar()
Name varchar()
Role varchar()
PhoneNr varchar()  
}  
  
Vehicle {  
VehicleId int PK  
NumberPlate varchar  
V_Status varchar()
NextServiceDate date
NextInspectionDate date  
}

Assignment {
AssignmentId int
StartDate date
EndDate date
StreetName varchar()
HouseNumber varchar
PostalCode 
}



```




