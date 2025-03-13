# Space Shooter - Unity Game Project

![image](https://github.com/user-attachments/assets/ec06591a-e2a9-454d-a93c-afb13d2f7dda)

## Overview
Space Shooter is an engaging 2D arcade-style shooter built in Unity, featuring dynamic gameplay, enemy waves, power-ups, and smooth parallax effects. This project demonstrates expertise in Unity development, object-oriented programming (OOP), and game architecture.

## Features
- **Player Mechanics**: Responsive spaceship movement, shooting mechanics, and health management.
- **Enemy AI**: Procedurally spawned meteors with varying behaviors and damage levels.
- **Upgrades & Power-ups**: Speed boosts, armor, weapon enhancements, and repair kits.
- **Game Management**: Singleton-based GameManager for handling scene transitions and game logic.
- **UI & Effects**: Animated health bars, score tracking, and parallax background for depth.

## Technologies Used
- **Unity Engine** (Physics, Sprite Management, UI)
- **C#** (OOP, Scriptable Objects, Events & Delegates)
- **Singleton & Factory Patterns** (Efficient object spawning)
- **Particle Effects** (Explosion & destruction animations)
- **Scene Management** (Menu, gameplay, and game-over screens)

## Code Structure
- `GameManager.cs` - Controls game states, speed scaling, and scene transitions.
- `Spaceship.cs` - Handles player movement, shooting mechanics, and health system.
- `MeteorBig.cs` - Enemy behavior and health management.
- `Upgrade.cs` - Abstract class for power-ups, promoting modular design.
- `UpgradeSpawner.cs` - Randomized power-up generation.

## Setup & Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo/space-shooter.git
   ```
2. Open the project in **Unity 2021+**.
3. Run the `Space Shooter` scene from the Unity Editor.

## Contact & Contributions
For any queries or contributions, please create an issue or submit a pull request.

