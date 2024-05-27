using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float sensitivity = 2.0f;

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        float rotationHorizontal = Input.GetAxis("Mouse X") * sensitivity;
        float rotationVertical = Input.GetAxis("Mouse Y") * sensitivity;
        transform.Rotate(0, rotationHorizontal, 0);
        Camera.main.transform.Rotate(-rotationVertical, 0, 0);
    }
}

