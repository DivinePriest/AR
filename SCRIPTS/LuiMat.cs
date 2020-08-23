using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuiMat : MonoBehaviour
{
    public GameObject Uimat;
    // Start is called before the first frame update
    void Start()
    {
        Uimat.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag ==  "Player")
                {
            Uimat.SetActive(true);

        }
    }
}
