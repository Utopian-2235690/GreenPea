# GreenPea
Dit is een repository voor de game 'Green Pea'

Green Pea Game Documentatie
Game werking:
In deze game heb je de volgende functionaliteiten:
•	Main Menu
•	Main Game
•	Win Screen
•	Game Over Screen



1: Main Menu
In de Main Menu kan je op “Start Game” klikken of op “Quit Game” klikken. De game sluit af als je op “Quit Game” klikt en het start als je op “Start Game” klikt.

Wanneer je op “Start Game” klikt dan roept de button OnClick de PlayGame method op en als je quit game klikt dan roept het QuitGame op.



2: Main Game
Zodra je de game start komt er een KillVoid/KillBrick van de onderkant van de map wat je moet ontsnappen.
Als de player tegen de KillVoid aankomt, dan verandert de scene naar de Game Over Screen/Lose Screen.


Als de game start dan spawnen ook food items in. Groen food is good food, het geeft je een permanent speed buff. Rood food is bad food, het geeft je een temporary maar sterkere speed buff, nadat het uitwerkt wordt je ook slomer.
In de code geeft good food je +1 speed en bad food geeft je +2 speed. De timer op de speed boost werkt door een async te gebruiken die al seen timer werkt.
 Er worden ook Lists gebruikt om de food items in te spawnen.


Aan het einde van de map is er een portal waar je doorheen kan gaan om naar de win screen te gaan.
 


3: Win Screen
Als je door het portal heen gaat dan win je en ben je op tijd ontsnapt. Je kan vanaf daar direct terug gaan naar de main menu. Het roept de mainMenu methode op.



4: Game Over Screen
Als je niet optijd ontsnapt en de killVoid aanraakt dan wordt je naar de LoseScreen gestuurd waar je direct terug naar de main menu kan gaan om de game te sluiten of opnieuw te proberen.
 
