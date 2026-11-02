using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FontColor : MonoBehaviour
{
    [Range(0f, 1f)]
    public float hueSpeed = 0.2f;
    private Image _image;
    private float _hue;

    void Awake()
    {
        _image = GetComponent<Image>();
        Color.RGBToHSV(_image.color, out _hue, out _, out _);
    }

    void Update()
    {
        _hue += hueSpeed * Time.deltaTime;
        if (_hue > 1f) _hue -= 1f;

        _image.color = Color.HSVToRGB(_hue, 1f, 1f);
    }
}
