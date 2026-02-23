ER Diagram 

```mermaid  
flowchart TB

Maintenance[Maintenance] --> |n,m|applies{applies} 
applies{applies} --> |1,1|Vehicle[Vehicle]

Employee[Employee] --> |n,m|performs{performs} 
performs{performs} --> |n,m|Assignment[Assignment]

Vehicle[Vehicle] --> |n,m|isAssignedTo{isAssignedTo}
isAssignedTo{isAssignedTo} --> |n,m|Assignment[Assignment]

Employee[Employee] --> |n,m|operates{operates} 
operates{operates} --> |n,m|Vehicle[Vehicle]

Vehicle[Vehicle] <--> VehicleID("<u>VehicleID</u>")
Vehicle[Vehicle] <--> NumberPlate([NumberPlate])

Vehicle[Vehicle] <--> Status([Status])
Vehicle[Vehicle] <--> V.Type([V.Type])
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
Assignment[Assignment] <--> City(City)
style City stroke-dasharray: 2


Maintenance[Maintenance] <--> Date([Date])
Maintenance[Maintenance] <--> M.Type([M.Type])
Maintenance[Maintenance] <--> MaintenanceID("<u>MaintenanceID</u>")




