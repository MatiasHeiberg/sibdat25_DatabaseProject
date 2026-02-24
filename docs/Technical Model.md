Relation Model

```mermaid
erDiagram  

Employee{
INT employee_id PRIMARY KEY IDENTITY(1,1) 
VARCHAR(30) surname NOT NULL
VARCHAR(30) first_name NOT NULL

VARCHAR(20) role 
VARCHAR(20) phone_number UNIQUE
BIT employee_is_active NOT NULL DEFAULT 1
}

Vehicle{
INT vehicle_id PRIMARY KEY IDENTITY(1,1)
VARCHAR(30) number_plate UNIQUE
BIT vehicle_is_active NOT NULL DEFAULT 1
VARCHAR(30) vehicle_type 
DATE next_service_date
DATE next_inspection_date
}

Assignment{
INT assignment_id PRIMARY KEY IDENTITY(1,1)
VARCHAR(100) street_name 
VARCHAR(10) house_number
VARCHAR(10) postal_code
}

Maintenance{
INT maintenance_id PRIMARY KEY IDENTITY(1,1)
DATE maintenance_date NOT NULL
VARCHAR(30) maintenance_type 
INT vehicle_id FOREIGN KEY
}

Activity{
INT activity_id PRIMARY KEY IDENTITY(1,1)
DATE start_date 
DATE end_date
INT employee_id FOREIGN KEY
INT assignment_id FOREIGN KEY
INT vehicle_id FOREIGN KEY
}





```




