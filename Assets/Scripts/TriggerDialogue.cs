using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    public DialogSystem keka;
    public bool canStart;

     public void OnTriggerStay(Collider other)
    {
        print("In Trigger");
        canStart = true;
        if (Input.GetKeyUp(KeyCode.G))
        {
            keka.StartDialogue();
        }
                
        
    }
    
}
