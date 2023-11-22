using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOntwo : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] float RandomPositionX;
    void Start()
    {
        InvokeRepeating("create", 0, 4);
    }
    void Update()
    {
        RandomPositionX = Random.Range(-23, 28);
    }
    void create()
    {


        Instantiate(ball, new Vector3(RandomPositionX, 31.1f, 4.8f), Quaternion.identity);
    }
}