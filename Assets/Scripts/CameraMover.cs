using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    [SerializeField]
    private float turnspeed = 1;

    [SerializeField]
    private float movespeed = 1;

    // Update is called once per frame
    void Update()
    {
        float h = turnspeed * Input.GetAxis("Mouse X");
        float v = turnspeed * Input.GetAxis("Mouse Y");
        transform.Rotate(-v, h, 0);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position -= transform.up * Time.deltaTime * movespeed;
        }
    }
}
