using UnityEngine;

public class SaintCube : MonoBehaviour {
    public GameObject m_objectToTurn;
    public float m_speedRotation = 10f;

	void Update() {
        TurnCube.MakeTurnCube(m_objectToTurn, m_speedRotation);
	}
}
