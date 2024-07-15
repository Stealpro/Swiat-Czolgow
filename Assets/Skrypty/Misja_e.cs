using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misja_e : MonoBehaviour
{
    public GameObject Lighttttt;
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
            Lighttttt.SetActive(false);
        }
    }
}
