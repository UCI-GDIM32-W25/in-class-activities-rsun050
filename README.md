# Devlogs
## W1
### Activity 1
- Advice (from table 6 and others): don't procrastinate, read instructions carefully, ask questions if you don't completely understand, make sure your Itch.io link works (by sending it to friends!), playtest your build on Itch.io, not just Unity

### Activity 2
1. 10
2. 2
3. Every frame during gameplay, prints "hello world" in the Unity debug console
4. Update and Debug.Log are usable in MonoBehaviour classes (replace the ??? with MonoBehaviour)
5. Upon starting the game, calls `PrintMessage` once with argument 10. PrintMessage then prints "x = 10" in the Unity debug console
6. 10 is an argument passed into the function called PrintMessage. Debug.Log is a function call, using the 10 passed in to print a custom output made using string concatenation
7. Update() is calling Translate() on Transform, which is not an object. It causes an error. You could fix it by calling Translate() on an object reference (eg: _playerTransform)
8. Change 'Transform' in the highlighted code to '_playerTransform'. This makes Translate() be called on a proper object reference.

### Activity 3
&emsp;[Google Doc](https://docs.google.com/document/d/1A1lkqSfYbcQn9UN1hMjbRY7x2fuXZEa0aiapVb3bzUQ/edit?tab=t.0)

## W2
### Activity 1
<img width="2388" height="1668" alt="image" src="https://github.com/user-attachments/assets/5a73c662-733d-4695-8a39-8b021816683d" />

### Activity 2
Things I did ([Commit link](https://github.com/UCI-GDIM32-W25/mg2-oop-review-rsun050/commit/1331c89c4ac9d86e73e45947636c0ae84dd522d3)):
- built the scene
  - floor: SpriteRenderer + Collider2D
  - coin: SpriteRenderer + Collider2D (trigger)
  - player: SpriteRenderer + RigidBody2D + Collider2D
  - canvas (UI), barrier for destroying missed coins: Collider2D
- coded scripts
  - player jumping (made sure to only let player jump when touching ground) + coin collecting
  - coin movement and despawning
  - updating UI when getting coin
  - spawning coins at random intervals

## W3
### Activities 0-2
Partner: Armando Topete

### Activity 3
<img width="2388" height="1668" alt="image" src="https://github.com/user-attachments/assets/7359f947-02bf-4559-8859-c46116781396" />

## W4
### Activity 0
Partner: Armando Topete

### Activity 1
- When multiple `Locator` objects are in the Scene, the code we wrote in `Locator.Awake()` deletes the extra `Locator` script components, leaving just one in the Scene. (The `GameObjects` the scripts are attached to stay, but the script components vanish). This behaviour is desired and intended, since our `Locator` instance is `static`, meaning we only want one instance in the scene at any time.

### Activity 2
<img width="2896" height="1468" alt="image" src="https://github.com/user-attachments/assets/5b178322-c123-4d19-8308-cb0b69182125" />

### Activity 3
I imported the assets and set up the sprite settings + sliced the sprites. [(Commit)](https://github.com/rsun050/HW4/commit/6a0688bf7a21e328f0726826800f8d9597026539)

## W5
### Activity 1
I'm not sure breakability needs to be a separate interface. It certainly works, but I'm thinking maybe `Break()` could have a default method in `Item` and simply not require every child class to override it. Child classes could decide if they ever want to call `Break()` or not. I also don't like the durability and durability loss being hard-coded here, that might be better as a ScriptableObject instead.

### Activity 2
Model - game data: the ScriptableObject classes for `Item` and `EnemyStats`: item names, enemy dialogue<br>
View - view: visuals and results: `InventoryUI` and `DialogueBubble`: text and sprites appearing on screen<br>
Controller - game logic: `Player` and `Enemy` classes: movement, detect collision<br>

### Activity 3
#### Rhythm Game Scenario
ScriptableObject can be used to define beat data for each song.

Event could be used to update the score UI, or the UI could be a singleton so that any Object can easily update the score.

#### Team Shooter Scenario

Singleton can be used for the Player so that other classes can easily do things like decrease the Player's health.

Different types of weapons (eg: ranged vs melee) can inherit from a single Weapon class.

Model/View/Controller:
Model: ScriptableObject can be used to define weapon statistics. <br>
View: Canvas and Animator can be used to show HUD, player/weapon animations <br>
Controller: Player class and controls <br>

#### Farming Game Scenario
Singleton: usable for the Player, to define their Inventory

FSM & Enums: can be used to define which sprite to show for a crop at each growth phase
- example enum: Seed, Seedling, Shoot, Budding, Mature

ScriptableObject can be used to define data (MVC - Model):
- how long it takes a plant to grow
- durability
- yield/drop table
- how much an item sells for

Rock and Plant class (MVC - Controller):
- extend Monobehaviour and have the fields:
  - data from ScriptableObject
  - SpriteRenderer
  - Animator (for Plants)
- extend IBreakable and define the functions:
  - OnBreak()

### Activity 4
In attendance: Ruth Sun, Armando Topete, Michael A. Lopez

[Final Project Proposal First Draft](https://docs.google.com/document/d/1Ax2Mq7j3RwbZEpmFtbBaP7coQjp67ePpT8dRNFPnmxk/edit?tab=t.0#heading=h.wcm5jag04eng)

## W6
### Activity 1
I didn't know about the Profiler, so if we run into performance issues it'll definitely be helpful. The Gizmos will also be helpful for seeing where the player is looking around and where clicks are 'landing' on in 3D.

### Activity 2
In attendance: Ruth Sun, Armando Topete, Michael A. Lopez<br>
[Final Project Proposal Final Draft](https://docs.google.com/document/d/1Ax2Mq7j3RwbZEpmFtbBaP7coQjp67ePpT8dRNFPnmxk/edit?usp=sharing)
<hr>

## W7
### Activity 1
W7_Demo Notes:<br>
Raycast - draw a ray from a point in a direction, see what it hits first (like shining a laser). Function returns true/false, but raycast hit information is actually returned in the `out` parameter

Spherecast - cast a sphere along a ray, see what it hits first. can be used in place of ray for things like "will a thing of size be able to fit through here?".

### Activity 2
In attendance: Ruth Sun, Armando Topete, Michael A. Lopez

### Activity 3
<img width="960" height="720" alt="handy dandy breakdown" src="https://github.com/user-attachments/assets/fdbf2204-7dca-41a1-9dbf-530d4eb262ab" />

### Activity 4
[Trello Board](https://trello.com/b/Dfl5L4Mu/handy-dandy)

Assigned tasks:<br>
Ruth: Player class, GameController class, Hands/Inventory classes, the ability/feature to look at and pick stuff up <br>
Armando: UI <br>
Michael: World terrain, Apple Tree Model, Blacksmith Model<br>

### Activity 5
[Commit](https://github.com/rsun050/handy-dandy/commit/68595a2ae4af336fb57ff223155c73fb2a48733e)<br>
Started work on player movement

## W8
### Activity 1
Notes:<br>
Postprocessing - making the game look pretty, stuff like bloom, filters, transformative stuff like warps, ripples, etc<br>
If you want to use postprocessing add the Postprocessing System from Unity package manager. Make sure any shaders you're using still 'work' on web

### Activity 2
In attendance: Ruth Sun, Armando Topete, Michael A. Lopez

### Activity 3
Playtesting: buddy team: nameless :D<br>
Captain: Michael

Comments:
Make the mouse sensitivity start out lower, and give the player to open a Settings menu where they can adjust their mouse sensitivity accordingly. Add more to do in the game, like a lake and cave in the back of the village. Add some more environmental props like bushes or wild-life. Fix the bug where looking at an object for the first time makes your mouse freak out.

### Activity 4
Overall we're about 1/4 of the way there. We have a walking simulator right now but once we replace item placeholders, code NPCs, and detail the world the game should look pretty close to finished. Should be able to finish as planned.

Task I'm going to work on today: picking items up

### Activity 5
[Commit](https://github.com/rsun050/handy-dandy/commit/7fa0196d521eaddfe13e8f410c98faeb3488b63d)<br>
Started work on inventory manager and picking up items feature
