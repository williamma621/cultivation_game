using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class action_buttons : MonoBehaviour
{
    public Check check;
    public Variables variables;
    public HistoryLog historyLog;
    public void cultivate(int num_day)
    {
        variables.current_action_point += num_day;
        int a = num_day * variables.current_speed;
        variables.current_xp += a;
        check.checkdays();
        variables.action = "Cultivated for "+ num_day + " days. Earned " + a +" Cultivation points.";
        historyLog.AddHistory(variables.action); // Log the action
        Debug.Log(variables.current_xp);
    }
    public void learn(int add_modifier){
       variables.current_speed += add_modifier;
        //static_variables.current_speed *= multi_modifier;
        Debug.Log(variables.current_speed);
    }
}
