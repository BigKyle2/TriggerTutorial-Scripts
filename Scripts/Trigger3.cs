using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger3 : MonoBehaviour
{

    public AudioSource sound1;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sound1.Play();
        }

    }

}
