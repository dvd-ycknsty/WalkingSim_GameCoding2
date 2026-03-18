using System;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    //action is a delegate
    //a delegate is a var that can store a function
    //int number vs action myfunction
    //can be used by anyone
    //statis belongs to the class itself, not a specific instance
    //meaning we dont need a specific reference to a specific game object
    //you can just += indtead of findobjectoftype

    //event is a special type of delegate
    //it is protected if you do this without event it can break
    //other scripts can subscribe and unsub but they cannot invoke it
    public static event Action onButtonPressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void OnButtonPressed()
    {
        //invoke = call every function subscribed to this event
        //?. only do this if it isnt null(if someone is listening)
        onButtonPressed?.Invoke();
    }
}
