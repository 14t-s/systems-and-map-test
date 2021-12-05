using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    public void zshowObject(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void zhideObject(GameObject obj)
    {
        obj.SetActive(false);
    }
}
