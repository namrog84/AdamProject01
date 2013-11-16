using UnityEngine;
using System.Collections;

public class UpAndDown : MonoBehaviour {

    static System.Random r = new System.Random();
	// Use this for initialization
	void Start () {
        dir = true;

        speed = (float)r.NextDouble()*.3f+.2f;
	}
    bool dir;
    float speed = .3f;
	// Update is called once per frame
	void Update () {

        Vector3 a = this.transform.position;
        if(dir)
            a.y += speed;
        else
            a.y -= speed;
        if (a.y > 10)
            dir = false;
        if (a.y < -5)
            dir = true;

        this.transform.position = a;


	
	}
}
