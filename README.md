# Aplikacja do nauki słówek
> Projekt zawiera dwie główne funkcje: tłumaczenie słówek z języka angielskiego na polski (i odwrotnie) oraz quiz składający się z 10 pytań.

## Spis treści
* [Informacje ogólne](#informacje-ogólne)
* [Technologie użyte w projekcie](#technologie-użyte-w-projekcie)
* [Funkcje](#funkcje)
* [Ustawienia](#ustawienia)
* [Użytkowanie](#użytkowanie)
* [Status projektu](#status-projektu)
* [Obszar do poprawy](#obszar-do-poprawy)
* [Kontakt](#kontakt)


## Informacje ogólne
- Projekt edukacyjny wykonany w ramach zaliczenia przedmiotu Programowanie
- Aplikacja służy do nauki języka angielskiego
- Umożliwia tłumaczenie słówek oraz wykonanie testu złożonego z 10 pytań
- Projekt wspiera skuteczną naukę słownictwa poprzez ćwiczenie prajtyczne


## Technologie użyte w projekcie
- .NET Framework 4.7.2
- Język C#
- System.IO
- System.Windows.Forms.Timer
- CSV
- GDI+


## Funkcje
- Quiz oparty na załączonych słówkach - losowanie 10 słówek do testu
- Licznik czasu, sprawdzanie odpowiedzi i liczenie punktów (poprawne i błędne odpowiedzi)
- Odpowiedzi są sprawdzane bez rozróżniania wielkości liter
- Wyświetlanie odpowiedniej grafiki w zależności od wyniku
- Tłumaczenie słów wpisanych przez użytkownika


## Ustawienia
Wymagania systemowe:
- System operacyjny: Windows
- .NetFramework: minimum 4.7.2
- Visual Studio

Pliki wymagane do działania:
- slownik.csv - lista słówek (w formacie angielskie:polskie)
- zdane.jpeg, niezdane1 - grafiki, które wyświetlą się po ukończeniu quiz'u

Do głównego folderu dodaj plik.csv, a do Properties->Resources dodaj obie grafiki.

## Użytkowanie
Obsługa quiz'u:
1. Wciśnij przycisk '?', aby uzyskać informacje na temat testu
2. Wciśnij przyscisk 'Rozpocznij test'
3. Przetłumacz każde z 10 wylosowanych słow
4. Masz 10 sekund na każdą odpowiedź
5. Po wpisaniu odpowiedzi wciśnij ENTER, aby ją zatwierdzić
6. Po zakończeniu testu otrzymasz wynik

Obsługa panelu do tłumaczenia:
1. Wpisz słowo (po angielsku lub po polsku) w lewym oknie
2. Wciśnij przycisk TŁUMACZ
3. W prawym oknie zostanie wyświetlone tłumaczenie


## Status projektu
Projekt ukończony i działający.


## Obszar do poprawy
Poprawiony może zostać tłumacz. Można rozwinąć funkcję tłumacza do pobierania tłumaczeń ze stron co zwiększyłoby możliwości tej funkcji.


## Kontakt
Projekt stworzony przez [@Oliwia226]

