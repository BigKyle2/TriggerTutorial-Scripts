using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public GameObject door;

    public Animation anim1;

    public bool opened;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim1.Play();
        }
        
    }

}
