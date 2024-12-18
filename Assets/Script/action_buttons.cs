using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class action_buttons : MonoBehaviour
{
    public Variables variables;
    public HistoryLog historyLog;
    public void cultivate(int num_day)
    {
        variables.player.Cultivate(num_day);
        string action = "Cultivated for "+ num_day + " days. Earned " + num_day * variables.player.xp +" Cultivation points.";
        historyLog.AddHistory(action); // Log the action
        Debug.Log(variables.player.xp);
    }
    public void learn(int add_modifier){
        variables.player.knowledge += add_modifier;
        //static_variables.current_speed *= multi_modifier;
        Debug.Log(variables.player.xp);
    }
}
