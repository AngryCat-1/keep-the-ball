using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    [SerializeField] float distance;
    [SerializeField] float speedMove;

    void Start() => StartCoroutine(c_Start());

    IEnumerator c_Start()
    {
        InvokeRepeating("speedcreate", 0, 2);
        yield return new WaitForSeconds(1.0f);

        Vector3 startPosition = transform.position;
        Vector3 velocity = Vector3.right * speedMove;

        while (true)
        {
            if (transform.position.x > startPosition.x + distance)
                velocity.x = -speedMove;
            else if (transform.position.x < startPosition.x - distance)
                velocity.x = speedMove;

            transform.position += velocity * Time.deltaTime;

            yield return null;
        }
    }

    void speedcreate()
    {
        speedMove = Random.Range(3, 10);
    }

}
