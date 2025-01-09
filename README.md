[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
How would you describe this game world in objects?
There is a player game object that resembles a bunny sprite. There is also a plant sprite that uses player input to spawn in. There are text UI game objects that relate to how many plant game objects exist on the game scene and how many plants the player can place.

What attributes and actions do these objects have?
The player game object is movable using player input of WASD, and it can also spawn in plant game objects using the space key. The plant game object can only be spawned through player input of space but stays completely still at the player’s location. The text UI changes based on how many plants are spawned into the game, and increases up to a maximum of five. There is also a counter text of how many plants the player still needs to spawn that decreases over plants.

How do these objects act on or affect each other?
The plant game objects exist only when the player presses the space key, otherwise the game objects are not instantiated. The player can move through the spawned plant objects. The text UI depends on the number of plant prefabs spawned versus the number of plants the player can still place into the game.

Plan:
Player movement through WASD
Plant prefab instantiated through space input
Only plants 5 prefabs maximum → Num Seeds = 5
Change text UI based on remaining and planted plant game objects

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
