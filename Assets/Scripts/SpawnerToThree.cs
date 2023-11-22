using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerToThree : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] float RandomPositionX;
    [SerializeField] GameObject ball1;
    [SerializeField] GameObject ball2;
    [SerializeField] GameObject ball3;
    [SerializeField] GameObject ball4;
    [SerializeField] GameObject ball5;
    [SerializeField] GameObject ball6;
    [SerializeField] GameObject ball7;
    [SerializeField] int ballIndex;
    [SerializeField] CountToGamemodethree CountToGamemodethree;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("create", 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
        RandomPositionX = Random.Range(-23, 28);
        if(CountToGamemodethree.countball > 5)
        {
            ballIndex = 1;
        }
        if (CountToGamemodethree.countball > 5)
        {
            ballIndex = 1;
        }
        if (CountToGamemodethree.countball > 9)
        {
            ballIndex = 2;
        }
        if (CountToGamemodethree.countball > 15)
        {
            ballIndex = 3;
        }
        if (CountToGamemodethree.countball > 20)
        {
            ballIndex = 4;
        }
        if (CountToGamemodethree.countball > 30)
        {
            ballIndex = 5;
        }
        if (CountToGamemodethree.countball > 39)
        {
            ballIndex = 6;
        }
        if (CountToGamemodethree.countball > 40)
        {
            ballIndex = 7;
        }
    }
    void create()
    {
        if (ballIndex == 0)
        {
            Instantiate(ball, new Vector3(RandomPositionX, 31.1f, 4.8f), Quaternion.identity);
        }
        if (ballIndex == 1)
        {
            Instantiate(ball1, new Vector3(RandomPositionX, 31.1f, 4.8f), Quaternion.identity);
        }
        if (ballIndex == 2)
        {
            Instantiate(ball2, new Vector3(RandomPositionX, 31.1f, 4.8f), Quaternion.identity);
        }
        if (ballIndex == 3)
        {
            Instantiate(ball3, new Vector3(RandomPositionX, 31.1f, 4.8f), Quaternion.identity);
        }
        if (ballIndex == 4)
        {
            Instantiate(ball4, new Vector3(RandomPositionX, 31.1f, 4.8f), Quaternion.identity);
        }
        if (ballIndex == 5)
        {
            Instantiate(ball5, new Vector3(RandomPositionX, 31.1f, 4.8f), Quaternion.identity);
        }
        if (ballIndex == 6)
        {
            Instantiate(ball6, new Vector3(RandomPositionX, 31.1f, 4.8f), Quaternion.identity);
        }
        if (ballIndex == 7)
        {
            Instantiate(ball7, new Vector3(RandomPositionX, 31.1f, 4.8f), Quaternion.identity);
        }
    }
}
