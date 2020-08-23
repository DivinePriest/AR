using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LectureSwitch : MonoBehaviour
{
  public void Lecture1 ()
    {
        SceneManager.LoadScene(1);
    }
    public void Lecuture2 ()
    {
        SceneManager.LoadScene(2);

    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

}
