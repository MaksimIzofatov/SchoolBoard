using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventColorButtonChanged : MonoBehaviour
{
    public event Action<Color> ColorChanged;
    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    public void ColorChange()
    {
        ColorChanged?.Invoke(_image.color);
    }
}
