using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStaightController : MonoBehaviour
{
    public Vector2 velocity;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    } 

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.velocity = velocity;
    }
}
