using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class FoodPickup : Interactable
{

    private Hungerbar hungerbar;
    private Thirstbar thirstbar;

    public override void Interact(Player player)
    {
        Debug.Log("interacting food pickup");
        UpHunger();
        Debug.Log("Called up hunger");
    }
    

    public void UpHunger()
    {
        hungerbar = FindAnyObjectByType<Hungerbar>();
        thirstbar = FindAnyObjectByType<Thirstbar>();
        hungerbar.hunger += 50f;
        thirstbar.thirst += 50f;
        Destroy(gameObject);
        Debug.Log("destroyed");
    }

}
