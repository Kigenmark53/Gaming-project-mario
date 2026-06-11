markdown_content = """# 2D Platformer Game

A classic 2D platformer game built with Unity. This project features character movement, coin collection, moving platforms, and a mobile-friendly touch user interface. It is fully playable in the browser via a WebGL build.

## 🎮 Play the Game

[Play the live WebGL version here](#) *(Replace this with your Unity Play link!)*

## ✨ Features

Based on the core mechanics implemented in the project:
- **Player Controller:** Smooth 2D movement and jumping mechanics (`PlayerMovement2D.cs`).
- **Interactive Environment:** Moving platforms and hazardous death zones to challenge the player.
- **Scoring System:** Collectible coins and score tracking (`Coin.cs`, `ScoreManager.cs`).
- **Mobile-Ready UI:** Scalable on-screen buttons (Left, Right, Jump) optimized for touchscreens using the Unity Canvas Scaler.
- **Level Management:** Scene transitions for level completion.

## 🛠️ Tech Stack

- **Game Engine:** Unity (2D Core)
- **Programming Language:** C#
- **Version Control:** Git & GitHub
- **Deployment:** Unity WebGL / Unity Play

## 🚀 Getting Started (Local Development)

If you want to download and run this project locally:

### Prerequisites
- [Unity Hub](https://unity.com/download)
- Unity Editor (version matching the project)
- WebGL Build Support module installed

### Installation
1. Clone the repository:
Code output
File generated successfully.

```bash
   git clone [https://github.com/Kigenmark53/Mario-Game.git](https://github.com/Kigenmark53/Mario-Game.git)
Open Unity Hub, click Add, and select the cloned project folder.

Open the SampleScene in the Assets/Scenes folder.

Click the Play button at the top of the editor to test the game!

📱 Building for Web
To build the game for web browsers:

Go to File > Build Profiles.

Select Web and ensure it is the Active platform.

Click Build, select an empty output folder, and wait for the compilation to finish.

👨‍💻 Author
Mark Kigen Kiboni
Software Development & Engineering, KCA University
"""

with open("README.md", "w", encoding="utf-8") as f:
f.write(markdown_content)

print("File generated successfully.")
