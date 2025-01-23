using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private EventColorButtonChanged[] _buttons;
    [SerializeField] private LineController _lineController;

    private void Start()
    {
        foreach (var button in _buttons)
        {
            button.ColorChanged += _lineController.OnChangeColor;
        }
    }
}
