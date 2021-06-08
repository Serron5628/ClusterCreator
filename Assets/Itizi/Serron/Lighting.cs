using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    public int resolution;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Light>().shadowCustomResolution = resolution;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
