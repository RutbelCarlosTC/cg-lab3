using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAuto : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarInput();
    }

    private void ProcesarInput()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right);
        }
    }
}
