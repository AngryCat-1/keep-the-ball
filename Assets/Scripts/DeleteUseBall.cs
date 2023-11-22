using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteUseBall : MonoBehaviour
{
    public CountBallPlatform CountBallPlatform;


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
        if (colider.tag == "delete")
        {
            CountBallPlatform.countball -= 1;
            Destroy(this.gameObject);
        }
    }
}
