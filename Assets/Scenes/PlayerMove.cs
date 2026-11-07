using UnityEngine;

public class PlayerMove : MonoBehaviour
{
     public float speed = 5f;
     public float jumpForce = 7f;

     private Rigidbody2D rb;

     void Start()
     {
          rb = GetComponent<Rigidbody2D>();
     }

     void Update()
     {
          // 左右移動
          float h = Input.GetAxis("Horizontal");

          transform.position +=
              new Vector3(h * speed * Time.deltaTime, 0, 0);

          // 跳躍
          if (Input.GetKeyDown(KeyCode.Space))
          {
               rb.linearVelocity =
                   new Vector2(rb.linearVelocity.x, jumpForce);
          }
     }
}