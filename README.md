# Snippets
MiniMaps: create a small window to view the  playing area from above. 

# Scenes
We have the SampleScene, and create two new scenes: Intro and Exit.
In all three scenes, add buttons (Gameobject, UI, button). This automatically inserts a canvas too. Rename them Play, StopPlaying, PlayAgain and ExitGame.
In Assets, create a SceneManager script. Create four functions: StartPlay, StopPlaying, PlayAgain, ExitGame. 
Add using UnityEngine.SceneManagement; and code each function as "SceneManager.LoadScene("name of scene");   and for the ExitGame funtion "UnityEditor.EditorApplication.isPlaying = false;"
Add the Scenes script to all buttons.
For each button, add the button as the object and select the function. 

