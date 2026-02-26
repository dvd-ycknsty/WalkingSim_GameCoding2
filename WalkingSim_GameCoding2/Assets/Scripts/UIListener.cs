using TMPro;
using UnityEngine;

public class UIListener : MonoBehaviour
{
    public TextMeshProUGUI statusText;

    public void OnEnable()
    {
        ButtonEvent.onButtonPressed += UpdateText;
    }

    public void OnDisable()
    {
        ButtonEvent.onButtonPressed -= UpdateText;
    }
    void UpdateText()
    {
        statusText.text = "Button Pressed";
    }
}
