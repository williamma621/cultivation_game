using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class action_buttons : MonoBehaviour
{
    public Variables variables;
    public UpdateText updateText;


    
    public void cultivate()
    {
        variables.player.Cultivate(variables.cultivatetime);
        string action = "Cultivated for "+ variables.cultivatetime + " days. Earned " + variables.cultivatetime * variables.player.knowledge + " Cultivation points.";
        variables.player.AddHistory(action); // Log the action
        updateText.UpdateHistory();
        updateText.UpdatePersonal();
        Debug.Log(variables.player.xp);
    }
    public void learn(int add_modifier){
        variables.player.knowledge += add_modifier;
        updateText.UpdatePersonal();
        //static_variables.current_speed *= multi_modifier;
        Debug.Log(variables.player.xp);
    }
}
