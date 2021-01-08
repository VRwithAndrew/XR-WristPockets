using Pixelplacement;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WristSocket : XRSocketInteractor
{
    // Sizing

    // Runtime

    // Prevents random objects from being selected

    protected override void OnHoverEntering(XRBaseInteractable interactable)
    {
        base.OnHoverEntering(interactable);

        // If the object is already selected, wrist can grab it
    }

    protected override void OnHoverExiting(XRBaseInteractable interactable)
    {
        base.OnHoverExiting(interactable);

        // If the wrist didn't grab the object, we can no longer select
    }

    protected override void OnSelectEntering(XRBaseInteractable interactable)
    {
        // Store object when select begins
        base.OnSelectEntering(interactable);
    }

    protected override void OnSelectEntered(XRBaseInteractable interactable)
    {
        // Once select has occured, scale object to size
        base.OnSelectEntered(interactable);
    }

    protected override void OnSelectExited(XRBaseInteractable interactable)
    {
        // Once the user has grabbed the object, scale to original size
        base.OnSelectExited(interactable);
    }

    private void StoreObjectSizeScale(XRBaseInteractable interactable)
    {
        // Find the object's size
    }

    private Vector3 FindObjectSize(GameObject objectToMeasure)
    {
        Vector3 size = Vector3.one;

        // Assumes the interactable has one mesh on the root

        return size;
    }

    private void TweenSizeToSocket(XRBaseInteractable interactable)
    {
        // Find the new scale based on the size of the collider, and scale

        // Tween to our new scale
    }

    private Vector3 FindTargetScale()
    {
        // Figure out new scale, we assume the object is originally uniformly scaled
        return Vector3.one;
    }

    private void SetOriginalScale(XRBaseInteractable interactable)
    {
        // This isn't necessary, but prevents an error when exiting play

        // Restore object to original scale

        // Reset just incase
    }

    private float FindLargestSize(Vector3 value)
    {
        return 0.0f;
    }

    public override XRBaseInteractable.MovementType? selectedInteractableMovementTypeOverride
    {
        // Move while ignoring physics, and no smoothing
        get { return XRBaseInteractable.MovementType.Instantaneous; }
    }

    // Is the socket active, and object is being held by different interactor
    public override bool isSelectActive => base.isSelectActive;

    private void OnDrawGizmos()
    {
        // Draw the approximate size of the socketed object
    }
}


