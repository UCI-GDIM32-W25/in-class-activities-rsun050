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
[Google Doc](https://docs.google.com/document/d/1A1lkqSfYbcQn9UN1hMjbRY7x2fuXZEa0aiapVb3bzUQ/edit?tab=t.0)

## W2
