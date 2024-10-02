using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 420f;


   private void FixedUpdate()
   {
       float v = Input.GetAxis("Vertical");
       float h = Input.GetAxis("Horizontal");
       rb.velocity = transform.TransformDirection(new Vector3(h, rb.velocity.y, v) * Time.fixedDeltaTime * speed);
   }
}
