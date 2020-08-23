using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class playerstop : MonoBehaviour
{
    public AudioSource AsVoiceOver;
    public VideoPlayer Vidplayer;
    // Start is called before the first frame update
    void Start()
    {
        AsVoiceOver = GetComponent<AudioSource>();
        Vidplayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickStop()
    {
        AsVoiceOver.Stop();
        Vidplayer.Stop();
    }
}
