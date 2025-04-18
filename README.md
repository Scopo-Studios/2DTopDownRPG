Assignment 2: 2D Top Down RPG Report
Team: Scopo Studios
Members: Hans Jeremy, Joseph Pedroza, and David Vargas

Tutorial Series Followed: Making a game like Legend of Zelda 

Key features implemented:
- Inventory System
  - Can store different types of items and multiple of them
  - Player can pick up items from the ground or chests and they will be stored in the inventory
  - Inventory Items stay with the player through different scenes
  - Item types are
      - Weapon (non-consumable)
      - Potions (consumable)
      - Quest items (non-consumable)
      - Puzzle pieces (non-consumable, but usable)
- Enemy AI
  - Patrolling enemies that go between two patrol points
  - Enemies that are idle until close enough to lock onto the player
- NPC interactions with dialogue options
  - One NPC inside of the house
  - Gives the player a quest along with guidance on where items are located
  - Has different dialogue choices that players can choose
- Health and damage system
  - Player and enemies have health points that lower when one attacks the other
  - The player and enemies do a specified amount of damage
- Puzzle mechanics 
  - A key item is required to open the door leading to a quest item
  - When the player does not have the key in the inventory, the door will not open.
- Pause Menu
  - Resume Button allows for the game to continue
  - Quit Button closes the entire game

Your custom scenario:
The custom scenario that we created for our game was that a group of log monsters stole a legendary hero’s bow.  The village had kept it to honor the hero, but the log monsters stole it.  Now, the mayor of the village is asking for help to complete a quest to retrieve the bow back from the log monsters.  The only way to do that is by fighting log monsters to find a key to unlock the lair door in the log monsters’ cave.  

Challenges faced and solutions:
There were a good amount of challenges along the way.  One of them was trying to save the item from a chest into the player’s inventory.  This was an issue because the item we tried to save was created as a different type of game object and labeled differently since it was earlier in the tutorial.  Along with that, there was a separate inventory system that was created along with the chest item because the tutorial created it as a placeholder until the actual inventory system was made.  Once this was realized, it was clear that we needed to recreate the chest items as the updated inventory items and allow them to interact with the new inventory system.  
Another problem is scene transitions as when some scenes transitioned and then transitioned back, the implemented scene was not the one we expected meaning there was a semantic error.  This means that when we would transition scenes, we would not return to the point where we would last changed scenes, rather we would teleport to where the scene starts at boot up.

Link to your repository:
https://github.com/Scopo-Studios/2DTopDownRPG

Link to Short Demo Video:
https://youtu.be/4-qgYOwyHTM 
