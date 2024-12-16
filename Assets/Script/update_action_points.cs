using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class update_action_points : MonoBehaviour
{
    public TMP_Text action_point;
    // Start is called before the first frame update
    void Start()
    {
        action_point.text = "行动点：0 / 365";
    }

    // Update is called once per frame
    void Update()
    {
        action_point.text = $"行动点：{static_variables.current_action_point}/365";
    }
}
