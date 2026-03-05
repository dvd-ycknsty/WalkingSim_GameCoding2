using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPickup : MonoBehaviour
{
    [SerializeField] Hungerbar hungerbar;
    [SerializeField] Thirstbar thirstbar;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hungerbar.hunger += 50f;
                thirstbar.thirst += 50f;
                Destroy(gameObject);
            }
        }
    }

}
