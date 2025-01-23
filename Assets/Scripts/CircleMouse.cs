using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleMouse : MonoBehaviour
{
    private Camera _camera;
    private RectTransform _transform;
    private Image _image;
    private void Awake()
    {
        _camera = Camera.main;
        _transform = GetComponent<RectTransform>();
        _image = GetComponent<Image>();
    }

    private void Update()
    {
        var position = _camera.ScreenToWorldPoint(Input.mousePosition);
        _transform.position = new Vector3(position.x, position.y);
    }

    public void ChangeColor(Color color)
    {
        _image.color = color;
    }
}
