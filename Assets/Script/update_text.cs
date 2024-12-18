using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class update_text : MonoBehaviour
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
        personalText.text = variables.player.ToString();
    }
}