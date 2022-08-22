
Made by Zheng Yan 251006929

This is the APP 3 assignment.
All the recouses are found online:
Background music from: https://assetstore.unity.com/packages/audio/music/orchestral/free-live-music-journey-across-worlds-205221
Sound effect when player died: https://assetstore.unity.com/packages/audio/sound-fx/free-sound-effects-pack-155776
The textures,animation, grids are online sources.

Brief description： There are two screens, one is for the start part and one is for the game part.

Start part: start part has a background music, start/load, leaderboard, exit button. Top three records will be memorized in the game. When press start/load, it wll change to game part.

Game part:  game part is start the game and has a background music, the player can move left or right, double jump even when falling.Many traps in the map and you need to reach the soft to win the game, press r will restart the game with the latest save point. When you reach the end, you can enter your name and the game will start again. When press exit, there are four button,  Back-back to game, Exit-exit the game, Back to menu - back to the start scenece and the startfrombegining- will lead to back to the start point. Player can press z to shoot bullets, and the bullets can only affect the save point, you should save the game use bullets to shoot the save points.

Scripts description: Events contains all touch events when player goes in to specific position.
 back is to change the camera back when you go back, 
Bullets is the set of bullets.
CamerStartposition recorded the position of the camera they should be.
Changedown is the events that player falls.
changecamera changes camera forward.
changedeaths recorded the death times.
deletall used for leaderboard to delete all record.
ExitUiControl has the function used for exit ui.
first is used by StartUi
GameManager listened the press of r and set the position of the player
playercontrol is the action about the player can do and will delete the player when touch the trap.
pricktrigger used for traps to test if they touch the player.
pricktrigger used for those invisiable traps
Savepoints is set the reborn point.
showleaderboard used for leaderboard to show information.
Wintochange will change the information if you have a new record

