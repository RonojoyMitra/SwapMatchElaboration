using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public GameObject _coinPrefab;
    int playerScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InstantiateCoins()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject coin = Instantiate(_coinPrefab);
            coin.transform.position = new Vector3(Random.Range(0,5),Random.Range(5,9));
        }
    }
    void CoinCollected()
    {
        playerScore++;
    }
}
