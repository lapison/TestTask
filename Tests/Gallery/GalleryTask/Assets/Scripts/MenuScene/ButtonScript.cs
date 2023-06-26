using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public  GameObject btn;

    public void onHover()
    {
        btn.GetComponent<Animation>().Play("BtnChg");
    }

    public void onExitHover()
    {
        btn.GetComponent<Animation>().Play("BtnBackChg");
    }
}
