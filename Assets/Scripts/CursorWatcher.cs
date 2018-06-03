using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorWatcher : MonoBehaviour {

	Transform avatar;

	void Start(){
		avatar = this.gameObject.transform.GetChild(0);
	}


	// Update is called once per frame
	void Update () {

		Vector3 v3T = Input.mousePosition;
        v3T.z = Mathf.Abs(Camera.main.transform.position.y - avatar.transform.position.y);
        v3T = Camera.main.ScreenToWorldPoint(v3T);
        avatar.transform.LookAt(v3T);
	}
}
