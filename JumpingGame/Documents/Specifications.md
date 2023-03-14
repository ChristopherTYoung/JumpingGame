### Specifications:
## The game will need to generate a board
	- In the board class, we will have a generate board method.
	- We are going to use a 2 Dimensional array to represent the board
	- The board will be generated as a string in the console
## The player will need to be able to jump
	- We will detect if a player has pressed the jump key.
	- The characters position will move upwards
	- The jump will be registered in the update board method in the board class
## The player will need to be able to duck
	- We will detect if a player has pressed the duck key
	- The characters position will move downards on the board
	- The duck will be registered in the update board method
## The game will end if the player touches a cactus or enemy
	- We will have an boolean EndGame method that will end the game if true
	- Everything on the board will have an integer value
	- If the player touches a cactus/enemy, the value of the character will change
	- The EndGame function will then return true
## Cacti will need to be generated and placed on the board
	- In the cactus class, there will be a generate cactus method
	- Cacti will be generated randomly
	- There will be a cactus array data member
	- The cacti will be represented by an icon
	- The update board method in the board class will add the new cactus that has been generated.
## Enemies will need to be generated and placed on the board
	- In the enemy class, there will be a generate enemy method
	- In the generate enemy method, the enemies height position will be generated
	- The enemy will be represented by an icon
	- The update board method will add and display the enemy on the board using the given height