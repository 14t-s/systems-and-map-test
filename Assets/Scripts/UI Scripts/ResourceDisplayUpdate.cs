using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceDisplayUpdate : MonoBehaviour
{
    private int resource1 = 2;
    private int resource2 = 1;
    private int resource3 = 0;

    public Text resourcetext1;
    public Text resourcetext2;
    public Text resourcetext3;

    // Update is called once per frame
    void Update()
    {
        resourcetext1.text = "Resource 1: " + resource1;
        resourcetext2.text = "Resource 2: " + resource2;
        resourcetext3.text = "Resource 3: " + resource3;
    }

    public void updateResource1(int r1)
    {
        
    }
    public void updateResource2(int r2)
    {

    }
    public void updateResource3(int r3)
    {

    }

}
