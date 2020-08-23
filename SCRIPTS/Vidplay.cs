using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidplay : MonoBehaviour
{
    public GameObject QuadVid;
    public AudioSource OAudiosource;
    // Start is called before the first frame update
    void Start()
    {
        QuadVid.SetActive(false);
        OAudiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Vidplayer()
    {
        QuadVid.SetActive(true);
    }
    public void OnplayAudio()
    {
        OAudiosource.Stop();
    }
}
