using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour {
	
	public KeyCode forward;
	public KeyCode left;
	public KeyCode backward;
	public KeyCode right;

	void Start(){
		forward  = KeyCode.W;
		left     = KeyCode.A;
		backward = KeyCode.S;
		right    = KeyCode.D;
	}

	void Update () {

		if(Input.GetKeyDown(forward)){
			Debug.Log("forward pressed");
		}

		if(Input.GetKeyDown(left)){
			Debug.Log("left pressed");
		}

		if(Input.GetKeyDown(backward)){
			Debug.Log("backward pressed");
		}

		if(Input.GetKeyDown(right)){
			Debug.Log("right pressed");
		}
	
	}
}
