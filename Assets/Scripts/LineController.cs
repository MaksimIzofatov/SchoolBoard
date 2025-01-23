using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    [SerializeField] private Line _line;
    [SerializeField] private CircleMouse _mouse;
    [SerializeField] private float _deep = 10f;

    private Vector3 _position = Vector3.zero;
    private Line _currentLine;
    private List<Line> _lines;
    private Camera _camera;

    private void Awake()
    {
        _lines = new();
        _camera = Camera.main;
    }

    private void Update()
    {
        if(_currentLine == null) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            _lines.Add(_currentLine);
            _currentLine = null;
        }

        if (Input.GetMouseButton(0))
        {
            var position = _camera.ScreenToWorldPoint(Input.mousePosition);
            _position.x = position.x;
            _position.y = position.y;
            _position.z = _deep;
            
            _currentLine.AddPosition(_position);
        }
    }

    public void OnChangeColor(Color color)
    {
        _mouse.ChangeColor(color);
        _currentLine = Instantiate(_line);
        _currentLine.ChangeColor(color);
    }
}
