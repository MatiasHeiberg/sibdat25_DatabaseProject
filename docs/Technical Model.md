Relation Model


```mermaid
erDiagram  
KUNDE {  
int KundeID PK  
string Navn  
string Email  
}  
  
ORDRE {  
int OrdreID PK  
date Dato  
int KundeID FK  
}