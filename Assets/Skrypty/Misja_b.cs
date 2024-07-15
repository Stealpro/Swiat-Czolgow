using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misja_b : MonoBehaviour
{
    public GameObject Lightt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "Czolg")
        {
            Lightt.SetActive(false);
        }
    }
}
