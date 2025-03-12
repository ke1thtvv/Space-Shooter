# Space-Shooter

# Space Shooter Game

![Game Screenshot]![image](https://github.com/user-attachments/assets/ec06591a-e2a9-454d-a93c-afb13d2f7dda)


## Project Description

**Space Shooter** is a dynamic arcade game written in C# and built using the Unity engine. 
In this game, you take on the role of a spaceship pilot fighting against an increasing 
number of meteors. The game utilizes **object-oriented programming** and design patterns 
such as **Singleton**, **Decorator**, and **Abstract Factory**.

The goal is to score as many points as possible by destroying meteors. The longer you play, 
the more points you earn. Additionally, some meteors may drop temporary upgrades for the spaceship.


## Controls
- **Left Arrow**: Move the spaceship left.
- **Right Arrow**: Move the spaceship right.
- **Spacebar**: Fire the spaceship's cannon.

## Game mechanics

- **Scoring**:
  - Destroying a meteor grants a certain number of points, depending on its type.
  - The difficulty level increases over time, awarding more points for each destroyed meteor.
  
- **Meteo Types**:
  - Different meteors vary in size, durability, and the points they provide when destroyed.
  - Some meteors may drop power-ups, such as:
    - Increased spaceship speed
    - Permanent attack multiplier
    - Protective shield
    - Health regeneration

## Technologies

Projekt został zbudowany przy użyciu:

- **Programming Language**: C#
- **Game Engine**: Unity (jeśli Unity jest używane, w przeciwnym razie można pominąć)
- **Design Patterns**:
  - **Singleton**: Manages components like score tracking and sound management
  - **Decorator**: Used for dynamically adding spaceship upgrades
  - **Abstract Factory**: Handles the creation of different meteor types and their properties
