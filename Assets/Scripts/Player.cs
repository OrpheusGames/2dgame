using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody2D _myRigidbody;

	// Use this for initialization
	void Start () {
		_myRigidbody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float moveH = Input.GetAxis("Horizontal");
		float moveV = Input.GetAxis("Vertical");
		_myRigidbody.velocity = new Vector2(0,  moveV);
	}
}
