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

		Vector3 cursor                  = Input.mousePosition;
		float relativeZPosition         = Mathf.Abs(Camera.main.transform.position.y - avatar.transform.position.y);
		Vector3 convertedCursorPosition = new Vector3(cursor.x, cursor.y, relativeZPosition);
        Vector3 cursorWorldPosition     = Camera.main.ScreenToWorldPoint(convertedCursorPosition);
        avatar.transform.LookAt(cursorWorldPosition);
	}
}
