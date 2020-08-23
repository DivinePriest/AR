using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offLBtn : MonoBehaviour
{
    public GameObject uiBtn1;
    public GameObject uiBtn2;
    public GameObject uibtnmat;
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
        if(other.gameObject.tag =="Player")
        {
            uiBtn1.SetActive(false);
            uiBtn2.SetActive(false);
            uibtnmat.SetActive(false);
        }
    }
}
