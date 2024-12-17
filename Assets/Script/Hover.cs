using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject hoverPanal;
    public TextMeshProUGUI tipText; // Assign the Text component
    [TextArea] public string tooltipMessage;

    public void OnPointerEnter(PointerEventData eventData)
    {
        hoverPanal.SetActive(true);
        tipText.text = tooltipMessage;
        UpdatetipPosition();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
        
            hoverPanal.SetActive(false); // Hide the tooltip
     }
    private void UpdatetipPosition()
    {
        // Move the tooltip to follow the mouse (optional)
        Vector2 mousePosition = Input.mousePosition;
        hoverPanal.transform.position = mousePosition + new Vector2(300, 0); // Offset for better visibility
    }
}
