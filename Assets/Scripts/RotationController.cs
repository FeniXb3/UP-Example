using UnityEngine;

public class RotationController : MonoBehaviour
{
    public float speed = 10f;

    void FixedUpdate()
    {
        float rotation = Input.GetAxis("Horizontal") * speed;

        var body = GetComponent<Rigidbody2D>();
        body.MoveRotation(body.rotation + rotation);

        //Vector2 movingForce = new Vector2(rotation, 0f);
        //body.AddForce(movingForce * speed);
    }
}
