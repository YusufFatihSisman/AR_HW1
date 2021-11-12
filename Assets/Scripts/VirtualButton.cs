using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour
{

    public GameObject mirage;
    VirtualButtonBehaviour vbBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        vbBehaviour = GetComponentInChildren<VirtualButtonBehaviour>();

        vbBehaviour.RegisterOnButtonPressed(OnButtonPressed);
        vbBehaviour.RegisterOnButtonReleased(OnButtonReleased);
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb){
        mirage.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
        mirage.SetActive(true);
    }

}
