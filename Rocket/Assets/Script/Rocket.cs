using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    public Rigidbody rocketRigidBody;
    public Rigidbody rocketBoosterRight;
    public Rigidbody rocketBoosterLeft;
    [SerializeField] public float ForceJump = 100;
	// Use this for initialization
	void Start () {
        rocketRigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Jump") > 0)
        {
            rocketRigidBody.AddForce(new Vector3(0, ForceJump, 0));
        }

        if(Input.GetAxis("Horizontal") > 0 )
        {
            rocketRigidBody.AddForceAtPosition(new Vector3(0, 0, 10), new Vector3(0, 0 ,0));
        }
        else if(Input.GetAxis("Horizontal") < 0 )
        {
            rocketRigidBody.AddForceAtPosition(new Vector3(0, 0, 10) , new Vector3(0, 0, 0));
        }
	}
}
