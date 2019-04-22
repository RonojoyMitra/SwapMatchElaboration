using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject _PlayerPrefab;
    public GameObject _Player;
    public int xposition = 3;
    public int yposition = 0;

    // Start is called before the first frame update
    void Start()
    {
        InstantiatePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && xposition > 0)
        {
            xposition--;
            _Player.transform.position = new Vector3(xposition, yposition);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && xposition < 6)
        {
            xposition++;
            _Player.transform.position = new Vector3(xposition, yposition);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && yposition < 9)
        {
            yposition++;
            _Player.transform.position = new Vector3(xposition, yposition);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && yposition > 0)
        {
            yposition--;
            _Player.transform.position = new Vector3(xposition, yposition);
        }
        if (Input.GetKey(KeyCode.RightShift) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (xposition + 1 > 0 && xposition + 1 < 6 && yposition + 2 > 0 && yposition + 2 < 9)
            {
                yposition = yposition + 2;
                _Player.transform.position = new Vector3(xposition, yposition);
            }
        }
        if (Input.GetKey(KeyCode.RightShift) && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (xposition - 1 > 0 && xposition - 1 < 6 && yposition + 2 > 0 && yposition + 2 < 9)
            {
                yposition = yposition + 2;
                _Player.transform.position = new Vector3(xposition, yposition);
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (xposition + 1 > 0 && xposition + 1 < 6 && yposition - 2 > 0 && yposition - 2 < 9)
            {
                yposition = yposition - 2;
                _Player.transform.position = new Vector3(xposition, yposition);
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (xposition - 1 > 0 && xposition - 1 < 6 && yposition - 2 > 0 && yposition - 2 < 9)
            {
                yposition = yposition - 2;
                _Player.transform.position = new Vector3(xposition, yposition);
            }
        }
    }

    void InstantiatePlayer()
    {
        _Player = Instantiate(_PlayerPrefab);
        _Player.transform.position = new Vector3(xposition, yposition);
    }
}
