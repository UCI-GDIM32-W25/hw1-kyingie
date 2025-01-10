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
To begin with this assignment, I added player movement which turned out well as I reviewed previous game projects on how I added movement using the WASD key inputs. I was able to instantiate the plant prefab, but had a hard time figuring out how to make the player plant the prefab once and not all five at the same time. To solve this, I researched for alternative methods of using key inputs, and found that it would be better to use 'GetKeyDown' whereas the initial option of 'GetKey' that kept updating the plant prefab to spawn all five at the same time. By changing it to 'GetKeyDown', the game was able to detect each interaction of the space key in update. Initially in my plan, I wanted to work on Plant Count UI last, but it made sense to work on it first to make sure the plants were being instantiated into the game. I struggled a bit with the PlantSeed function because previously the plants spawned following the player's movement and not the player's position, but I fixed the positioning of the prefabs as I mistakenly was changing the _plantPrefab's position when I should've been changing the new game object plantPrefab that was being instantiated. Overall, this was a good lesson and review of last quarter's coding so I had fun!




## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
