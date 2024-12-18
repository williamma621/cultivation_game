using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class action_buttons : MonoBehaviour
{
    public Variables variables;
    public HistoryLog historyLog;


    
    public void cultivate()
    {
        variables.player.Cultivate(variables.cultivatetime);
        string action = "Cultivated for "+ variables.cultivatetime + " days. Earned " + variables.cultivatetime * variables.player.knowledge + " Cultivation points.";
        historyLog.AddHistory(action); // Log the action
        Debug.Log(variables.player.xp);
    }
    public void learn(int add_modifier){
        variables.player.knowledge += add_modifier;
        //static_variables.current_speed *= multi_modifier;
        Debug.Log(variables.player.xp);
    }


}
