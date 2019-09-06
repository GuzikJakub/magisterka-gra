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
    public GameObject scena_error;
    public GameObject scena_error_end;
    public GameObject scena_error_end2;
    public GameObject scena_final;
    float temp;
    int minuta;

	// Use this for initialization
	void Start () {
        licznikczasu.text = "0:00,0000";
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
        else if (scena0.activeSelf == false && czyOk == false && scena_final.activeSelf == false)
        {
            temp = Time.time - poczatek;
            string minuty = ((int)temp / 60).ToString();
            string sekundy = (temp % 60).ToString("f4");
            if ((temp % 60) < 10)
            {
                licznikczasu.text = minuty + ":0" + sekundy;
            }
            else
            {
                licznikczasu.text = minuty + ":" + sekundy;
            }
            int.TryParse(minuty, out minuta);
       //     Debug.Log(temp % 60);
            if (minuta == 1 & (temp % 60) > 30)
            {
                licznikczasu.color = Color.red;
            }
            else if (minuta == 2)
            {
                scena_error.SetActive(true);
                scena_error_end.SetActive(false);
                scena_error_end2.SetActive(false);
                licznikczasu.text = "0:00,0000";
            }
        }
        else if (scena_final.activeSelf == true)
        {
            licznikczasu.text = licznikczasu.text;
        }
	}
}
