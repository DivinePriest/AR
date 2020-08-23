using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

[RequireComponent(typeof(AudioSource))]

public class footstep : MonoBehaviour
{

    private AudioSource m_Audio;
    public AudioClip[]Stepsound;
    
    public CharacterController _CharController;
    private Rigidbody _RigBod;
    private bool playSteps;

    void Awake()
    {
        m_Audio = gameObject.AddComponent<AudioSource>();
        _RigBod = _CharController.GetComponent<Rigidbody>();
    }

    void Start()
    {
        StartCoroutine(PlayFootstep());
        playSteps = true;
    }

    void Update()
    {
        if (!_CharController.isGrounded && playSteps)
        {
            playSteps = false;
            StopCoroutine(PlayFootstep());
        }
        else if (_CharController.isGrounded && !playSteps && _CharController.velocity.magnitude > 0.2f)
        {
            StartCoroutine(PlayFootstep());
        }
    }


    IEnumerator PlayFootstep()
    {
       
            
                yield return new WaitForSeconds(0.4f);
                m_Audio.PlayOneShot(Stepsound[Random.Range(0, Stepsound.Length - 1)]);
         
        
        }
    }

