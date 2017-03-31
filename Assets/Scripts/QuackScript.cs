using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuackScript : MonoBehaviour {
    public int velocity;
	// Use this for initialization
	void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Move(-1, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Move(1, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move(0, 1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Move(0, -1);
        }
    }
    private void Move(float x, float y) {
        transform.Translate(new Vector2(x*Time.deltaTime, y*Time.deltaTime));
    }
}
