using UnityEngine;

public class menu_buttons : MonoBehaviour
{
    public GameObject mainCamera;
    public void ShowMainUI()
    {
        mainCamera.transform.position = new Vector3(0f, 0f, -1f); // Set desired position
    }
    // Load the Actions Scene
    public void ShowActions()
    {
        mainCamera.transform.position = new Vector3(3500f, 0f, -1f); // Set desired position  
    }
    // Load the Learning Scene
    public void ShowLearning()
    {
        mainCamera.transform.position = new Vector3(3500f, 2000f, -1f); // Set desired position  
    }
}
