using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOninput : MonoBehaviour
{
    public InputActionProperty pinchAnimatorAction;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimatorAction.action.ReadValue<float>();

        Debug.Log(triggerValue);
    }
    
    







    
    
    
}

