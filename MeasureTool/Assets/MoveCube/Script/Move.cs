using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float unitePerSec = 1f;
    private Vector3 newPos = Vector3.zero;



    void Start()

    {

        newPos = transform.position;  //position de depart

    }

    void Update()

    {

        float speed = unitePerSec * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow))

        {

            newPos.z += speed;

        }

        if (Input.GetKey(KeyCode.DownArrow))

        {

            newPos.z -= speed;

        }

        if (Input.GetKey(KeyCode.LeftArrow))

        {

            newPos.x -= speed;

        }

        if (Input.GetKey(KeyCode.RightArrow))

        {

            newPos.x += speed;

        }
        transform.position = newPos;  //si je ne touche a rien je garde ma position
    }
}
