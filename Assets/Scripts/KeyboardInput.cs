using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour {
	
	public static KeyCode forward  = KeyCode.W;
	public static KeyCode left     = KeyCode.A;
	public static KeyCode backward = KeyCode.S;
	public static KeyCode right    = KeyCode.D;
	public static float speed      = 10.0f;

	GameObject avatar;
	Vector3 velocity = Vector3.zero;
	float smoothTime = speed / 20;

	void Start(){
		avatar   = this.gameObject;
	}//Start

	void Update () {

		Vector2 direction = new Vector2(0, 0);

		if(Input.GetKey(forward)){
			direction.y  = direction.y + speed;
		} 

		if(Input.GetKey(left)){
			direction.x = direction.x  - speed;
		}

		if(Input.GetKey(backward)){
			direction.y = direction.y  - speed;
		}

		if(Input.GetKey(right)){
			direction.x = direction.x + speed;
		}
	
		Vector3 targetPosition    = avatar.transform.position + new Vector3(direction.x, 0, direction.y);
		avatar.transform.position = Vector3.SmoothDamp(avatar.transform.position, targetPosition, ref velocity, smoothTime);
	}//Update
}
