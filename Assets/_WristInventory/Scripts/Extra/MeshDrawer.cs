using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MeshDrawer : MonoBehaviour
{
    public Material previewMaterial = null;
    private WristSocket wristSocket = null;

    private MeshFilter interactableMeshFilter = null;

    private void Awake()
    {
        wristSocket = GetComponent<WristSocket>();
    }

    private void OnEnable()
    {
        wristSocket.onSelectEntered.AddListener(GetMeshFilter);
    }

    private void OnDisable()
    {
        wristSocket.onSelectEntered.RemoveListener(GetMeshFilter);
    }

    private void GetMeshFilter(XRBaseInteractable interactable)
    {
        interactableMeshFilter = interactable.GetComponent<MeshFilter>();
    }

    private void Update()
    {
        if(HasObject())
        {
            if (HasTouchingInteractor(out XRBaseInteractor interactor))
                DrawMesh(interactor);
        }
    }

    private bool HasObject()
    {
        return wristSocket.selectTarget;
    }

    private bool HasTouchingInteractor(out XRBaseInteractor interactor)
    {
        bool isTouching = wristSocket.selectTarget.hoveringInteractors.Count == 1;
        interactor = isTouching ? wristSocket.selectTarget.hoveringInteractors[0] : null;
        return isTouching;
    }

    private void DrawMesh(XRBaseInteractor interactor)
    {
        /*
        Vector3 position = interactor.attachTransform.position;
        Quaternion rotation = interactor.attachTransform.rotation;
        Vector3 scale = wristSocket.HeldObjectScale;

        Matrix4x4 matrix = Matrix4x4.TRS(position, rotation, scale);
        Graphics.DrawMesh(interactableMeshFilter.sharedMesh, matrix, previewMaterial, 0);
        */
    }
}
