using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScale : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.localScale += new Vector3(0.1f, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.localScale -= new Vector3(0.1f, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.localScale += new Vector3(0, 0.1f, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.localScale -= new Vector3(0, 0.1f, 0);
    }
}
