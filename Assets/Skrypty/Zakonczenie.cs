using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zakonczenie : MonoBehaviour
{
    public GameObject finishLight;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider coll) // zmienna "coll" odwoluje sie do komponentu COLLIDER
    {
        if (coll.gameObject.name == "Czolg") // poprzez COLLIDERa wyswietli nam nazwe obiektu
        {
            Debug.Log("Czolg dotarl do celu");
            finishLight.SetActive(true); // ustawiamy glowna funkcjonalnosc
            coll.gameObject.GetComponent<Strzelanie>().enabled = false; //tu odwolujemy sie do odpowiedniego komponentu
            //coll.gameObject.GetComponent<Sterowanie_czolgiem>().enabled = false;
            coll.gameObject.GetComponent<CarController>().enabled = false;
            coll.gameObject.GetComponent<CarSound>().enabled = false;
            coll.gameObject.GetComponent<AudioSource>().enabled = false;
            text.SetActive(true);
        }
    }
}
