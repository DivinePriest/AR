using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenPressedObj : MonoBehaviour
{
    string ObjName;
    public GameObject description1;
    public GameObject uisoundOnD1;

    // Start is called before the first frame update
    void Start()
    {
        description1.SetActive(false);
        uisoundOnD1.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hits;
            if (Physics.Raycast(ray, out Hits))
            {
                ObjName = Hits.transform.name;
                switch (ObjName)
                {
                    case ("flask"):
                        description1.SetActive(true);
                        uisoundOnD1.SetActive(true);

                        break;


                    default:
                        break;
                }
                
            }
        }
    }
}
