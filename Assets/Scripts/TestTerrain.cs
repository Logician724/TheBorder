using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestTerrain : MonoBehaviour {

    public GameObject cylinder;

    // Update is called once per frame
    void Update () {
		if(Input.GetKey(KeyCode.W))
        {
            cylinder.transform.position -= new Vector3(0.5f, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            cylinder.transform.position += new Vector3(0.5f, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            cylinder.transform.position -= new Vector3(0, 0, 0.5f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            cylinder.transform.position += new Vector3(0, 0, 0.5f);
        }
        
    }
}
