using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CubeSelectImage : MonoBehaviour
{

    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent();
    public RawImage image;

    // Use this for initialization
    void Start()
    {
        definedButton = this.gameObject;
        image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                Debug.Log(gameObject.name);
                Texture mainTexture = gameObject.GetComponent<MeshRenderer>().material.mainTexture;
                image.texture = mainTexture;
                image.enabled = !image.enabled;
                

                OnClick.Invoke();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            image.enabled = false;
        }
    }
}
