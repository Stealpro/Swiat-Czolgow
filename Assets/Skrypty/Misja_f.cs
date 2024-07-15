using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misja_f : MonoBehaviour
{
    public GameObject Lightttttt;
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
            Lightttttt.SetActive(false);
        }
    }
}
