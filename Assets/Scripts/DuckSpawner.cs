using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawner : MonoBehaviour {
    public Camera main;
    public Object duck;
	// Use this for initialization
	void Start () {
        SpawnDucks(10);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnDucks(int numducks)
    {
       Vector3 bottomLeftCorner = main.ViewportToWorldPoint(Vector3.zero);
        float left = bottomLeftCorner.x;
        float bottom = bottomLeftCorner.y;
        float right = -bottomLeftCorner.x;
        for (int i = 0; i < numducks; i++)
        {
            Vector3 duckPos = new Vector3(Random.Range(left, right), bottom, 0);
            Instantiate(duck, duckPos, Quaternion.identity, this.transform);
        }
    }
}
