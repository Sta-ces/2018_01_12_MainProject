using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo_MeasureTools : MonoBehaviour{

    public Transform _a;
    public Transform _b;



    public void Update()
    {
       
        Debug.Log("Dist:" + MeasureBetweenPoints.GetDistance(_a, _b));

    }





}
