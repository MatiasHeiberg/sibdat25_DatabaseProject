ER Diagram 

```mermaid  
flowchart TB

Lejer[Lejer] <--> |Lejer| Bil[Bil]
Bil[Bil] <-->|har| Kører[Kører] 
Kører[Kører] <--> Lejer[Lejer]

Bil[Bil] <--> StelNR([StelNR])
Bil[Bil] <--> Nummerplade([Nummerplade])
Bil[Bil] <--> Kapacitet([Kapacitet])
Bil[Bil] <--> Model([Model])
Bil[Bil] <--> Pris([Pris])
Bil[Bil] <--> Årstal([Årstal])
Bil[Bil] <--> Lejeperiode([Lejeperiode]) 
Bil[Bil] <--> Motortype([Motortype]) 
Bil[Bil] <--> Drivmiddel([Drivmiddel])
Bil[Bil] <--> Udstyrsniveau([Udstyrsniveau])
Bil[Bil] <--> Rækkevidde([Rækkevidde])

Kører[Kører] <--> Lejer[Lejer] 
Kører[Kører] <--> K_Navn([K_Navn])
Kører[Kører] <--> Cpr([Cpr])
Lejer[Lejer] <--> KørekortNR([KørekortNR])
Lejer[Lejer] <--> Adresse([Adresse])
Lejer[Lejer] <--> Navn([Navn])
Lejer[Lejer] <--> TelefonNR([TelefonNR])
Lejer[Lejer] <--> Mail([Mail])







