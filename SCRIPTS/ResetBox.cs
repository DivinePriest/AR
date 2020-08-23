using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBox : MonoBehaviour
{
    public GameObject actsetup;
    public GameObject resetBox;
    public GameObject jumpbtn;
    public GameObject LTxt;
    public GameObject Atxt;
    public GameObject B1;
    public GameObject B2;
    public GameObject grabScript;
    public GameObject resetBtn;
         
    // Start is called before the first frame update
    void Start()
    {
        actsetup.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnTriggerEnter(Collider reset)
    {
        if(reset.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            jumpbtn.SetActive(true);
            LTxt.SetActive(false);
            Atxt.SetActive(false);
            B1.SetActive(false);
            B2.SetActive(false);
            grabScript.SetActive(true);
            resetBtn.SetActive(true);
            actsetup.SetActive(true);
            //Other things on Activity
        }
    }
}
