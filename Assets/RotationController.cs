using UnityEngine;
using System.Collections;

public class RotationController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float rotation = Input.GetAxis("Horizontal");
        
        var body = GetComponent<Rigidbody2D>();
        body.MoveRotation(body.rotation + rotation);
	}
}
