using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    const int ROWS = 10;
    const int COLUMNS = 7;
    public GameObject _groundPrefab;
    public GameObject[,] _ground = new GameObject[COLUMNS, ROWS];

    // Start is called before the first frame update
    void Start()
    {
        InstantiateGround();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiateGround()
    {
        for (int x = 0; x < COLUMNS; x++)
        {
            for (int y = 0; y < ROWS; y++)
            {
                GameObject ground = Instantiate(_groundPrefab);
                _ground[x, y] = ground;
                ground.transform.position = new Vector3(x, y);
            }
        }
    }
}
