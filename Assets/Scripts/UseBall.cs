using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseBall : MonoBehaviour
{
    [SerializeField] GameObject useball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider colider)
    {
        if (colider.tag == "Trigger")
        {
            Instantiate(useball, colider.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
        
    }
}
