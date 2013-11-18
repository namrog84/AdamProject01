using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public Transform target;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;
        position.x = Mathf.Lerp(position.x, target.transform.position.x, Time.deltaTime * 5);
        position.y = Mathf.Lerp(position.y, target.transform.position.y, Time.deltaTime * 5);
        transform.position = position;
	}
}
