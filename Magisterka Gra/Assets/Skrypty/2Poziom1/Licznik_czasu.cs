using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Licznik_czasu : MonoBehaviour {

    public Text licznikczasu;
    private float poczatek;
    public bool czyOk;
    public GameObject scena;
    public GameObject scena0;
    float temp;

	// Use this for initialization
	void Start () {
            temp = 0.0f;
            czyOk = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (scena.activeSelf == true & czyOk == true)
        {
            poczatek = Time.time;
            czyOk = false;
        }
//        float temp = Time.time - poczatek;
        else if (scena0.activeSelf == false && czyOk == false)
        {
        temp = Time.time - poczatek;
        string minuty = ((int)temp / 60).ToString();
        string sekundy = (temp % 60).ToString("f4");

        licznikczasu.text = minuty + ":" + sekundy;
        }
	}
}
