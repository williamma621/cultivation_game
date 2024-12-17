using UnityEngine;

public class move_camera : MonoBehaviour
{
    public GameObject mainCamera;
    public void ShowMainUI() {MoveCamera(0f, 0f);}
    public void ShowActions() {MoveCamera(3500f, 0f);}
    public void ShowLearning() {MoveCamera(3500f, 2000f);}
    public void MoveCamera(float x_pos, float y_pos, float z_pos = -1f){
        mainCamera.transform.position = new Vector3(x_pos, y_pos, z_pos); // Set desired position  
    }
}
