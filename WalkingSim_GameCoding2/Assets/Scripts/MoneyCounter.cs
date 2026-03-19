using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour
{
    private Text txt;

    private void Awake()
    {
        txt.GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
     txt.text = SaveManager.instance.money + "$";
    }
}
