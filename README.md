# 🕹️ Obstacle Dodge: My First Unity Adventure

Welcome to my very first Unity project! 🚀 This isn't the next *Elden Ring* (yet), but it's where the journey began. I built **Obstacle Dodge** to poke around the Unity Editor, wrestle with C# scripts, and figure out why my player kept falling through the floor.

## 📺 Gameplay Run Through
*Watch the full chaos below!*


![ObstacleDodge-SampleScene-WindowsMacLinux-Unity6 3LTS6000 3 2f1__DX12_2026-01-0717-46-10-ezgif com-optimize](https://github.com/user-attachments/assets/a94dcd14-4b3d-4109-b901-ee6b24122d3c)

---

## 🎯 The Objective
**Don't. Touch. Anything.**

The goal is simple: Navigate the obstacle course and reach the finish line. The catch? Every time you hit an obstacle, your "Score" goes up. In this game, **points are bad**. 

Your mission is to finish with a score of **0**.

---

## 🛠️ Features (aka Things I Learned)
* **The Mover:** A script that actually makes a cube move when you poke the WASD keys. Pure magic. ✨
* **The "Oops" Counter:** I implemented a scoring system that tracks your collisions. It uses Tags to make sure you don't get double-penalized for the same mistake.
* **The Spinner:** High-tech rotating obstacles designed to ruin your perfect run. 🌀
* **The "Fly At Player" Trap:** I learned how to make objects hunt you down. If you see one moving, run! 🏃‍♂️
* **Cinemachine:** Because a static camera is so 1994. Smooth follows only! 🎥
* **Prefabs:** I learned that making 100 copies of one object is way easier when you use a template.

## 🏗️ Project Structure
* **`Assets/Scripts/`**: Where the logic lives (and where I spent 90% of my time debugging).
* **`Assets/Prefabs/`**: My reusable "blueprints" for world domination.
* **`Assets/Scenes/`**: The map layout where I spent way too much time aligning cubes.

## 🧠 Brain Expansion Log
Through this project, I mastered:
1.  **C# Basics:** `Update()` vs `Start()` (The eternal struggle).
2.  **Input Handling:** Making the computer listen to the keyboard.
3.  **Triggers & Collisions:** Learning that "Is Trigger" is a very important checkbox.
4.  **The Unity Workflow:** Folders, Meta files, and the "Save" button.

---

### 🧱 How to Play
1. Open the project in Unity.
2. Hit the **Play** button.
3. Use **WASD** or **Arrow Keys** to move.
4. **Dodge everything.** If it's not the floor, don't touch it.
5. Reach the end of the course to win (and hopefully brag about your score of 0).

---
*Created with ☕, sweat, and a lot of Googling by a future Game Dev.*
