using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redCar : MonoBehaviour
{

    Rigidbody2D car;
    public float speed = 15f;
    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        car.velocity = new Vector2(-speed, 0);

    }
}
