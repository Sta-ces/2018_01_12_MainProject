using UnityEngine;

public class TurnCube {

    public static void MakeTurnCube(GameObject _objectToTurn, float _speedRotation = 10f)
    {
        MakeTurnCube(_objectToTurn.transform, _speedRotation);
    }

    public static void MakeTurnCube(Transform _objectToTurn, float _speedRotation = 10f)
    {
        _objectToTurn.Rotate(new Vector3(45f,45f,45f), _speedRotation * Time.deltaTime);
    }
}
