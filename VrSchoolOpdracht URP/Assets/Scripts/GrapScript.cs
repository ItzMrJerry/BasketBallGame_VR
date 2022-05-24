using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class GrapScript : MonoBehaviour
{
    private Interactable interactable;
    private void Start()
    {
        interactable = GetComponent<Interactable>();
    }
    private void OnHandHoverBegin(Hand hand)
    {
        
    }


    //-------------------------------------------------
    private void OnHandHoverEnd(Hand hand)
    {
        
    }
    private void OnHandHoverUpdate(Hand hand)
    {
        GrabTypes grapType = hand.GetGrabStarting();
        bool isGrabEnd = hand.IsGrabEnding(gameObject);

        if(interactable.attachedToHand == null && grapType != GrabTypes.None)
        {
            hand.AttachObject(gameObject, grapType);
            hand.HoverLock(interactable);
        } else if (isGrabEnd)
        {
            hand.DetachObject(gameObject);
            hand.HoverUnlock(interactable);
        }
    }
}
