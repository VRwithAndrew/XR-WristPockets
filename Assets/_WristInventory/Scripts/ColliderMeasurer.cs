using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class ColliderMeasurer : MonoBehaviour
{
    public static ColliderMeasurer Instance = null;
    private MeshFilter meshFilter = null;

    private void Awake()
    {
        // Cheap singleton
        Instance = this;

        // Get it 
        meshFilter = GetComponent<MeshFilter>();
    }

    private void Start()
    {
        // Make sure this isn't rotated to combat axis alignment
        transform.rotation = Quaternion.identity;
    }

    public Vector3 Measure(Mesh mesh)
    {
        // Set the mesh 
        meshFilter.sharedMesh = mesh;

        // Get the size of the mesh, and factor in the object size
        Vector3 size = meshFilter.sharedMesh.bounds.size;

        // Clear the mesh
        meshFilter.sharedMesh = null;

        return size;
    }

    private void OnValidate()
    {
        // Always make sure the rotate is zero'd out
        if (transform.rotation != Quaternion.identity)
            transform.rotation = Quaternion.identity;
    }
}
