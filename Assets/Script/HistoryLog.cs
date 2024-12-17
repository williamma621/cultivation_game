using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HistoryLog : MonoBehaviour
{
    public ScrollRect scrollRect;         // Reference to the ScrollRect component
    public TextMeshProUGUI historyText;   // Reference to the Text component
    private bool autoScroll = true;       // Auto-scrolling enabled by default

    void Start()
    {
        historyText.text = ""; // Clear history at the start
    }

    void Update()
    {
        // Auto-scroll to the bottom unless the player is scrolling manually
        if (autoScroll)
        {
            scrollRect.verticalNormalizedPosition = 0f;
        }
    }

    public void AddHistory(string action)
    {
        // Append the new action to the history text
        historyText.text += action + "\n";

        // Resize the content height based on text size
        LayoutRebuilder.ForceRebuildLayoutImmediate(historyText.rectTransform);

        // Enable auto-scroll to always show the latest action
        autoScroll = true;
    }

    public void OnScroll()
    {
        // Detect if the player is scrolling manually
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            autoScroll = false; // Stop auto-scrolling when the player scrolls
        }
    }
}
