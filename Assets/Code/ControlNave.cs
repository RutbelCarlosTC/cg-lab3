using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNave : MonoBehaviour
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
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up);
        }

        if (Input.GetKey(KeyCode.D))
        {
            var rotarDerecha = transform.rotation;
            rotarDerecha.z -= Time.deltaTime * 1;
            transform.rotation = rotarDerecha;
        }
        if (Input.GetKey(KeyCode.D))
        {
            var rotarIzquierda = transform.rotation;
            rotarIzquierda.z += Time.deltaTime * 1;
            transform.rotation = rotarIzquierda;
        }
    }
}
