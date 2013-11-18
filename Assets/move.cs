using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{

    GameObject[] objects;
	// Use this for initialization
	void Start () {
        objects = GameObject.FindGameObjectsWithTag("Adam");
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey (KeyCode.A))
            for (int i = 0; i < objects.Length;i++ )
            {

                Vector3 ta = objects[i].transform.position;
                ta += Vector3.forward;
                objects[i].transform.position = ta;

            }
        if (Input.GetKey(KeyCode.D))
            for (int i = 0; i < objects.Length; i++)
            {

                Vector3 ta = objects[i].transform.position;
                ta += -Vector3.forward;
                objects[i].transform.position = ta;

            }

	}
}
