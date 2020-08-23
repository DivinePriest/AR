using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalscoreShow : MonoBehaviour
{
    public GameObject Uiscore;
    // Start is called before the first frame update
    void Start()
    {
        Uiscore.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Uiscore.SetActive(true);
        }
    }
}
