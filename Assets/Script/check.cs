using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
 
    public void checkdays()
    {
        
      if (static_variables.current_action_point >= 365)
      {
            static_variables.current_action_point -= 365;
            static_variables.current_year += 1;

       }


        
    }
}