using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Transform playerTransform;
    public float miles;
    private float startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = playerTransform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        miles = playerTransform.position.x - startPos;
    }
}
