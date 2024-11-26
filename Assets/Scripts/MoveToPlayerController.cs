using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    public float speed = 1;
    public Vector2 horisonVelocity;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = GameObject.FindWithTag("Player");
        if (gameObject != null)
        {
            Vector2 playerPos = (gameObject.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = playerPos * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = horisonVelocity * speed;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
