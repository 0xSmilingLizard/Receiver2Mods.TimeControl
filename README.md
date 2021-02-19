# TimeControl
 
A mod for `Receiver 2`, that gives you hotkeys to toggle media mode and to set the media-mode-timescale to one of 5 configurable timescales.

## Install

Install [BepInEx](https://github.com/BepInEx/BepInEx) into the Receiver 2 folder (the one containing `Receiver2.exe`), then start and exit Receiver 2 to have BepInEx generate its folder structure.
Then place the MiscTweaks folder in `BepInEx/plugins`.

It is recommended to use [BepInEx's Config Manager](https://github.com/BepInEx/BepInEx.ConfigurationManager) (installed the same way as this mod) to have an in-game UI to set the timescale presets.

## Dependencies

The source code depends on `BepInEx.dll`, `UnityEngine.dll`, `UnityEngine.CoreModule.dll`, `UnityEngine.InputLegacyModule.dll`, and `Wolfire.Receiver2.dll`. It is set up to expect these DLLs to be located in a folder called `libraries` next to the repository folder.
