using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybox : MonoBehaviour
{
    public GameObject currentbox;
    public GameObject nextquestion;
    public GameObject NextUi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            currentbox.SetActive(false);
            nextquestion.SetActive(true);
            NextUi.SetActive(true);
           



        }
    }
}
