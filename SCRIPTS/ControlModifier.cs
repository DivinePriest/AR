using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;
using UnityStandardAssets.Characters.FirstPerson;

public class ControlModifier : MonoBehaviour
{
    public FixedJoystick Movejoystick;
    public fixedbutton Jumpedbtn;
    public FixedTouchField Ftt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.RunAxis = Movejoystick.Direction;
        fps.jumpAxis = Jumpedbtn.Pressed;
        fps.mouseLook.LookAxis = Ftt.TouchDist;

    }
}
