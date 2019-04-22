using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject _EnemyPrefab;
    public GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InstantiateEnemies()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject enemy = Instantiate(_EnemyPrefab);
            enemy.transform.position = new Vector3(Random.Range(0, 5),9);
        }
    }
    void EnemyMovement()
    {
        int xdirection = 0;
        int ydirection = 0;

        if (Mathf.Abs(_player.transform.position.x - transform.position.x) < float.Epsilon)
        {
            if (_player.transform.position.y > transform.position.y)
            {
                ydirection = 1;
            }
            else
            {
                ydirection = -1;
            }
        }
        else
        {
            if (_player.transform.position.x > transform.position.y)
            {
                xdirection = 1;
            }
            else
            {
                xdirection = -1;
            }
        }
    }
    void Movement()
    {

    }
}
