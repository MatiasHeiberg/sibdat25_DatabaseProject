ER Diagram 

```mermaid  
flowchart TB

Bil[Bil] <--> StelNR([StelNR])
Bil[Bil] <--> Nummerplade([Nummerplade])
Bil[Bil] <--> Kapacitet([Kapacitet])
Bil[Bil] <--> Model([Model])
Bil[Bil] <--> Pris([Pris])
Bil[Bil] <--> Årstal([Årstal])
Bil[Bil] <--> Bruger[Bruger]
Bil[Bil] <--> Bruger[Bruger]


Bruger[Bruger] <--> Lejer[Lejer] 
Bruger[Bruger] <--> Navn([Navn])
Bruger[Bruger] <--> Cpr([Cpr])
Bruger[Bruger] <--> B_Navn([B_Navn])
Lejer[Lejer] <--> KørekortNR([KørekortNR])
Lejer[Lejer] <--> Adresse([Adresse])
Lejer[Lejer] <--> Navn([Navn])
Lejer[Lejer] <--> TelefonNR([TelefonNR])
Lejer[Lejer] <--> Mail([Mail])

Slut([Slut]) 





