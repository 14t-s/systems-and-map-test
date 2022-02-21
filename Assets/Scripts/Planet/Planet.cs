using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private int resourceYield1;
    private int resourceYield2;
    private int resourceYield3;


    public GameObject hostObject;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(hostObject.transform.position, Vector3.down, 1 * Time.deltaTime);
    }

    public void zextractResource()
    {


    }

}
