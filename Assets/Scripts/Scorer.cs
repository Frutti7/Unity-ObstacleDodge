using UnityEngine;

public class Scorer : MonoBehaviour {
    private int bumTimes = 0;

    private void OnCollisionEnter(Collision collision) {
        bumTimes++;
        Debug.Log("We bumped into something this many times: " + bumTimes);
    }
}