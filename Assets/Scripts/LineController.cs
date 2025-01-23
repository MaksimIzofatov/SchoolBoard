using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineController : MonoBehaviour
{
    [SerializeField] private Line _line;
    [SerializeField] private CircleMouse _mouse;
    [SerializeField] private float _deep = 10f;
    
    private Line _currentLine;
    private List<Line> _lines;
    private Camera _camera;
    private Color _nextColor;

    private void Awake()
    {
        _lines = new();
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateNewLine();
        }

        if (Input.GetMouseButton(0))
        {
            var mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _deep);
            var position =  _camera.ScreenToWorldPoint(mousePos);
            
            _currentLine.AddPosition(position);
        }
    }

    private void CreateNewLine()
    {
        _currentLine = Instantiate(_line);
        _currentLine.ChangeColor(_nextColor);
        _lines.Add(_currentLine);
    }

    public void ClearAllLines()
    {
        foreach (var line in _lines)
        {
            if(line != null)
                Destroy(line.gameObject);
        }
    }

    public void OnChangeColor(Image image)
    {
        _nextColor = image.color;
        _mouse.ChangeColor(image.color);
    }
}
