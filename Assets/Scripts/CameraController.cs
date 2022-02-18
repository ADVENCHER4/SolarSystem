using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float scaleSensitivity;
    [SerializeField] private float sensitivity;
    
    private void Update()
    {
        var mouseAxisDir = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * sensitivity;
        var wheelScale = Input.GetAxis("Mouse ScrollWheel");
        transform.Translate(0f, 0f, wheelScale * scaleSensitivity);
        transform.RotateAround(Vector3.zero, Vector3.up, mouseAxisDir.x);
    }
}