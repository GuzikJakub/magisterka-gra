using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Licznik_czasu : MonoBehaviour {

    public Text licznikczasu;
    private float poczatek;

	// Use this for initialization
	void Start () {
        poczatek = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        float temp = Time.time - poczatek;

        string minuty = ((int)temp / 60).ToString();
        string sekundy = (temp % 60).ToString("f4");

        licznikczasu.text = minuty + ":" + sekundy;
	}
}
