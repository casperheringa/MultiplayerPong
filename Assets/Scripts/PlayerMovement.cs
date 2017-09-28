using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour {

	void Start(){
		transform.Rotate (0, 0, 90);
	}

	void Update () {
		if (!isLocalPlayer) {
			return;
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			Vector3 position = this.transform.position;
			position.y += 0.3f;
			this.transform.position = position;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			Vector3 position = this.transform.position;
			position.y -= 0.3f;
			this.transform.position = position;
		}
	}
}
