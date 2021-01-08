using UnityEngine;

public class BoundsTest : MonoBehaviour
{
    private MeshRenderer meshRenderer = null;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        print(meshRenderer.bounds.size.x);
    }
}
