using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDiedBall : MonoBehaviour
{
    [SerializeField] Transform Spawn;
    [SerializeField] GameObject ball;
    [SerializeField] float RandomPositionX;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("create", 0, 8);
    }

    // Update is called once per frame
    void Update()
    {
        RandomPositionX = Random.Range(-23, 28);
    }
    void create()
    {

        Instantiate(ball, new Vector3(RandomPositionX, 31.1f, 4.8f), Quaternion.identity);
    }
}
