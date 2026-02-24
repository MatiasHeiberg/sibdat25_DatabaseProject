ER Diagram  

```mermaid  
flowchart TB

Maintenance[Maintenance] --- |1,1|Applies{Applies} 
Applies{Applies} --- |0,n|Vehicle[Vehicle]

Employee[Employee] --- |0,n|Performs{Performs} 
Performs{Performs} --- |1,n|Assignment[Assignment]

Vehicle[Vehicle] --- |0,n|IsAssignedTo{IsAssignedTo}
IsAssignedTo{IsAssignedTo} --- |1,n|Assignment[Assignment]

Employee[Employee] --- |0,n|Operates{Operates} 
Operates{Operates} --- |0,n|Vehicle[Vehicle]

Vehicle[Vehicle] --- vehicle_id("<u>vehicle_id : Int</u>")
Vehicle[Vehicle] --- number_plate([number_plate : String])

Vehicle[Vehicle] --- vehicle_status([vehicle_status : String])
Vehicle[Vehicle] --- vehicle_type([vehicle_type : String])
Vehicle[Vehicle] --- next_service_date([next_service_date : Date])
Vehicle[Vehicle] --- nextInspectionDate([nextInspectionDate : Date])

Employee[Employee] --- employee_id("<u>employee_id : Int</u>")
Employee[Employee] --- name([name : String])
name([name : String]) --- surname([surname : String])
name([name : String]) --- first_name([first_name : String])
Employee[Employee] --- role([role : String])
Employee[Employee] --- phone_number([phone_number : String]) 
Employee[Employee] --- employee_status([employee_status : String]) 

Assignment[Assignment] --- assignment_id("<u>assignment_id : Int</u>") 
Assignment[Assignment] --- start_date([start_date : Date])
Assignment[Assignment] --- end_date([end_date : Date])

Assignment[Assignment] --- address([address : String])
address([address]) --- street_name([street_name : String])
address([address]) --- house_number([house_number : String])
address([address]) --- postal_code([postal_code : String])
address([address]) --- city(city : String)
style city stroke-dasharray: 5 5

Maintenance[Maintenance] --- maintenance_date([maintenance_date : Date])
Maintenance[Maintenance] --- maintenance_type([maintenance_type : String])
Maintenance[Maintenance] --- maintenance_id("<u>maintenance_id : Int</u>")

```












































