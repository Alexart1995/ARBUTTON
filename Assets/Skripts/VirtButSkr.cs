using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtButSkr : MonoBehaviour
{
    public GameObject CubeA;
    public GameObject SphereB;
    VirtualButtonBehaviour vrb;

    // Start is called before the first frame update
    void Start()
    {
        CubeA.SetActive(false);
        SphereB.SetActive(true);
        // Virtual Button is in image target so we found it in children
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterOnButtonPressed(onButtonPressed);
        vrb.RegisterOnButtonReleased(onButtonRealesed);
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        CubeA.SetActive(true);
        SphereB.SetActive(false);
        Debug.Log("Button pressed");
    }

    public void onButtonRealesed(VirtualButtonBehaviour vb)
    {
        CubeA.SetActive(false);
        SphereB.SetActive(true);
        Debug.Log("Button released");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
