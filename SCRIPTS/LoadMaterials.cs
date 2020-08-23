using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class LoadMaterials : MonoBehaviour
{
    public GameObject sugar;
    public GameObject salt;
    public GameObject munggo;
    public GameObject juicepowder;
    // Start is called before the first frame update
    void Start()
    {
        sugar.SetActive(false);
        salt.SetActive(false);
        munggo.SetActive(false);
        juicepowder.SetActive(false);
    }
    public void sugarobj()
    {
        sugar.SetActive(true);

    }
    public void saltobjt()
    {
        salt.SetActive(true);

    }
    public void munggoobj()
    {
        munggo.SetActive(true);
    }
    public void juiceobj()
    {
        juicepowder.SetActive(true);
    }
}
