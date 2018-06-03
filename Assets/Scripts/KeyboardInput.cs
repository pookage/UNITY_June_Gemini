using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour {
	
	public KeyCode forward;
	public KeyCode left;
	public KeyCode backward;
	public KeyCode right;
	public float speed = 10.0f;

	GameObject avatar;

	void Start(){
		forward  = KeyCode.W;
		left     = KeyCode.A;
		backward = KeyCode.S;
		right    = KeyCode.D;
		avatar   = this.gameObject;
	}

	void Update () {

		Vector2 direction = new Vector2(0, 0);

		if(Input.GetKey(forward)){
			direction.y  = direction.y + (speed * Time.deltaTime);
		} 

		if(Input.GetKey(left)){
			direction.x = direction.x + (-speed * Time.deltaTime);
		}

		if(Input.GetKey(backward)){
			direction.y = direction.y + (-speed * Time.deltaTime);
		}

		if(Input.GetKey(right)){
			direction.x = direction.x + (speed * Time.deltaTime);
		}
	
		avatar.transform.Translate(direction.x, 0, direction.y);
	}
}
