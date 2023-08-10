using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()

        float dirX = Input.getAxis("Horizontal");

        rb.velocity = new Vector2(dirX* 7f);
    {
        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(0, 14f);
        }
    }
}