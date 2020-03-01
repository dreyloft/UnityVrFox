using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMe : MonoBehaviour {
    Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, Camera.main.transform.position) > 1.0f)
        {
            // fox look at player
            transform.LookAt(
                new Vector3(
                    Camera.main.transform.position.x,
                    0,
                    Camera.main.transform.position.z
                )
            );

            // move fox to player
            transform.position = Vector3.MoveTowards(
                transform.position,
                new Vector3(
                    Camera.main.transform.position.x,
                    0,
                    Camera.main.transform.position.z
                ),
                Time.deltaTime * 0.25f
            );

            // set fox walking animation speed
            animator.SetFloat("Speed", 0.8f);
        }
        else
        {
            // stop animation
            animator.SetFloat("Speed", 0.0f);
        }
	}
}
