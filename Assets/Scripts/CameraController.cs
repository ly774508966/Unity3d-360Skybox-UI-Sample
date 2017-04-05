using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	void Update () {
		if (Input.touchCount > 0)
		{
			//Store the first touch detected.
			Touch myTouch = Input.touches[0];

			//Check if the phase of that touch equals Moved
			if (myTouch.phase == TouchPhase.Moved)
			{
				transform.Rotate (myTouch.deltaPosition.y*0.1f, myTouch.deltaPosition.x*0.1f, 0.0f);
			}
		}
	}
}
