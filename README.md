# Space-Shooter

# Space Shooter Game

![Game Screenshot](path_to_screenshot.png)

## Opis projektu

**Space Shooter** to dynamiczna gra zręcznościowa napisana w C#, zbudowana na silniku Unity, 
w której wcielasz się w pilota statku kosmicznego walczącego z rosnącą liczbą meteorytów. 
Gra wykorzystuje **programowanie obiektowe** oraz wzorce projektowe takie jak
**Singleton**, **Decorator** czy **Abstract Factory**.

Celem gry jest zdobycie jak największej liczby punktów poprzez niszczenie meteorytów. 
Im dłużej trwa rozgrywka, tym więcej punktów zdobywasz, a dodatkowo niektóre meteoryty 
mogą zapewnić czasowe ulepszenia dla statku.

## Sterowanie

- **Strzałka w lewo**: Przesunięcie statku w lewo.
- **Strzałka w prawo**: Przesunięcie statku w prawo.
- **Spacja**: Strzał z działka statku.

## Mechanika gry

- **Punkty**:
  - Zniszczenie meteorytu daje określoną liczbę punktów, zależną od jego rodzaju.
  - Dłuższa gra skutkuje zwiększaniem poziomu trudności i większą liczbą punktów za każdy zniszczony meteoryt.
  
- **Rodzaje meteorytów**:
  - Każdy rodzaj meteorytu różni się rozmiarem, wytrzymałością oraz punktami, które można za niego zdobyć.
  - Meteoryty mogą upuszczać **ulepszenia** po zniszczeniu, np.:
    - Większa prędkość statku
    - Permanentny mnożnik ataku
    - Tarcza ochronna
    - Regeneracja zdrowia

## Technologie

Projekt został zbudowany przy użyciu:

- **Języka**: C#
- **Silnik gry**: Unity (jeśli Unity jest używane, w przeciwnym razie można pominąć)
- **Wzorce projektowe**:
- **Wzorce projektowe**:
  - **Singleton**: Zapewnia, że niektóre komponenty gry, np. zarządzanie punktami czy zarządzanie dźwiękiem, istnieją jako pojedyncze instancje przez cały czas trwania gry.
  - **Decorator**: Stosowany do dynamicznego dodawania ulepszeń statku kosmicznego.
  - **Abstract Factory**: Wykorzystywany do tworzenia różnych rodzajów meteorytów i ich właściwości.
