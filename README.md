# Loader for [Shakedown Rally](https://nothke.itch.io/shakedown)

![loader image](https://github.com/stefanmielke/shakedown-rally-loader/raw/main/screenshots/MainWindow.png?raw=true)

### Features
- Change Map and Car
  - You can [download mods](https://itch.io/t/2626836/mods#post-8761824) to have more cars
  - You may need to manually rename the car ini files to know which one is which on the selection, since most mods use the same name as the included car.
- Launch the Game

### Requirements
- Only works on the paid version
- Requires [.NET Desktop Runtime 8.0.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### Usage
- Open the application
- Click "Select Path" and find your "shakedown" folder (eg.: `G:\Games\shakedown`)
- Click "Load Assets" to search the game folder for maps and cars
- Select car and map you want to use
- To run the game you have 3 options:
  - Saving the config first and then start the game:
    - Click "Save Config" to save current choices
    - Click "Start"
  - Save the config and launch at the same time:
    - Click "Save and Start"
  - Start the game without saving the config (but using the selected car and map):
    - Click "Start Without Saving"
- If you want to go back to the default car and map, click "Save Default"