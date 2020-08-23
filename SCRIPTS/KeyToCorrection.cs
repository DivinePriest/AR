using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
public class KeyToCorrection : MonoBehaviour
{
   int Score;

    public GameObject A1;
    public GameObject A2;
    public GameObject B1;
    public GameObject B2;
    public GameObject C1;
    public GameObject C2;
    public GameObject D1;
    public GameObject D2;
    public GameObject E1;
    public GameObject E2;
    public GameObject F1;
    public GameObject F2;
    public GameObject G1;
    public GameObject G2;
    public GameObject H1;
    public GameObject H2;
    public GameObject I1;
    public GameObject I2;
    public GameObject J1;
    public GameObject J2;
  public  Text TotalScore;
   


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        TotalScore.text = Score.ToString();
        
    }


    public void Correct()
    {
        Score = Score + 1;

       
       
    }
    public void Wrong()
    {
        Score = Score+0;
        

    }
   

    
}
