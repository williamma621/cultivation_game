using UnityEngine;
using TMPro;

public class PointsManager : MonoBehaviour
{
    //Action Points Var
    public int maxActionPoints = 365; // Maximum points in a year
    private int currentActionPoints = 0; // Current points spent
    private int currentYear = 1; // Starting year
    public int maxAge = 80;

    //Cultivation Points Var
    public int cultivationPoints = 0; // Total cultivation points
    public int learnLevel = 0; // Total cultivation points
    public int cultivateModifier = 0;


    //Text GameObjects
    public TMP_Text actionPointsText; // Text for action points UI
    public TMP_Text learnButtonText; // Reference to the button's text component
    public TMP_Text personalText; // Text for cultivation points UI

    private void Start()
    {
        UpdateActionPointsUI(); // Initialize action points UI
        UpdatePersonalText(); // Initialize cultivation points UI
        UpdateLearnButtonUI();
     
    }

    // Method to add action points
    public void AddActionPoints(int amount)
    {
        currentActionPoints += amount;

        if (currentActionPoints >= maxActionPoints)
        {
            currentActionPoints -= maxActionPoints; // Carry over extra points
            currentYear++; // Increment the year
        }

        UpdateActionPointsUI();
    }

    // Method to add cultivation points
    public void AddCultivationPoints()
    {
        cultivationPoints += cultivateModifier;
        UpdatePersonalText();
    }
    public void AddLearnLevel(int amount)
    {
        learnLevel += amount;
        UpdateLearnButtonUI();
    }
    public void AddCultivateModifier(int amount)
    {
        cultivateModifier += amount;
        UpdatePersonalText();
        Debug.Log(cultivateModifier);
        
    }


    //UPDATES THE POINT--------------------------------------------------------------------------------------- 
    // Updates the action points UI
    private void UpdateActionPointsUI()
    {
        if (actionPointsText != null)
        {
            actionPointsText.text = $"{currentActionPoints}/{maxActionPoints} - 第{currentYear}年";
        }
    }

    // Updates the cultivation points UI
  
    private void UpdateLearnButtonUI()
    {
      learnButtonText.text = $"修炼功法 - 10 ({learnLevel})";
       
    }
   
    private void UpdatePersonalText()
    {
        if (personalText != null)
        {
            personalText.text = $@"
Name: Player
Age: {currentYear}/{maxAge}
Reputation: 
Morality: 
Cultivation Points: {cultivationPoints}
Knowledge: {cultivateModifier}
Realm: Qi Gathering Stage
Gold: 
Health: 
Attack: 
Defense: 
Mana: 


";//end of the player string
        }
    }

}
