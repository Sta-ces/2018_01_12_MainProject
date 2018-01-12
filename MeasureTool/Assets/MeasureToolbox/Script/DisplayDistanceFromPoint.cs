using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDistanceFromPoint : MonoBehaviour{

    public MeasureBetweenPoints _measurePoints;
    public Text _distanceComputed;


    public void Update()
    {
        _distanceComputed.text = "" + _measurePoints.GetDistance() ;



    }

}
