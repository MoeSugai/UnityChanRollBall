using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	private float moveHorizontal;
	private float moveVertical;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		// Input系はUpdateで
		moveHorizontal = Input.GetAxis("Horizontal");
		moveVertical = Input.GetAxis("Vertical");
	}
	void FixedUpdate()
	{
		// 実際に動かすのはFixedUpdateで
		Vector3 movement = new Vector3( moveHorizontal, 0.0f, moveVertical );

		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Item")) {
			other.gameObject.SetActive (false);
		}
	}
}
