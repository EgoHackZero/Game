# ULTIMATE Battleship Game

A 2D platformer game built with C# and the MerlinCore framework featuring a wizard protagonist, enemies, spells, interactive objects, and puzzle mechanics.

## Features

### Core Gameplay
- **Player Character**: Control a wizard with multiple animations (idle, run, jump, attack, crouch, etc.)
- **Combat System**: Cast spells including projectile spells (fireball, iceball) and self-cast spells
- **Enemy Types**: Battle various enemies including:
  - Fly Eye
  - Bats
  - Ghosts
  - Lizards (with shooting ability)
  - Skeletons
  - Slimes

### Game Mechanics
- **Physics System**: Gravity-based movement with jump and fall mechanics
- **Inventory System**: Backpack with item management and healing potions
- **Puzzle Elements**:
  - Pressure plates and doors
  - Levers and buttons
  - Interactive objects (cauldrons, stoves, crystals)
- **Speed Modifiers**: Different speed strategies (Normal, Quick, Modified)
- **State Management**: Character states (Living, Dying) with appropriate behaviors

### Technical Features
- Built on **MerlinCore 2.5.5** game engine
- Uses **Newtonsoft.Json** for data serialization
- Tile-based map system (TMX format)
- Sprite animation system
- Command pattern for player actions
- Factory pattern for actor creation
- Builder pattern for spell construction
- Strategy pattern for character speed

## Project Structure

```
Game/
├── Actors/                 # Character and entity classes
│   ├── Enemy/             # Enemy implementations
│   ├── Button_and_door/   # Interactive puzzle elements
│   └── Player.cs          # Player character implementation
├── Commands/              # Action commands (Move, Jump, Attack, etc.)
├── Factories/             # Factory classes for creating game objects
├── Items/                 # Inventory and item system
├── Spells/                # Magic system implementation
└── resources/             # Game assets
    ├── maps/              # Level maps and tilesets
    ├── sprites/           # Character and object sprites
    ├── effects.json       # Spell effect configurations
    └── spell.csv          # Spell data
```

## Requirements

- **.NET 6.0** or higher
- **Windows** (primary platform)
- MerlinCore 2.5.5 (automatically installed via NuGet)

## Installation

1. Clone the repository:
```bash
git clone <repository-url>
cd Game
```

2. Restore NuGet packages:
```bash
dotnet restore
```

3. Build the project:
```bash
dotnet build
```

4. Run the game:
```bash
dotnet run --project Game/Game.csproj
```

## Controls

(Add your game controls here based on implementation)

## Development

### Building from Source
```bash
# Debug build
dotnet build

# Release build
dotnet build -c Release
```

### Architecture Patterns Used
- **Command Pattern**: Player actions (Move, Jump, Attack, Fall)
- **Factory Pattern**: Actor, Button, Door, Enemy creation
- **Strategy Pattern**: Speed modification system
- **Builder Pattern**: Spell construction system
- **State Pattern**: Character state management (Living/Dying)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

All rights reserved by **EgoHackZero**.

## Author

**EgoHackZero**

## Acknowledgments

- Built with [MerlinCore](https://www.nuget.org/packages/MerlinCore/) game engine
- Sprite assets from various sources (specify if applicable)

## Version History

- **Latest**: Spell system, effects, and animations completed
- Previous commits include unique naming system, QuickSpeedStrategy implementation

## Contributing

This is a personal project. For any questions or suggestions, please contact the author.
