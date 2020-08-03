using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerSpin : MonoBehaviour
{
    public GameObject spinIt;
    public float speedFan = 10f ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speedFan, 0, 0);
    }
}
