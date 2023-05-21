# Battleship Game
This Battleship game was created as a junior project for the subject DSA. Our team chose Battleship as the game to implement because we wanted to challenge ourselves to create an algorithm for the bot player that goes beyond simple random moves.

The game was developed using Unity engine and programmed in C#. We hope that players enjoy the game and appreciate the thought and effort we put into creating a more strategic bot player.

## How to Play
**Step 1**: Click on the water (blue tiles) to launch the ship from the dock. After a successful reservation , the boat will be on the water, with its exact location determined by the size of the ships.
![image](https://github.com/TinChung41/Battle-Ship/assets/98845918/7b3fdd1d-9b29-4f13-a2dd-a8f4a81e4c4b)
![image](https://github.com/TinChung41/Battle-Ship/assets/98845918/98a91670-52d2-4199-b061-f9e0adc95602)

**Step 2**: After placing the ship on the water, you can redecorate them by clicking on the Rotate Button .
If the ship is outside the feasible zone (blue tiles), the ship will turn into Red . In this case, you cannot interact with another ships. You are required to change the ship location into feasible zone to continue the game. 
![image](https://github.com/TinChung41/Battle-Ship/assets/98845918/ee146919-51b7-4003-bc9d-64d03a86603c)

**Step 3**: Once you successfully placed the first ship, click Next button to place the next one (the next Ship will turn into Yellow - see Figure 5). Repeat this Step until you place all your ships .
There is a rule for every following ship that they cannot be placed on the location of the previous ships .
![image](https://github.com/TinChung41/Battle-Ship/assets/98845918/8e985370-0f32-4cde-9dd8-ce74842bdba3)
![image](https://github.com/TinChung41/Battle-Ship/assets/98845918/ca119b22-889a-4b15-960c-c99c24b339f7)

place ship successfully:
![image](https://github.com/TinChung41/Battle-Ship/assets/98845918/ace2a1c9-1773-440c-a990-c42759804676)
**Step 4**: After placing all ships, you will move to the new scene to guess your enemy tile. In this scene, you click on the tile where you think the enemy’s ships would be placed. 
If your guess is correct, the Missile will hit into the tile and this area will turn into Red .
If wrong, this area will change to Grey. 

**Step 5**: Then, it is your enemy turn. The enemy will shoot the Missile into your tile.
If enemy’s guess is correct, the Missile will hit into your tile and the flame will appear on the hit ship .
If wrong, this area will change to Grey . 
![image](https://github.com/TinChung41/Battle-Ship/assets/98845918/1cac07a2-7bf9-45af-a1d4-be6ba3c3eb3b)

Step 6: The remaining ships on your side or the enemy’s side will reduce by 1 if you or your opponent hit any entire ships. Repeat the attempts until neither ship left on one side and the game will finish .

![image](https://github.com/TinChung41/Battle-Ship/assets/98845918/57832cfe-9472-4315-b78b-3036913c43ac)




## Algorithms Consideration
### Randomization Algorithm
The PlaceEnemyShips() method in EnemyScript.cs uses a randomization algorithm to randomly place the enemy ships on the game board. This algorithm generates a random starting position for each ship and checks if the position is valid before placing the ship. Here's the code for the PlaceEnemyShips() method:

### Search Algorithm
The CheckHit() method in GameManager.cs uses a search algorithm to check if a clicked tile is part of an enemy ship. The algorithm searches through the list of enemy ships to see if the tile number matches any of the tile numbers in the ship's position array. And another example of an event handler in the game is the NextShipClicked() method in GameManager.cs. This method is called when the player clicks the "Next Ship" button during the ship placement phase of the game. The method checks whether the current ship is on the game board, and if it is not, it flashes a red color to indicate an error. If the ship is on the board, the method moves on to the next ship in the list or ends the ship placement phase if all ships have been placed.

### Event handling algorithm: 
There are multiple times this algorithm gets implemented so we will show 2 examples:
* the TileClicked() method in GameManager.cs is an example of an event handler that responds to the player clicking on a tile on the game board. The TileClicked() method is called when a tile is clicked on by the player, and it checks whether the game is in setup mode or play mode to determine how to handle the click.



# UML for our game project

![Game UML drawio](https://user-images.githubusercontent.com/98845918/234217718-a57f5426-0fae-4f98-8c19-a974a1461560.png)
