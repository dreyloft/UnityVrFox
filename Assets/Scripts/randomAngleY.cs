using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomAngleY : MonoBehaviour {
	void Start () {
        transform.eulerAngles = new Vector3(0, Random.Range(0.0f, 360.0f), 0);
	}
}
