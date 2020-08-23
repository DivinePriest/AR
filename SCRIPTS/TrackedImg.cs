using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackedImg : MonoBehaviour
{
    public GameObject ImgFound;
    public GameObject playSound;
    // Start is called before the first frame update
    void Start()
    {
        playSound.SetActive(false);

    }

    // Update is called once per frame
   public void Update()
    {
      
    }
    public void Imgfound()
    {
        ImgFound.SetActive(false);
        playSound.SetActive(true);
    }
    public void ImgLost()
    {
        ImgFound.SetActive(true);
        playSound.SetActive(false);
    }
   
}
