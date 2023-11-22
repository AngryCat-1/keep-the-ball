using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    [SerializeField] float size;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("NewEvent1", 0, 50);
        InvokeRepeating("NewEvent2", 0, 80);
        InvokeRepeating("NewEvent2", 0, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void NewEvent1()
    {
        
        GetComponent<Rigidbody>().mass = Random.Range(0.01f, 10.0f); 
    }
    void NewEvent2()
    {
        
        
        size = Random.Range(0.8f, 1.8f);
        
        transform.localScale = new Vector3(size,size,size);
    } 

    void NewEvent3()
    {

        GetComponent<Rigidbody>().drag = Random.Range(0.01f, 10.0f);
    }
}
