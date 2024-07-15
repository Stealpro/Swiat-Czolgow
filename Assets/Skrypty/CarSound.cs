using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSound : MonoBehaviour
{
    AudioSource audioSource;
    public float minPitch = 0.6f;
    private float pitchFromCar;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = minPitch;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.deltaTime != 0)
        {
            pitchFromCar = CarController.cc.carCurrentSpeed;
            if (pitchFromCar < minPitch)
                audioSource.pitch = minPitch;
            else
                audioSource.pitch = pitchFromCar;
        }
    }
}
