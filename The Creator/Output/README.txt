cs426_The_Creator_Asgn6
Current Build: Beta

Input Command/Controls:
- WASD to move
- Left CTR to lower
- SPACE to fly up
- Left SHIFT for boost
- TAB to toggle mouse pointer
- Players can click on planets to zoom in on them
- Right SHIFT to enter spawn planet menu
- Fly to gather resouces [collide]

Current Implementation:

Current Resources:
- Dirt
- Water
- Iron
- Core

Shaders:
- Core texture is shiny and slighty reflect [Jeff]
- Iron [Anthony]
- Dirt texture is rougher and brighter [Sean]

UI:
- Quest Menu
- Evolution Menu
- Spawn Menu
- Control Menu
- Start scene, Credit scene

Texture:
- Updated Planet texture [more brighter too look at]
- Resource texture are all updated to be brighter

Evolution:
- Evolution is more visible
- Model Changes as planet evolve
- Requires different resources to evolve

//End Beta Implementation

To Replicate:
- To see comet tail change, wait till the comet gets close to the sun. [AI]
	- As it gets close the comet will melt and began to show it's tail.
	- As it gets further the comet tail will disapear since it freezes back up.
- To see auto avoidance follow the spaceship named "Anthony" [AI]
	- It will pathfind through the Asteroid Belt and avoid the asteroids
- To see the node pathing follow the spaceship that is flying between blanets and distance red "giant"
	- It will pathfind to the node planets
- On planet Eve, Jeff, and Adam...
	- Animated alien and dinosaurs [Mecanim] 
	
AI:
- Comet Tail: As the comet fly closer to the sun it begans to melt and show its tail. As it flies furthur away the tails disappears [Sean]
- Alien Spaceship: This represent one of the function the NPC AI will have when they are evolve into space era. [Anthony]
- Alien Auto Avoid Spaceship: This represent how the animals will function (chase/hunt) on the planet when it is created. [Jeff]

Mecanim:
- Dying Alien: one of the functions of NPC [Sean]
- Dancing Alien: one of the functions of NPC [Anthony]
- Dinosuars: This will represent one of the evolution state [Jeff]

3D Physics:
- Solar Flares
- Asteroid Belt
- Planet Orbital
- Comet Tail

Lights:
- Sun
- Player
- Distaht Star (Approachable by Player)

Textures:
- Terra Planet
- Lava Planet
- Gas Planet

Sounds:
- Forest sound on Terra Planet
- Thunder sound on Gas Planet
- Lava sound on Lava Planet

Billboards:
- Planet Names

In Progress:
- Camera Detech [Bug]
- Name Tag [Bug]
- Planet Placement Mechanics [RTS]

Postponed:
- Menu [Planet Placement and Evolution Setting]
- Material Collection
- Planet Enironment System

Resources:
- Skybox generated via https://wwwtyro.github.io/space-3d/#animationSpeed=1&fov=80&nebulae=true&pointStars=true&resolution=1024&seed=6bol2hs1gfw0&stars=true&sun=false
- Spaceship via Unity standard asset.
- Planet Texture Generator via https://assetstore.unity.com/publishers/18285
- Alien via https://www.mixamo.com/
