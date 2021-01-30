using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rb;
    //public BoxCollider2D col;
    public Animator anim;

    Vector2 movement;
    string horizontal;
    string vertical;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //col = GetComponent<BoxCollider2D>();
        //anim = GetComponent<Animator>();
        horizontal = "Horizontal";
        vertical = "Vertical";
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw(horizontal);
        movement.y = Input.GetAxisRaw(vertical);

        //anim.SetFloat(horizontal,movement.x);
        //anim.SetFloat(vertical, movement.y);
        //anim.SetFloat("Speed",movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}
