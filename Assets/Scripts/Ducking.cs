using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ducking : MonoBehaviour {
    public int velocity = 1;
    public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Move();
    //    Debug.Log("We are inside update." + transform.position);
    }
    private void Move()
    {
        float step = velocity * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }



}
