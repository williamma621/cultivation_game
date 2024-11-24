using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
  

    // Scene Navigation Methods

    // Load the Main Menu Scene
    public void ShowMain()
    {
        SceneManager.LoadScene("MainUI");
    }

    // Load the Personal Stats Scene
    public void ShowPersonal()
    {
        SceneManager.LoadScene("PersonalUI");
    }

    // Load the Actions Scene
    public void ShowActions()
    {
        SceneManager.LoadScene("ActionsUI");
    }

    // Load the Relationships Scene
    public void ShowRelationships()
    {
        SceneManager.LoadScene("RelationshipsUI");
    }

    // Load the Map Scene
    public void ShowMap()
    {
        SceneManager.LoadScene("MapUI");
    }

    // Quit the Game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit"); // Debugging in the Unity Editor
    }


}
