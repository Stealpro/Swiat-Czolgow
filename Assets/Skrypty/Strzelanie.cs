using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strzelanie : MonoBehaviour
{
    public GameObject Pocisk;
    public Transform Luska;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.deltaTime != 0)
        {
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("Strzal!");
                Instantiate(Pocisk, Luska.position, Luska.rotation);
                sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Click);
            }
        }
    }
}