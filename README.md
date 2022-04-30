# Space-War
# Description
- Luka Mumelas
- C19331903
- TU984 / DT508
- A fanmade imaginary creation of a space battle inspired by Starset lore. The ships are autonomous agents and the scene runs completely by itself. The ending of the battle is always random as all ships operate autonomously.

# Videos
Video Demo:
[insert video link here]

[Scene and story inspiration](https://www.youtube.com/watch?v=-u4AwQGLEsE)

# Most proud of
I'm very proud of explosion particles and the cutscenes since it adds so much more juice to the project

# Events Summary
1. Camera moves sideways to show the Rebel capital ship
2. Camera moves sideways to show the New East capital ship
3. Both capital ships are shown from aerial perspective
4. New East capital ship releases its fighters
5. Rebel capital ship releases its fighters
6. Camera randomly switches POV from both Rebel fighters and New East fighters
7. If Rebels destroy all New East fighters, camera shows the New East capital ship exploding (good ending)
8. If New East destroys all Rebel fighters, camera shows the Rebel capital ship exploding (bad ending)

# How it works
## Sequence
- There is a timeline game object that acts like a game manager. It plays the intro cutscene which was made using Unity's in built timeline feature
- The timeline feature animates different camera viewpoints and activates both New East and Rebel Flocks at certain times within the timeline
- Timeline game object also has a Camera Switch component that stores all fighter POV cameras in an array that randomly turns on a different POV at set interval

## AI
- ***Flock***:
  - Spawns fighter prefabs with delay based on "starting count" variable
  - Holds a public composite behaviour variable that determines what behaviours fighters have
  - Finds all nearby objects for each fighter
  - Controls weight variables such as drive factor, maximum speed, neighbour radius and avoidance radius multiplier
- ***Flock Agent***:
  - Holds health and damage variables
  - Finds anc checks if an enemy is within range and shoots it at set intervals
  - Continously moves the fighter with respect to behaviours attached to it
- ***Same Flock Filter***: Finds fighters of same tag so that they don't group with opposing fighters
- ***Physics Layer Filter***: Makes a list of game objects with a specific layer mask for fighters to avoid

## Behaviours
- ***Alignment***: Adds all points together, averages and places the fighter into a flock if there are other fighters nearby
- ***Avoidance***: Avoids game objects that are too close to the fighter
- ***Cohesion***: Adds all points together, averages and creates offset from fighter position
- ***Avoid Obstacle***: Avoids game objects with a specific layer mask
- ***Stay In Radius***: Keeps the fighter inside a set radius so it doesn't drift off
- ***Steered Cohesion***: Adds all points together, averages and creates offset from fighter position with smooth dampening

## Design
- Particle systems
  - Explosion plays when a fighter is destroyed. Explosions also play when a capital ship is destroyed - these explosions are random in scale and are spawned randomly inside predetermined square
  - Blaster effect plays when the fighter attacks

- Skybox uses space textures

# How to use
- Open the project and play the scene
- New East Flock and Rebel Flock game objects have some public sliders that affect certain aspects, most notably how many fighters will spawn form each flock
- Press R to reload the scene

# Classes
| Class.cs | How it was written |
| --- | --- |
| CameraSwitch | Written myself |
| ContextFilter | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| DestroyMe | Written myself |
| FilteredFlock | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| Flock | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| FlockAgent | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| FlockBehvaiour | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| AlignmentBehvaiour | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| AvoidanceBehaviour | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| CohesionBehaviour | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| CompositeBehaviour | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| StayInRadiusBehaviour | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| SteeredCohesionBehaviour | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| CompositeBehaviourEditor | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| PhysicsLayerFilter | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| SameFlockFilter | Modified from [here](https://www.youtube.com/watch?v=mjKINQigAE4&list=PL5KbKbJ6Gf99UlyIqzV1UpOzseyRn5H1d) |
| ReloadScene | Written myself |
| CapitalShip | Written myself |

# Storyboard
![ald text](https://github.com/Etternium/Space-War/blob/main/Storyboard%20Scenes.png?raw=true)

# Resources
- [Skybox](https://assetstore.unity.com/packages/2d/textures-materials/sky/free-skyboxes-space-178953)
- Ships
  - [New East fighter](https://sketchfab.com/3d-models/isu-70-3e861556f3674efc802d6cd4ee2e6feb)
  - [Rebel fighter](https://sketchfab.com/3d-models/pirate-hunter-d8c7df95b9614390bc4d907172cd3e9d)
  - [New East capital ship](https://sketchfab.com/3d-models/procedural-spaceship-eb8377b30bfd419583d935e6a7dba45a)
  - [Rebel capital ship](https://sketchfab.com/3d-models/mothership-896f36009f2d41878d01a855ae09eb12)
