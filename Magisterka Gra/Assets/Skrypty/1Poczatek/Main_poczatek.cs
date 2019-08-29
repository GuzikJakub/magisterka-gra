using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_poczatek : MonoBehaviour {
    public GameObject napis;
    public GameObject przycisk1;
    public GameObject przycisk2;
//    public GameObject Sebastian;
	// Use this for initialization
	void Start () {
 //       Sebastian.SetActive(true);
        napis.SetActive(true);
        przycisk1.SetActive(false);
        przycisk2.SetActive(false);
        StartCoroutine(Przycisk());
    }

    IEnumerator Przycisk()
    {
        yield return new WaitForSeconds(3);
        napis.SetActive(false);
        przycisk1.SetActive(true);
        przycisk2.SetActive(true);
    }


    // Update is called once per frame
    void Update () {

    }
}
