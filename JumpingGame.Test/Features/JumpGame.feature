﻿Feature: JumpGame
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](JumpingGame.Test/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Game Started
	When game is started
	Then game is running
Scenario: Game has Ended
	When the player loses
	Then the game ends
Scenario: The board is generated
	When board is generated
	Then board array is created
Scenario: Board is represented as string
	When board is generated
	Then string representation is created
Scenario: Player is generated on board
	Given game is started
	When board is generated
	Then player is generated on board