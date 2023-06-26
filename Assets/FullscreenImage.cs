using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullscreenImage : MonoBehaviour
{
    public RawImage rawImage;

    public void SetTexture(Texture texture)
    {
        rawImage.texture = texture;
    }
}
