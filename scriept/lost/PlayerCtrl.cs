using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    public float jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           Movement();
    }

     void Movement()
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        float facedirection = Input.GetAxisRaw("Horizontal");


        if (horizontalmove != 0)
        {
            rb.velocity = new Vector2(horizontalmove*speed, rb.velocity.y);

        }
        if (facedirection != 0)
        {
            transform.localScale = new Vector3(facedirection,1,1);
        }

        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x,jumpforce);
        }
    }
}
