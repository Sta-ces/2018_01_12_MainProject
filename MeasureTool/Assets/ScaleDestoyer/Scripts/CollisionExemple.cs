using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExemple : MonoBehaviour {

    public GameObject _A;
    public GameObject _B;

    void OnCollisionEnter()
    {
        DestroyObjectRapportTaille.DestroyObjectTaille(_A, _B);
	}
	
	
}
