using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevel : MonoBehaviour
{

    public float sensitivity = 0.8f;

    private Vector3 mouse_Reference;
    private Vector3 mouse_Offset;
    private Vector3 rotation;

    private bool isRotating;

    // Update is called once per frame
    void Update()
    {

        if (isRotating)
        {

            mouse_Offset = Input.mousePosition - mouse_Reference;
            rotation.y = -(mouse_Offset.x + mouse_Offset.y) * sensitivity;

            transform.Rotate(rotation);

            mouse_Reference = Input.mousePosition;

        }

    }

    void OnMouseDown()
    {

        isRotating = true;

        mouse_Reference = Input.mousePosition;

    }

    void OnMouseUp()
    {
        isRotating = false;
    }


} // class
