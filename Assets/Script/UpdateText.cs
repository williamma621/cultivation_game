using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UpdateText : MonoBehaviour
{
    public Variables variables;
    public TMP_Text personalText;
    public TextMeshProUGUI historyText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdatePersonal(){
        personalText.text = variables.player.ToString();
    }

    public void UpdateHistory(string action)
    {
        historyText.text = variables.player.history;
    }
}