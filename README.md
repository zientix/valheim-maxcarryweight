# PlecakDlaCweli

A Valheim mod that removes carry weight restrictions by setting the maximum carry weight to 9999.

## Description

PlecakDlaCweli ("Backpack" mod) is a simple modification for Valheim that effectively removes the carry weight limitation by setting it to an extremely high value (9999). This allows players to carry as many items as they want without being encumbered.

## Requirements

- BepInEx
- Jotunn
- Valheim

## Installation

1. Install BepInEx if you haven't already
2. Install Jotunn if you haven't already
3. Download the latest release of PlecakDlaCweli
4. Place the `PlecakDlaCweli.dll` file in your `BepInEx/plugins` folder
5. Launch the game

## Features

- Sets player's maximum carry weight to 9999
- No configuration needed - works immediately after installation
- Compatible with Jotunn framework

## Technical Details

- Plugin GUID: `pl.zienti.cwelinskiPlecak`
- Plugin Name: PlecakDlaCweli
- Version: 0.0.1
- Dependencies: Jotunn

## How It Works

The mod uses Harmony to patch the `GetMaxCarryWeight` method of the `Player` class, setting a fixed return value of 9999, effectively removing the carry weight restriction from the game.

## Notes

- This mod affects gameplay balance significantly by removing carry weight restrictions
- All players must have the mod installed for consistent gameplay experience in multiplayer sessions
- The mod is currently in early development (version 0.0.1)

## Contributing

Feel free to submit issues and enhancement requests through the project's issue tracker.

## License

[Add your chosen license here]

## Credits

Created by [Your Name/Username]

## Changelog

### 0.0.1
- Initial release
- Implemented infinite carry weight functionality