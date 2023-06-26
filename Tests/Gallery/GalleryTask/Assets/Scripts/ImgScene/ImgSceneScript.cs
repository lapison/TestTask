using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImgSceneScript : MonoBehaviour
{
    public RawImage rw;

    void Start()
    {
        rw.texture = LoadSceneScript.textureLoad;
    }
}
