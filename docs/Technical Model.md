Relation Model


```mermaid
erDiagram  

Employee{
INT employee_id PRIMARY KEY IDENTITY
VARCHAR(30) surname NOT NULL
VARCHAR(30) first_name NOT NULL

VARCHAR(20) role
VARCHAR(20) phone_number
VARCHAR(30) employee_status
}

Vehicle{
INT vehicle_id PRIMARY KEY IDENTITY
VARCHAR(30) number_plate UNIQUE
VARCHAR(30) vehicle_status
VARCHAR(30) vehicle_type
DATE next_service_date
DATE next_inspection_date
}

Assignment{
INT assignment_id PK
DATE start_date
DATE end_date
VARCHAR(100) street_name
VARCHAR(10) house_number
VARCHAR(10) postal_code
}

Maintenance{
INT maintenance_id PK
DATE maintenance_date
VARCHAR(30) maintenance_type
INT vehicle_id FK 
}

Assignment_Performance{
INT employee_id PK, FK
INT assignment_id PK, FK
}

Vehicle_Assignment{
INT vehicle_id PK, FK
INT assignment_id PK, FK
}

Employee_Operation{
INT employee_id PK, FK
INT vehicle_id PK, FK
}

Vehicle ||--o{ Maintenance : I
Employee ||--o{ Assignment_Performance : I
Assignment ||--o{ Assignment_Performance : I
Vehicle ||--o{ Vehicle_Assignment : I
Assignment ||--o{ Vehicle_Assignment : I
Employee ||--o{ Employee_Operation : I
Vehicle ||--o{ Employee_Operation : I



```




