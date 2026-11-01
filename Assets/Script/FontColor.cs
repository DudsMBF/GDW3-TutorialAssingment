using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FontColor : MonoBehaviour
{
    public Button button;

    private Color newColor;
    
    private ColorBlock buttonColor;

    public float cycleSpeed = 1f;

    private float hue = 0f;
    private float r = 1f;
    private float g = 0f;
    private float b = 0f;

    void Start()
    {

        buttonColor = button.GetComponent<Button>().colors;
    }

    void Update()
    {
        ChangeColor();
    }

    void ChangeColor()
    {
        ColorBlock colorBlock = buttonColor;

        hue *= cycleSpeed * Time.deltaTime;


        if (hue > 1f) {hue = 0f;}

        newColor = Color.HSVToRGB(hue, 1, 1);

        colorBlock.normalColor = newColor;

        buttonColor = colorBlock;
    }

    void SetWheelColor()
    {
        if (r == 1f && g == 0)
        {
            b += cycleSpeed * Time.deltaTime;

        } else if (r == 1f && g > 0)
        {
            g -= Time.deltaTime;
        }
        if (b == 1f && r > 0)
        {
            r -= cycleSpeed * Time.deltaTime;

        } else if (b == 1f && r == 0)
        {
            g += cycleSpeed * Time.deltaTime;

        }
        if (g == 1f && b > 0)
        {
            b -= cycleSpeed * Time.deltaTime;
        } else if (g == 1f && b == 0)
        {
            r += cycleSpeed * Time.deltaTime;
        }
    }
}
