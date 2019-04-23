using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public GameObject _coinPrefab;
    public GameObject _GatePrefab;
    int playerScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateCoins();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScore > 4)
        {
            InstantiateGate();
        }
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
        Debug.Log("PlayerScore++");
        playerScore++;
    }
    void InstantiateGate()
    {
        Debug.Log("Gate");
        GameObject Gate = Instantiate(_GatePrefab);
        Gate.transform.position = new Vector3(0, 0);
    }
}
