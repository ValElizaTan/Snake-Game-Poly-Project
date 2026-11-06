# Genshin Snake 🐍 – C# Windows Forms Snake Game

A Genshin Impact–themed take on Snake, built in C# with Windows Forms as a polytechnic programming project at Nanyang Polytechnic. You steer Paimon around a 10 × 20 board collecting **Primogems**. Her trail of **Intertwined Fates** grows with every gem, and each level adds one more gem to collect. When the game ends, your score is saved to a leaderboard.

## How to play

1. Type your name in the **Name** box (leave it blank to play anonymously).
2. Press **Start**. The Genshin Impact theme starts playing and the timer begins.
3. Steer with the eight on-screen arrow buttons: up, down, left, right and the four diagonals.
4. Collect every Primogem on the board to move up a level.
5. Press **End Game** when you're done. A Game Over window shows up, and from there you can **View Leaderboard**.

## Game rules

| Rule | Detail |
|------|--------|
| Board | 10 rows × 20 columns of 30 px squares in a brown / midnight-blue checkerboard |
| Speed | The snake moves one square every 300 ms |
| Wrap-around | Going off one edge brings you back on the opposite edge (straight directions only) |
| Scoring | **160 points** per Primogem |
| Levels | Level *n* has *n* Primogems at random, non-overlapping positions. Clearing them all starts the next level with a fresh, length-1 snake |
| Growing | Each Primogem eaten adds one segment to the snake |
| Game over | Running into your own body, or pressing **End Game** |
| HUD | Current level, score, elapsed time (seconds) and current direction |

## Leaderboard

Every game over appends a line `Name,Score` to **`C:\tmp\leaderboard.txt`**. The leaderboard window reads that file and shows all entries in a table sorted from highest to lowest score.

## Tech stack

- C# / .NET Framework 4.5.2, Windows Forms
- `System.Media.SoundPlayer` for background music
- Plain text file I/O (`StreamReader` / `StreamWriter`) for the leaderboard
- Object-oriented design with separate classes for the board, snake, rewards, positions and scores

## Project structure

```
211354TSnakeTaskComplete.sln
Snake/
├── Program.cs              # Entry point, launches Form1
├── Form1.cs                # Main game window: timer loop, controls, scoring, levels
├── Board.cs                # 10×20 grid of PictureBoxes, drawing helpers
├── Snake.cs                # Snake body, 8-direction movement, wrap-around, self-collision
├── Rewards.cs              # Primogem placement, collision check, 160 pts per gem
├── Position.cs             # Row/column value object
├── Score.cs                # Name + score record
├── gameover.cs             # Game Over dialog
├── LeaderBoard.cs          # Reads leaderboard file into a sorted DataGridView
└── Resources/              # Paimon, Primogem, Intertwined Fate sprites, wallpaper, theme song
tmp/
└── leaderboard.txt         # Sample leaderboard data
```

## Getting started

Requirements: Windows and Visual Studio (2017 or newer) with the **.NET desktop development** workload. The .NET Framework 4.5.2 targeting pack may be needed, or you can retarget the project to 4.8.

1. **Create the leaderboard file first.** The game opens it on startup and will crash if it's missing:
   ```powershell
   mkdir C:\tmp
   copy tmp\leaderboard.txt C:\tmp\leaderboard.txt   # or create an empty file
   ```
2. Open `211354TSnakeTaskComplete.sln` in Visual Studio.
3. Press **F5** to build and run.

## Known limitations

- The leaderboard path `C:\tmp\leaderboard.txt` is hard-coded, so the game only runs on Windows with that folder present.
- `SoundPlayer` only plays WAV audio. If the theme song resource is an MP3, convert it to WAV for the music to play reliably.
- The diagonal directions don't wrap around the board edges the way the straight directions do.
- The start-up message mentions the arrow keys, but movement is controlled through the on-screen buttons.

## Credits

- Game sprites, music and wallpaper are from *Genshin Impact* © HoYoverse, used here for a non-commercial student project.
- Starter structure (Board / Position / timer loop) was provided as part of the course; the theme, rewards, levels, diagonal movement, scoring and leaderboard are my additions.
- Author: Valerie Tan Wan Xin – Nanyang Polytechnic, Infocomm & Media Engineering
