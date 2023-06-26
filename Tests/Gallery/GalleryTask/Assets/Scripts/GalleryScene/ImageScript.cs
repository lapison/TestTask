using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public RawImage rw;
    public void onClick()
    {
        LoadSceneScript.textureLoad = rw.texture;
    }
}
