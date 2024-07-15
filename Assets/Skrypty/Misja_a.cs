using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misja_a : MonoBehaviour
{
    [SerializeField]
    bool showObjective = false;
    [SerializeField]
    Texture objective;
    [SerializeField]
    private int collision;
    [SerializeField]
    public GameObject text;
    public GameObject Light;
    void Start()
    {
        showObjective = false;
        text.SetActive(true);
    }
    void OnTriggerEnter(Collider coll)
    {
        //if (other.gameObject.tag == "Player" && showObjective == false && collision == 0)
            //showObjective = true;
        if (coll.gameObject.name == "Czolg")
        {
            Light.SetActive(false);
            text.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            showObjective = false;
        collision = 1;
        text.SetActive(false);
    }
    void OnGUI()
    {
        if (showObjective == true)
            GUI.DrawTexture(new Rect(Screen.width / 1.5f, Screen.height / 1.4f, 178, 178), objective);
    }
    void Update()
    {
        if (Input.GetButton("ShowObj") && collision == 1)
        {
            showObjective = true;
            text.SetActive(true);
        }
        if (Input.GetButtonUp("ShowObj") && collision == 1)
        {
            showObjective = false;
            text.SetActive(false);
        }
    }
}