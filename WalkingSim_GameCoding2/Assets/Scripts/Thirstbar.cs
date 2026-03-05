using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Thirstbar : MonoBehaviour
{
    public Slider thirstSlider;

    public float thirst;
    float maxThirst = 100f;

    void Start()
    {
        thirst = maxThirst;
    }

    // Update is called once per frame
    void Update()
    {
        thirstSlider.value = thirst;

        thirst -= 1f * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            thirst -= 1f * Time.deltaTime;
        }
    }
}
