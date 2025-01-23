using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    private LineRenderer _line;

    private void Awake()
    {
        _line = GetComponent<LineRenderer>();
    }

    public void AddPosition(Vector3 position)
    {
        _line.positionCount++;

        _line.SetPosition(_line.positionCount - 1, position);
    }

    public void ChangeColor(Color color)
    {
        _line.colorGradient.colorKeys[0].color = color;
    }
}
