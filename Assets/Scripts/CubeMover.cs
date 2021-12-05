using UnityEngine;

public class CubeMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField]
    private float speed = 1;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnCollisionExit(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
