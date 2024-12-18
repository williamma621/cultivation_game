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
        
    }

    public void AddHistory(string action)
    {
        // Append the new action to the history text
        historyText.text += action + "\n";

      
    }

    
}
