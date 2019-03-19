using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //handles player movement, takes into account every possible combo of buttons and prevents breaking movement
        if(Input.GetKey("a")&&!Input.GetKey("d"))
        {
            rb.velocity = new Vector2(-10,0);
        }
        if (Input.GetKey("d")&&!Input.GetKey("a"))
        {
            rb.velocity = new Vector2(10, 0);
        }
        if (Input.GetKey("a") && Input.GetKey("d"))
        {
            rb.velocity = new Vector2(0, 0);
        }
        if(Input.GetKeyUp("a")&&!Input.GetKey("d"))
        {
            rb.velocity = new Vector2(0, 0);
        }
        if (Input.GetKeyUp("d")&&!Input.GetKey("a"))
        {
            rb.velocity = new Vector2(0, 0);
        }
        if(!Input.GetKey("a")&&!Input.GetKey("d"))
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
