using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action_buttons : MonoBehaviour
{
    public void cultivate(int num_day)
    {
        static_variables.player.Cultivate(num_day);
        Debug.Log(static_variables.player.xp);
    }
    public void learn(int add_modifier){
        static_variables.player.knowledge += add_modifier;
        //static_variables.current_speed *= multi_modifier;
        Debug.Log(static_variables.player.knowledge);
    }
}
