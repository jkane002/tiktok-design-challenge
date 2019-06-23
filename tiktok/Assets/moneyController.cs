using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class moneyController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject HarrietTubmanBill;
    bool ifPressed = false;
    bool isTubmanActive = false;
    
    void Start()
    {
        HarrietTubmanBill.SetActive(isTubmanActive);
    }

    // Update is called once per frame
    void Update()
    {
        ifPressed = CrossPlatformInputManager.GetButton("SwitchButton");
        if(ifPressed) {
            HarrietFn();
        }
    }

    void HarrietFn() {
        if (isTubmanActive)
        {
            isTubmanActive = false;
            HarrietTubmanBill.SetActive(isTubmanActive);
        }
        else if (!isTubmanActive)
        {
            isTubmanActive = true;
            HarrietTubmanBill.SetActive(isTubmanActive);
        }
    }
}


