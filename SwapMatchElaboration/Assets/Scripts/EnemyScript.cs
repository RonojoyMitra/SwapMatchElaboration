using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    private Transform Player;
    public static EnemyScript Instance;
    int xdirection = 0;
    int ydirection = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Player.transform);

        //if (Vector2.Distance(transform.position, Player.transform.position) >= 0)
        //{
        //    transform.position += transform.forward * xdirection * ydirection;
        //}
    }
    void EnemyMovement()
    {
        if (Player.position.x < transform.position.x)
        {
            xdirection = -1;
        }
        else if (Player.position.x > transform.position.x)
        {
            xdirection = 1;
        }
        if (Player.position.y < transform.position.x)
        {
            ydirection = -1;
        }
        else if (Player.position.y > transform.position.y)
        {
            ydirection = 1;
        }
        //if (Mathf.Abs(Player.position.x - transform.position.x) < float.Epsilon)
        //{
        //    if (Player.position.y > transform.position.y)
        //    {
        //        ydirection = 1;
        //    }
        //    else
        //    {
        //        ydirection = -1;
        //    }
        //}
        //else
        //{
        //    if (Player.position.x > transform.position.y)
        //    {
        //        xdirection = 1;
        //    }
        //    else
        //    {
        //        xdirection = -1;
        //    }
        //}
        Movement();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("EndScene");
        }
    }
    void Movement()
    {
        Vector2 start = transform.position;
        Vector2 end = start + new Vector2(xdirection, ydirection);
        transform.position = end;
    }
    public void EnemyTurn()
    {
        EnemyMovement();
    }
}
