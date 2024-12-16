using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class action_buttons : MonoBehaviour
{
    public void cultivate(int num_day)
    {
        static_variables.current_action_point += num_day;
        static_variables.current_xp += num_day * static_variables.current_speed;
        Debug.Log(static_variables.current_xp);
    }
    public void learn(int add_modifier){
        static_variables.current_speed += add_modifier;
        //static_variables.current_speed *= multi_modifier;
        Debug.Log(static_variables.current_speed);
    }
}
