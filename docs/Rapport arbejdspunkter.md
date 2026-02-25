## Indledning
- Business logic/Problemdomæne: resourcehåndtering af virksomheds biler og brugen af dem, ansatte og tildeling af aktiviteter, kundeaftaler (datoer), medarbejder delegering (datoer)
- Beskriv de endelige business rules ikke dens evolution 
## Koncept diagram (ER)
- Kardinaliterne gik det op for os at vi har brug for hjælpe tabeller (mange-mange -> ny tabel)
- Kandidate/super keys
- Sletning af Id
- Navngivningskonvention (til naturlig sprog)
## Logisk diagram
- Hvorfor hjælpe tabeller - FK bliver tilføjet til binære relationer hvilket gør det klart at tertiære relationer er bedre
- I vores binære relationer, er det spændende hvordan den relation forholder sig til den tredje hjælpe tabel.
- Med vores tertiære link tabel, er instinktet at bruge en komposition PK, men det gør tabellen ufleksibel, da den bliver afhængig af alle tre FK hvilket ikke repræsentere vores business logic.
## Teknisk diagram (relationelle/EER)
- PascalCase til attributter og tabeller fordi det er hvad EF Core forventer og fordi det er konventionen i C# (Properties og Classes)
- Normalisering (normalformer)
- Hvorfor tre til en hjælpetabel? 
## Systemdesign 
- Tech stack (EF Core, relationel database)
## Reflektion
- Code first
- Datadriven
- Hvordan kan det være code first OG data driven
- Er EF Core det rigtige værktøj?
- Tre- vs to-model tilgang Hvorfor?
	- Kompleksitet i projektet
	- Ren logik =/= implementeringslogik
- Stored Procedures og Views