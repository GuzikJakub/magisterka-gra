using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_glowne : MonoBehaviour {
    public GameObject przycisk_wyjdz;
    public GameObject przycisk_cofnij;
    public GameObject scena1;
    public GameObject scena0;
	// Use this for initialization
	void Start () {
        przycisk_wyjdz.SetActive(true);
        przycisk_cofnij.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        aktywuj_cofnij();
	}

    void aktywuj_cofnij()
    {
        if(scena1.activeSelf == true || scena0.activeSelf == true)
        {
            przycisk_cofnij.SetActive(false);
        }
        else
        {
            przycisk_cofnij.SetActive(true);
        }
    }

}
