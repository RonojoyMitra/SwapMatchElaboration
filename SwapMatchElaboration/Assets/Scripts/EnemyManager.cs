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
        for (int i = 0; i < 1; i++)
        {
            GameObject enemy = Instantiate(_EnemyPrefab);
            enemy.transform.position = new Vector3(Random.Range(0, 5),9);
        }
    }
}
