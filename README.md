# Now Playing Mod

## Overview

The Now Playing mod is a lightweight client-side utility that allows you to quickly identify the music currently playing in your Vintage Story game world. Simply type `.song` in chat and the mod will display the track name in the chat window.

This mod is perfect for:

- Discovering new music from the game's soundtrack
- Finding specific tracks you like while exploring
- Sharing song information with other players on the server
- Creating a personal soundtrack library from your favorite game tracks

**Version:** 1.0.0
**Side:** Client-side only (no server-side component required)
**Minimum Game Version:** 1.19.0 or higher

## Installation Instructions

### Windows

1. **Locate your Vintage Story game folder:**

   - Open File Explorer
   - Navigate to: `C:\Users\<YourUsername>\AppData\Roaming\VintageStory`
   - If this folder doesn't exist, launch the game first to create it

2. **Create the mods directory (if it doesn't exist):**

   - In the VintageStory folder, create a new folder named `Mods`
   - Navigate into the `Mods` folder

3. **Download and install the mod:**

   - Download the mod file from the mod repository
   - Extract the mod folder into your `Mods` directory
   - Your folder structure should look like:
     ```
     C:\Users\<YourUsername>\AppData\Roaming\VintageStory\Mods\now-playing\
     ```

4. **Launch the game:**
   - Start Vintage Story normally
   - The mod will load automatically on startup

### Linux

1. **Locate your Vintage Story game folder:**

   - Open a terminal
   - Navigate to: `~/.config/VintageStory`
   - If this folder doesn't exist, launch the game first to create it

2. **Create the mods directory and install the mod:**

   ```bash
   mkdir -p ~/.config/VintageStory/Mods
   cd ~/.config/VintageStory/Mods

   # Extract the mod (replace with your actual mod file)
   unzip now-playing.zip
   ```

3. **Verify installation:**

   ```bash
   ls -la ~/.config/VintageStory/Mods/now-playing/
   ```

   You should see `modinfo.json` and `src/` folder

4. **Launch the game:**
   - Start Vintage Story normally through your launcher or:
     ```bash
     cd ~/GameFolders/vintagestory
     ./VintageStory
     ```

### macOS

1. **Locate your Vintage Story game folder:**

   - Open Finder
   - Press `Cmd + Shift + G` (Go to Folder)
   - Navigate to: `~/Library/Application Support/VintageStory`
   - If this folder doesn't exist, launch the game first to create it

2. **Create the mods directory and install the mod:**

   ```bash
   mkdir -p ~/Library/Application\ Support/VintageStory/Mods
   cd ~/Library/Application\ Support/VintageStory/Mods

   # Extract the mod (replace with your actual mod file)
   unzip now-playing.zip
   ```

3. **Verify installation:**

   ```bash
   ls -la ~/Library/Application\ Support/VintageStory/Mods/now-playing/
   ```

   You should see `modinfo.json` and `src/` folder

4. **Launch the game:**
   - Start Vintage Story through your launcher or:
     ```bash
     open -a VintageStory
     ```

## Verifying Installation

The mod can be verified both in-game and through the Mod Manager:

### Using the Mod Manager

1. **Start Vintage Story**
2. **Main Menu → Settings → Mod Manager**
3. **Look for "Now Playing" in the mod list**
   - Status: Should show as "Enabled" (green checkmark)
   - Side: Should show as "Client"
   - Version: Should show as "1.0.0"

### In-Game Verification

1. **Join a game world**
2. **Open chat by pressing `T`**
3. **Type:** `.song`
4. **Expected result:** The mod will display the current track name in chat
   - If the mod is working, you'll see output like: `♪ Now playing: [Track Name]`
   - If the mod isn't loaded, you'll see the command fail or appear as regular text

## Usage Instructions

### Basic Usage

Once installed and verified, using the Now Playing mod is straightforward:

1. **Press `T` to open the chat window** (while in-game)
2. **Type the command:** `.song`
3. **Press `Enter` to execute the command**
4. **The current track information will appear in the chat window**

### Command Syntax

```
.song
```

The command takes no parameters and will always display the currently playing track in your local game client.

### Example Output

When music is playing:

```
♪ Now playing: Peaceful Afternoon
```

When no music is playing:

```
No music track is currently playing.
```

### Chat Integration

- The song information appears in your local chat only
- Other players will not see your `.song` command output
- The mod stores the information locally and doesn't send data to the server
- You can use this command as frequently as needed

## Troubleshooting

### Problem: The mod doesn't load or I don't see "Now Playing" in Mod Manager

**Solution:**

1. Verify the mod folder structure is correct:
   - Should contain: `modinfo.json` and `src/` folder
2. Check the file permissions (especially on Linux/macOS):
   ```bash
   # Make sure the folder is readable
   chmod -R 755 ~/.config/VintageStory/Mods/now-playing/
   ```
3. Restart the game completely (not just logging back in)
4. Check the game logs for errors:
   - Windows: `%APPDATA%\VintageStory\Logs\`
   - Linux: `~/.config/VintageStory/Logs/`
   - macOS: `~/Library/Application Support/VintageStory/Logs/`

### Problem: The `.song` command doesn't work

**Solution:**

1. Verify the mod is enabled in Mod Manager
2. Make sure you're typing `.song` (dot followed by song, lowercase)
3. Check that you're using the correct Vintage Story version (1.19.0 or higher)
4. Restart the game and try again
5. Check if there are any conflicting mods that might intercept chat commands

### Problem: No music is playing / Command shows "No track"

**Possible causes:**

- You've disabled ambient music in game settings
- The location you're in has no music assigned
- Game sounds are muted

**Solution:**

1. Check your audio settings:
   - Menu → Settings → Audio
   - Ensure "Music" volume is not muted or set to 0
2. Try moving to a different location in the world
3. Verify that music plays normally in the game
4. Some caves or specific areas may have no ambient music

### Problem: Game crashes after installing the mod

**Solution:**

1. Remove the mod folder
2. Verify your Vintage Story installation is not corrupted:
   - Delete and reinstall the game
3. Check mod compatibility:
   - This mod requires Vintage Story 1.19.0 or higher
4. Review game logs for specific error messages
5. Disable any other recently installed mods to identify conflicts

### Problem: Game starts but mod features don't work on servers

**Note:** This is expected behavior for single-player worlds. See "Multiplayer Compatibility" section below.

**Solution:**

1. The mod is client-side only—it will work on any server
2. The server does not need to have this mod installed
3. If features still don't work, verify the mod is enabled in the Mod Manager

## Technical Details

### Client-Side Only

This mod runs entirely on your client machine and does not:

- Require server-side installation
- Send any data to the server
- Interfere with server gameplay
- Require any special server permissions

The mod uses only client-side game APIs to query currently playing audio and display information in the chat system.

### APIs Used

The Now Playing mod uses the following Vintage Story client APIs:

- **Chat API:** For displaying messages to the player

  - `IChatAPI` - Register and handle chat commands
  - `Chat.SendMessage()` - Output results to player

- **Audio API:** For querying currently playing music tracks

  - `IAmbientManager` - Query ambient music status
  - Track metadata (name, duration)

- **Command System:** For the `.song` command registration
  - Client-side command registration
  - Command parameter parsing (minimal, no parameters required)

### Mod Type

- **Type:** Code (C# mod)
- **Version:** 1.0.0
- **Author:** bawu
- **Dependency:** Vintage Story game 1.19.0+

### File Structure

```
now-playing/
├── modinfo.json          # Mod metadata and configuration
└── src/                  # Compiled mod code (binary)
```

## Multiplayer Compatibility

### Server Support

The Now Playing mod is fully compatible with all Vintage Story servers:

- **Works on:** All servers (vanilla and modded)
- **Requirements:** None (server doesn't need the mod)
- **Impact:** Client-side only, doesn't affect server performance
- **Compatibility:** Works alongside all other mods

### Multiplayer Behavior

When playing on a multiplayer server:

1. **Chat visibility:**

   - Your `.song` command output is visible only to you
   - Other players cannot see your song queries
   - No server bandwidth is used for queries

2. **Compatibility:**

   - The mod works the same in multiplayer as single-player
   - Server admins don't need to approve or install the mod
   - Safe to use on any public or private server

3. **No conflicts:**
   - The mod doesn't intercept or modify server messages
   - Doesn't modify gameplay mechanics
   - Safe for servers with anti-cheat or other security mods

### Recommended Usage

- Perfect for sharing discoveries with friends (copy the output manually)
- No need to inform server admins about having this mod installed
- Safe for long-term multiplayer sessions

## Support and Feedback

If you encounter issues or have suggestions:

1. **Check the Troubleshooting section** above first
2. **Verify game version:** Ensure you're running Vintage Story 1.19.0 or higher
3. **Review mod installation:** Double-check the folder structure and permissions
4. **Report issues:** Contact the mod author with detailed information about your problem

## License and Attribution

- **Mod Author:** bawu
- **Version:** 1.0.0
- **For:** Vintage Story community
- **Game:** Vintage Story

---

**Last Updated:** December 2025
**Compatible With:** Vintage Story 1.19.0+
