using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerakan : MonoBehaviour
{
    public float kecepatan;
    Animator anim;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

        // Update is called once per frame
        void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * kecepatan * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * kecepatan * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * kecepatan * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * kecepatan * Time.deltaTime);
        }

        if (Input.GetKeyDown("space"))
        {
            anim.SetTrigger("lompat");
            // melompat = true
        }
    }
}
