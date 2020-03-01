using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createClouds : MonoBehaviour {
    public int numberOfClouds; 
    public float xSize, ySize;
    public GameObject[] clouds;

    // Use this for initialization
    void Start() {
        for (int i = 0; i < numberOfClouds; i++)
        {
                Instantiate(
                clouds[Random.Range(0, 2)],
                new Vector3(Random.Range(-xSize / 2.0f, xSize / 2.0f), Random.Range(2.5f,3.5f), Random.Range(-ySize / 2.0f, ySize / 2.0f)),
                new Quaternion(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f)));
        }
    }
}
