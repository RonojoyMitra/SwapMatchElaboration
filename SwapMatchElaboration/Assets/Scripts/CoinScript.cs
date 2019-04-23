using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour
{
    public GameObject ObjectiveManager;
    // Start is called before the first frame update
    void Start()
    {
        ObjectiveManager = GameObject.Find("ObjectiveManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Debug.Log("CoinCollision");
    //        Destroy(gameObject);
    //        ObjectiveManager.SendMessage("CoinCollected");
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("CoinCollision");
            Destroy(gameObject);
            ObjectiveManager.SendMessage("CoinCollected");
        }
    }
}
