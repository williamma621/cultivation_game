using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cultivateTime : MonoBehaviour
{
    public Variables variables;
    public void CultivateTime(int index)
    {

        switch (index)
        {
            case 0: variables.cultivatetime = 1; Debug.Log(variables.cultivatetime); break;
            case 1: variables.cultivatetime = 31; Debug.Log(variables.cultivatetime); break;
            case 2: variables.cultivatetime = 365; Debug.Log(variables.cultivatetime); break;
            case 3: variables.cultivatetime = 3650;  break;
            case 4: variables.cultivatetime = 36500; break;
        }

    }
  
}
