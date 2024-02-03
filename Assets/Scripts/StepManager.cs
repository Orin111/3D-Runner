using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepManager : MonoBehaviour
{
    public GameObject step1, step2, player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > step1.transform.position.x + 70)
        {
            Vector3 pos = step1.transform.position;
            step1.transform.position = new Vector3(pos.x + 266, pos.y, pos.z);
        }
        else if (player.transform.position.x > step2.transform.position.x + 70)
        {
            Vector3 pos = step2.transform.position;
            step2.transform.position = new Vector3(pos.x + 266, pos.y, pos.z);
        }
    }
}
