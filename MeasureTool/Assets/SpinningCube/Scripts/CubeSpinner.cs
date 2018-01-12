using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpinner : MonoBehaviour
{
    private Transform m_thisCube;

    [SerializeField]
    [Range(0f, 360.0f)]
    private float m_rotationSpeedX;
    [SerializeField]
    [Range(0f, 360.0f)]
    private float m_rotationSpeedY;
    [SerializeField]
    [Range(0f, 360.0f)]
    private float m_rotationSpeedZ;

    public void RotateCube(float _x, float _y, float _z)
    {
                m_thisCube.Rotate(new Vector3(_x, _y, _z));
    }

	// Use this for initialization
	void Start ()
    {
        m_thisCube = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        RotateCube(m_rotationSpeedX*Time.deltaTime, m_rotationSpeedY * Time.deltaTime, m_rotationSpeedZ * Time.deltaTime);
	}
}
