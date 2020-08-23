using System.Collections;
using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject grabScript;
    public GameObject resetBox;
    public GameObject jumpbtn;
    public GameObject Standtmptext;
    public GameObject camerapanel;
    public GameObject LectureTxt;
    public GameObject ActivityTxt;
    public GameObject BookLecture1;
    public GameObject BookLecture2;
    public GameObject uiL;
    public GameObject ResetBtn;

    // Start is called before the first frame update
    void Start()
    {

        LectureTxt.SetActive(false);
        ActivityTxt.SetActive(false);
        BookLecture1.SetActive(false);
        BookLecture2.SetActive(false);
        resetBox.SetActive(false);
        grabScript.SetActive(false);
        uiL.SetActive(false);
        ResetBtn.SetActive(false);
    }
    private void Update()
    {
      

    }

    

    void OnTriggerEnter (Collider player)
    {
        if( player.gameObject.tag == "Player" )
        {
            //camerapanel.SetActive(false);
                jumpbtn.SetActive(false);
            Debug.Log("yes");
            TextMeshPro.Destroy(Standtmptext);
            Destroy(gameObject);
            
            LectureTxt.SetActive(true);
            ActivityTxt.SetActive(true);
            BookLecture1.SetActive(true);
            BookLecture2.SetActive(true);
            resetBox.SetActive(true);
            uiL.SetActive(true);
            

        }
        
    }

    

}
