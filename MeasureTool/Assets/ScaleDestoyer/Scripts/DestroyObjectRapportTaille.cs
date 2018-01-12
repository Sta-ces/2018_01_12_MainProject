using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectRapportTaille : MonoBehaviour {

	public static void DestroyObjectTaille(GameObject _A, GameObject _B)
    {

        if (_A.transform.localScale.y < _B.transform.localScale.y)
        {
            Destroy(_A);
        }

        if (_B.transform.localScale.y < _A.transform.localScale.y)
        {
            Destroy(_B);
        }
    }
}
