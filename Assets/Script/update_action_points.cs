using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class update_action_points : MonoBehaviour
{
   
    public TMP_Text personalText;
    public Variables variables;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        personalText.text = $@"
Name: Player
Age: {variables.current_year}/{variables.max_year}
Days: {variables.current_action_point}/365
Reputation: 
Morality: 
Cultivation Points: {variables.current_xp}
Knowledge: {variables.current_speed}
Realm: Qi Gathering Stage
Gold: 
Health: 
Attack: 
Defense: 
Mana: 


        ";
    }
}
