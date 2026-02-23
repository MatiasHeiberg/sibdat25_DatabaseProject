ER Diagram 

```mermaid  
flowchart TB

Maintenance[Maintenance] --> |0,n|applies{applies} 
applies{applies} --> |1,1|Vehicle[Vehicle]

Employee[Employee] --> performs{performs} 
performs{performs} --> Assignment[Assignment]

Vehicle[Vehicle] --> |0,n|isAssignedTo{isAssignedTo}
isAssignedTo{isAssignedTo} --> |0,n|Assignment[Assignment]

Employee[Employee] --> operates{operates} 
operates{operates} --> Type[Type]

Vehicle[Vehicle] --> isOfType{isOfType} 
isOfType{isOfType} --> Type[Type]

Vehicle[Vehicle] <--> VehicleID("<u>VehicleID</u>")
Vehicle[Vehicle] <--> NumberPlate([NumberPlate])

Vehicle[Vehicle] <--> Status([Status])
Vehicle[Vehicle] <--> NextServiceDate([NextServiceDate])
Vehicle[Vehicle] <--> NextInspectionDate([NextInspectionDate])

Employee[Employee] --> ID("<u>EmployeeID</u>")
Employee[Employee] <--> Surname([Surname])
Employee[Employee] <--> FirstName([FirstName])
Employee[Employee] <--> Role([Role])
Employee[Employee] <--> PhoneNR([PhoneNR]) 
Employee[Employee] <--> E.Status([E.Status]) 

Assignment[Assignment] <--> AssignmentID("<u>AssignmentID</u>") 
Assignment[Assignment] <--> StartDate([StartDate])
Assignment[Assignment] <--> EndDate([EndDate])


Assignment[Assignment] <--> StreetName([StreetName])
Assignment[Assignment] <--> HouseNR([HouseNR])
Assignment[Assignment] <--> PostalCode([PostalCode])
Assignment[Assignment] <--> City([City])


Maintenance[Maintenance] <--> Date([Date])
Maintenance[Maintenance] <--> M.Type([M.Type])
Maintenance[Maintenance] <--> MaintenanceID("<u>MaintenanceID</u>")
Type[Type] <--> Model([Model])
Type[Type] <--> Category([Category])
Type[Type] --> TypeID("<u>TypeID</u>")



Employee[Employee] --> ID("<u>EmployeeID</u>")