using UnityEngine;

public class SaintCube : MonoBehaviour {
    public GameObject m_objectToTurn;

	void Update() {
        TurnCube.MakeTurnCube(m_objectToTurn);
	}
}
