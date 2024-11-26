using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemysController : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public float rightLimit;
    public float leftLimit;
    public float height;

    void Start()
    {
        InvokeRepeating("GoToRandomPos", 3f, Random.Range(2f, 4f));
    }

    void Update()
    {
        
    }
    private void GoToRandomPos()
    {
        Vector2 pos;
        pos.y = height;
        pos.x = Random.Range(rightLimit, leftLimit);
        gameObject.transform.position = pos;
        SpawnEnamy(pos);
    }
    private void SpawnEnamy(Vector2 pos)
    {
        float rand = Random.Range(0, 2);
        if (rand == 0)
        {
            GameObject enemy = Instantiate(enemy1, pos, Quaternion.identity);
            enemy.transform.Rotate(0, 0, 180);
        }
        else
        {
            GameObject enemy = Instantiate(enemy2, pos, Quaternion.identity);
            enemy.transform.Rotate(0, 0, 180);
        }
        Debug.Log(rand);
    }
}
