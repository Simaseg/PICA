using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float xMargin = 1f;
	public float yMargin = 1f;
	public float xySmooth = 3f;
	public Vector2 minXY;
	public Vector2 maxXY;

	private Transform playerTransform;

	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}

	// Update is called once per frame
	void Update () {

	}

	void LateUpdate () {
		TrackPlayer();
	}

	bool CheckXMargin() {
		return Mathf.Abs (transform.position.x - playerTransform.position.x) > xMargin;
	}

	bool CheckYMargin() {
		return Mathf.Abs (transform.position.y - playerTransform.position.y) > yMargin;
	}

	void TrackPlayer() {
		float targetX = transform.position.x;
		float targetY = transform.position.y;
		if (CheckXMargin()) {
			targetX = Mathf.Lerp (transform.position.x, playerTransform.position.x, Time.deltaTime * xySmooth);
		}
		if (CheckYMargin()) {
			targetY = Mathf.Lerp (transform.position.y, playerTransform.position.y, Time.deltaTime * xySmooth);
		}

		targetX = Mathf.Clamp(targetX, minXY.x, maxXY.x);
		targetY = Mathf.Clamp(targetY, minXY.y, maxXY.y);

		transform.position = new Vector3(targetX, targetY, transform.position.z);
	}


}

