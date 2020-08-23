using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioD1 : MonoBehaviour
{
    public AudioSource OAudiosource;
    // Start is called before the first frame update
    void Start()
    {
        OAudiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnplayAudio()
    {
        OAudiosource.Play();
    }
}
