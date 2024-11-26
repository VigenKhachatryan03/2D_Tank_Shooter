using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemyBulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "BulletEnemy")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            if (collision.transform.tag != "Wall")
                Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
