using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWASD : MonoBehaviour
{
    Rigidbody2D body;
    private float horizontal, vertical;
    private float moveLimiter = 0.8f;
    public float moveSpeed = 5f;
    public float waterSlow = 0.2f;
    private bool swimming;
    public float moving;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        swimming = false;
    }

    // Update is called once per frame
    void Update()
    {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        moving = moveSpeed;
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }
        if (swimming)
        {
             moving = moving / waterSlow;
        }
        body.velocity = new Vector2(horizontal * moving, vertical * moving);
    }

    public void Swim(bool swimming)
    {
        this.swimming = swimming;
    }
}
