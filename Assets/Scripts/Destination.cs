using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour {
    public int speed = 1;
    public float radius = 1f;
    public int zero = 0;
    public Vector3 xdifferent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 xcircle = new Vector3(radius * Mathf.Cos(Time.timeSinceLevelLoad * speed / 2 * Mathf.PI), 0);
      //  Vector3 xdifferent = new Vector3(Time.timeSinceLevelLoad * 3, 0);
      //if (Time.timeSinceLevelLoad % 2 == zero)
      //  {
      //      Vector3 xdifferent = new Vector3(Time.timeSinceLevelLoad*3, 0);
      //  }
      //  if (Time.timeSinceLevelLoad % 2 != zero)
      //  {
      //     Vector3 xdifferent = new Vector3(-Time.timeSinceLevelLoad * 3, 0);
      //  }

        transform.position = transform.position + xdifferent;
     //   Debug.Log(transform.position);
    }
}
