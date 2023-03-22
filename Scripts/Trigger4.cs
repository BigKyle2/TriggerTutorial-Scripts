using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger4 : MonoBehaviour
{

    public Animator anim1;

    public string bool1;
    public bool value1;

    public string bool2;
    public bool value2;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim1.SetBool(bool1, value1);
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim1.SetBool(bool2, value2);
        }

    }

}
