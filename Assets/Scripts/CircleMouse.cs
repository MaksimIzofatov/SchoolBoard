using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleMouse : MonoBehaviour
{
    private Camera _camera;
    private Image _image;
    private void Awake()
    {
        _camera = Camera.main;
        _image = GetComponent<Image>();
    }

    private void Update()
    {
        var position = _camera.ScreenToWorldPoint(Input.mousePosition);
        position.z = 10;
        transform.position = position;
    }

    public void ChangeColor(Color color)
    {
        _image.color = color;
    }
}
