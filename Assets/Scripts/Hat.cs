using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Hat : MonoBehaviour
{
    public Animator animator;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name);
        if (other.gameObject.CompareTag("Player"))
        {
            float hatVal = 0.0f;
            if (gameObject.tag.Equals("Hat0"))
            {
                hatVal = 1.0f;
            }
            if (gameObject.tag.Equals("Hat1"))
            {
                hatVal = 2.0f;
            }
            if (gameObject.tag.Equals("Hat2"))
            {
                hatVal = 3.0f;
            }
            if (gameObject.tag.Equals("Hat3"))
            {
                hatVal = 4.0f;
            }
            if (gameObject.tag.Equals("Hat4"))
            {
                hatVal = 5.0f;
            }
            animator.SetFloat("Hat", hatVal);
            Destroy(gameObject);
            
        }
    }

}
