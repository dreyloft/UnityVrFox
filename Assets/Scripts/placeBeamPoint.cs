using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeBeamPoint : MonoBehaviour
{
    public Transform cameraTransform;
    public GameObject player;

    private float radius;
    private Vector3 tempPos;

    private void Start()
    {
        tempPos = player.transform.position;
    }

    void Update()
    {
        // set temp pos to pointer pos
        if (Input.GetButton("Fire3"))
        {
            tempPos = new Vector3(
                transform.position.x,
                player.transform.position.y,
                transform.position.z
                );
        }

        if (player.transform.position == tempPos)
        {
            float camAngle = Mathf.Abs(cameraTransform.transform.eulerAngles.x);
            
            if (camAngle > 90)
            {
                camAngle = 90;
            }

            // place pointer
            radius = -(1.0f/45.0f) * camAngle + 2.0f;
            transform.position = cameraTransform.transform.position + cameraTransform.transform.forward * radius;
            transform.position = new Vector3(transform.position.x, 0.02f, transform.position.z);
            transform.eulerAngles = new Vector3(-90, cameraTransform.transform.eulerAngles.y, 0);
        }
        else
        {
            // move to new position
            player.transform.position = Vector3.MoveTowards(
                player.transform.position,
                tempPos,
                Time.deltaTime
                );
        }
    }
}
