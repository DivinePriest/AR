using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lecturebtnActivator : MonoBehaviour
{
    public GameObject uiLbtn;
    public GameObject otheruiBtn;
    // Start is called before the first frame update
    void Start()
    {
        uiLbtn.SetActive(false);
    }

    // Update is called once per frame
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
            uiLbtn.SetActive(true);
            otheruiBtn.SetActive(false);


        }
    }

    
}
