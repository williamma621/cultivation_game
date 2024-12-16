using UnityEngine;

public class Actions : MonoBehaviour
{
    private PointsManager PointsManager; // Reference to the ActionPointsManager

    private void Start()
    {
        // Find the ActionPointsManager in the scene
        PointsManager = FindObjectOfType<PointsManager>();

        // Ensure the reference is valid
        if (PointsManager == null)
        {
            Debug.LogError("ActionPointsManager not found in the scene!");
        }
    }

    // Cultivate action
    public void Cultivate()
    {
        if (PointsManager != null)
        {
           
            PointsManager.AddActionPoints(10);
            PointsManager.AddCultivationPoints();
        }
    }
    public void Learn()
    {
        if (PointsManager != null)
        {
            PointsManager.AddLearnLevel(1);
            PointsManager.AddActionPoints(10);
            PointsManager.AddCultivateModifier(1);
        }
    }




}
