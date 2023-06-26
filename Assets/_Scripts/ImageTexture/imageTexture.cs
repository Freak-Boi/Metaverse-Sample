

using System.Collections.Generic;

using UnityEngine;

public class imageTexture : MonoBehaviour
{
    public GameObject planesHolder;
    public Texture[] planeImages; 
    private List<GameObject> planes = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform plane in planesHolder.transform)
        {
            
            planes.Add(plane.gameObject);
        }
        for (int i = 0; i < planes.Count; i++)
        {
            MeshRenderer meshRenderer = planes[i].GetComponent<MeshRenderer>();
            meshRenderer.material = new Material(Shader.Find("Standard"));
            meshRenderer.material.mainTexture = planeImages[i];
            planes[i].GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
            meshRenderer.material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.None;
            meshRenderer.material.SetTexture("_EmissionMap", planeImages[i]);
            meshRenderer.material.SetColor("_EmissionColor", Color.white * 0.5f);
            
        }
    }
}
