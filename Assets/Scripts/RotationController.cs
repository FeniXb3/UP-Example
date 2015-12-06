using UnityEngine;

public class RotationController : MonoBehaviour
{
    public float speed = 15f;
    public float jumpForce = 10f;

    private Rigidbody2D body;
    private float rotation;
    private bool shouldPerfomJump;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rotation = Input.GetAxis("Horizontal") * speed;
        shouldPerfomJump = Input.GetButton("Jump");
    }

    void FixedUpdate()
    {
        body.AddForce(Vector2.right * rotation);

        if (shouldPerfomJump && isGrounded())
        {
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    // taken from here http://answers.unity3d.com/questions/623476/how-to-make-a-2d-jumping-script-using-linecast.html
    public bool isGrounded()
    {
        Vector2 myPos = transform.position;
        Vector2 groundCheckPos = myPos - Vector2.up;
        bool result = Physics2D.Linecast(myPos, groundCheckPos,  1 << LayerMask.NameToLayer("Ground"));
        if (result)
        {
            Debug.DrawLine(myPos, groundCheckPos, Color.green, 0.5f, false);
        }
        else
        {
            Debug.DrawLine(myPos, groundCheckPos, Color.red, 0.5f, false);
        }
        return result;
    }
}
