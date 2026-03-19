using UnityEngine;

public class MoneyAdd : MonoBehaviour
{
    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.O))
        {
            SaveManager.instance.money += 50;
            SaveManager.instance.Save();
        }
       else if (Input.GetKeyDown(KeyCode.P))
        {
            SaveManager.instance.money -= 50;
            SaveManager.instance.Save();
        }
    }
}
