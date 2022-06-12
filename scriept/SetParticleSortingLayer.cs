using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParticleSortingLayer : MonoBehaviour
{
    public string sortingLayerName;		// The name of the sorting layer the particles should be set to.

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = sortingLayerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
