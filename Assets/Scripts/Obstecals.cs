using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstecals : MonoBehaviour
{
    public Animator animation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<CharacterControl>().speed *= 0.8f;
            animation.SetTrigger("LandAndRoll");
        }
    }
}
