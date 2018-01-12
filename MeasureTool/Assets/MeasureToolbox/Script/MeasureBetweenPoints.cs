using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeasureBetweenPoints : MonoBehaviour{


    [SerializeField]
    private Transform _from;
    [SerializeField]
    private Transform _to;

    [Header("Debug (Don't touch)")]
    [SerializeField]
    private float _distance;
    [SerializeField]
    private bool _drawLine;
   

    public float GetDistance() {
        return _distance;
    }


    public void Update()
    {
        _distance = GetDistance(_from, _to);
        if (_drawLine)
            Debug.DrawLine(_from.position, _to.position);
    }




    public static float GetDistance(GameObject from, GameObject to)
    {
        return GetDistance(from.transform.position, to.transform.position);
    }
    public static float GetDistance(Transform from, Transform to)
    {
        return GetDistance(from.position, to.position);
    }
    public static float GetDistance(Vector3 from, Vector3 to) {
        return Vector3.Distance(from, to);

    }

}
