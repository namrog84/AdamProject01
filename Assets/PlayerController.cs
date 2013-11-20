using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float gravity = 20;
	public float speed = 8;
	public float acceleration = 30;
	public float jumpHeight = 12;
	private float currentSpeed;
	private float targetSpeed;
	private Vector2 amountToMove;
	private PlayerPhysics playerPhysics;

	// Use this for initialization
	public void Start()
	{
		playerPhysics = GetComponent<PlayerPhysics>();
	}

	// Update is called once per frame
	public void Update()
	{
		if (playerPhysics.movementStopped)
		{
			amountToMove.x = 0;
			currentSpeed = 0;
		}

		targetSpeed = Input.GetAxisRaw("Horizontal")*speed;
		currentSpeed = IncrementTowards(currentSpeed, targetSpeed, acceleration);


		if (playerPhysics.grounded)
		{
			amountToMove.y = 0;
			if (Input.GetButton("Jump"))
			{
				amountToMove.y = jumpHeight;
			}
		}


		amountToMove.x = currentSpeed;
		amountToMove.y -= gravity*Time.deltaTime;
		playerPhysics.Move(amountToMove*Time.deltaTime);
	}

	private float IncrementTowards(float n, float target, float a)
	{
		if (n == target) return n;

		float dir = Mathf.Sign(target - n);
		n += a*Time.deltaTime*dir;

		return dir == Mathf.Sign(target - n) ? n : target;
	}
}