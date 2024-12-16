using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class update_action_points : MonoBehaviour
{
   
    public TMP_Text personalText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        personalText.text = $@"
Name: Player
Age: {static_variables.current_year}/{static_variables.max_year}
Days: {static_variables.current_action_point}/365
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
