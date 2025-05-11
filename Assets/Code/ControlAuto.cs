using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAuto : MonoBehaviour
{
    Rigidbody rb;
    Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarInput();
    }

    private void ProcesarInput()
    {
        if (Input.GetKey(KeyCode.X))
        {
            rb.AddRelativeForce(Vector3.up);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.AddForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.RightControl))
        {
            rb.AddForce(Vector3.right);
        }
    }
}
