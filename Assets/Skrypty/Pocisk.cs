using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocisk : MonoBehaviour
{
    public GameObject shellParticles;

    void Start()
    {
        Invoke("Autodestruction", 2); // wywolanie funkcji usuniecia pocisku po 2s
    }

    void Update()
    {
        transform.Translate(Vector3.forward * 3f); // poruszanie obiektem do przodu
        transform.Rotate(0, 0, 2); // obracanie obiektem w trakcie ruchu
        //Debug.Log("poruszanie");
    }

    void OnCollisionEnter( Collision other ) // niszczenie pocisku
    {
        Debug.Log("Bummm!!");
        Destroy(this.gameObject);
        Instantiate(shellParticles, transform.position, Quaternion.identity);
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy !=null)
        {
            enemy.TakeDamage(10);
        }
    }

    void Autodestruction() // tworzymy funkcje usuniecia obiektu - wywolamy ja z opoznieniem wyzej!
    {
        Destroy(this.gameObject);
    }
}
