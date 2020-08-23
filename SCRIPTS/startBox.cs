using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBox : MonoBehaviour
{
    public GameObject startBox1;

    public GameObject Question1;
    public GameObject Question2;
    public GameObject Question3;
    public GameObject Question4;
    public GameObject Question5;
    public GameObject Question6;
    public GameObject Question7;
    public GameObject Question8;
    public GameObject Question9;
    public GameObject Question10;
    public GameObject uiA;
    public GameObject uib;
    public GameObject uic;
    public GameObject uid;
    public GameObject uie;
    public GameObject uif;
    public GameObject uig;
    public GameObject uih;
    public GameObject uii;
    public GameObject uij;
    public GameObject uiguide;

    // Start is called before the first frame update
    void Start()
    {
        Question1.SetActive(false);
        Question2.SetActive(false);
        Question3.SetActive(false);
        Question4.SetActive(false);
        Question5.SetActive(false);
        Question6.SetActive(false);
        Question7.SetActive(false);
        Question8.SetActive(false);
        Question9.SetActive(false);
        Question10.SetActive(false);
        uiA.SetActive(false);
        uib.SetActive(false);
        uic.SetActive(false);
        uid.SetActive(false);
        uie.SetActive(false);
        uif.SetActive(false);
        uig.SetActive(false);
        uih.SetActive(false);
        uii.SetActive(false);
        uij.SetActive(false);
        uiguide.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            startBox1.SetActive(false);
            Question1.SetActive(true);
            uiA.SetActive(true);
            uiguide.SetActive(false);




        }
    }
}
