# automat_perkusyjny
niedokończony projekt na zajęcia z programowania obiektowego 
(po utworzeniu klasy wysypała się metoda zmieniająca wartość bpm, sample rozjeżdzają się i parę innych mniejszych bugów). 
Projekt tworyli Tomasz Szablak i Adrian Szostek, jednak z racji pisania kodu po zajęciach razem przy jednym komputerze nie ma żadnych 
commitów. 

Aplikacja dzięki dodanej bibliotece NAudio jest w stanie odtwarzać wiele plików .mp3 i .wav jednocześnie, czego nie można zrobić
np. zwyklym System.Media Play()

wersja .NET Framework 4.5.2.

1.Zasada użytkowania programu

  Aby Automat Perkusyjny mógł odgrywać jakąś sekwencję, musi mieć załadowane sample(tzw. krótkie próbki dźwiękowe w formacie .wav lub .mp3)
  Do ładowania dźwięków służa buttony po lewej stronie okna. Na każdy button przypada po 16 checkboxów. Zaznaczamy checkboxy w
  takich miejscach jakich chcemy by dany sampel był odgrywany. Dla przykładu, gdy mamy załadowany sampel oraz gdy zaznaczymy co czwarty checkbox powstanie nam prosta 
  sekwencja rytmiczna w metrum 4/4, którą możemy rozmaicać innymi dzwiękami, gdyż mamy do dyspozycji jeszcze 5 wolnych miejsc na inne sample
  
  Aby odtworzyć naszą sekwencję wystarczy kliknąć na "Play", a aby ją zatrzymać wystarczy kliknąć "Stop" z tym, że po kliknięciu sekwencja zatrzyma się nie od razu, a 
  będzie to raczej zadeklarowanie ostatniego zapętlenia sekwencji.
  
  

