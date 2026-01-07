# Devlogs
## W1
### Activity 1
- Advice (from table 6 and others): don't procrastinate, read instructions carefully, ask questions if you don't completely understand, make sure your Itch.io link works (by sending it to friends!), playtest your build on Itch.io, not just Unity

### Activity 2
1. What is the value of x after these lines of code?
```c#
int x = 2;
x *= 5;
```
- value of x is 10

2. What is the value of x after these lines of code?
```c#
int x = 0;
for(int i = 0; i < 2; i++)
{
    x += 1;
}
```
- value of x is 2

3. What do these lines of code do?
```c#
private void Update () {
    PrintMessage();
}

private void PrintMessage () {
    Debug.Log(“hello world”);
}
```
- every frame during gameplay, prints "hello world" in the Unity debug console

4. What kind of classes are the Update and Debug.Log methods usable in? I.e., what should replace the ???s ?
```c#
public class Example : ??? {
    private void Update () {
        PrintMessage();
    }
    private void PrintMessage () {
        Debug.Log(“hello world”);
    }
}
```
- Update and Debug.Log are usable in MonoBehaviour classes (replace the ??? with MonoBehaviour)

5. What do these lines of code do?
```c#
private void Start () {
    PrintMessage(10);
}
    private void PrintMessage (int x) {
        Debug.Log(“x = ” + x);
}
```
- upon starting the game, calls `PrintMessage` once with argument 10. PrintMessage then prints "x = 10" in the Unity debug console

6. What are the name & purpose of these highlighted lines of code?
```c#
private void Start () {
    PrintMessage(10); // <-
}
    private void PrintMessage (int x) {
        Debug.Log(“x = ” + x); // <-
}
```
- 10 is an argument passed into the function called PrintMessage. Debug.Log is a function call, using the 10 passed in to print a custom output made using string concatenation.

7. What's wrong with this code?
```c#
public class Example : MonoBehaviour {
    public Transform _playerTransform;
    public Vector3 _direction;
    private void Update () {
        Transform.Translate(_direction);
    }
}
```
- Update() is calling Translate() on Transform, which is not an object. It causes an error. You could fix it by calling Translate() on an object reference (eg: _playerTransform)

8. What should we change in the highlighted code to fix this?
```c#
public class Example : MonoBehaviour {
    public Transform _playerTransform;
    public Vector3 _direction;
    private void Update () {
        Transform.Translate(_direction); // <-
    }
}
```
- Change 'Transform' in the highlighted code to '_playerTransform'.

### Activity 3
[Google Doc](https://docs.google.com/document/d/1A1lkqSfYbcQn9UN1hMjbRY7x2fuXZEa0aiapVb3bzUQ/edit?tab=t.0)

## W2
