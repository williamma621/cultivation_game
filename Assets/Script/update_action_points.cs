using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class update_action_points : MonoBehaviour
{
    public TMP_Text action_point;
    public TMP_Text personalText;
    // Start is called before the first frame update
    void Start()
    {
        action_point.text = "行动点：0 / 365";
    }

    // Update is called once per frame
    void Update()
    {
        action_point.text = $"行动点：{static_variables.current_action_point}/365";
        personalText.text = $@"
        Name: Player
        Age: {static_variables.current_year}/{static_variables.max_year}
        Reputation: 
        Morality: 
        Cultivation Points: {static_variables.current_xp}
        Knowledge: {static_variables.current_speed}
        Realm: Qi Gathering Stage
        Gold: 
        Health: 
        Attack: 
        Defense: 
        Mana: 


        ";
    }
}
