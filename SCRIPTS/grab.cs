using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour
{
    RaycastHit hit;
    GameObject grabobj;
    public Transform grabpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Physics.Raycast(transform.position, transform.forward, out hit,2.5f) && hit.transform.GetComponent<Rigidbody>())
        {
            grabobj = hit.transform.gameObject;
            grabobj.GetComponent<Rigidbody>().velocity = (grabpos.position - grabobj.transform.position)*10;
            
            Debug.Log("hit obj");
        }

        else 
        {
            grabobj = null;
            Debug.Log("no hit obj");
        }
    
    }
}
