using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_poczatek_wyjdz : MonoBehaviour {
    public GameObject napis;
    public GameObject przycisk1;
    public GameObject przycisk2;
//    public GameObject Sebastian;
	// Use this for initialization
	void Start () {
 //       Sebastian.SetActive(true);
        napis.GetComponent<UnityEngine.UI.Text>().text = "Wybierz poziom";
        napis.SetActive(true);
        przycisk1.SetActive(true);
//        przycisk2.SetActive(true);
    }

    // Update is called once per frame
    void Update () {

    }
}
