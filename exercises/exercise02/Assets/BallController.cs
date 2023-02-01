using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public float launchForce;
    public Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.useGravity = true;
            rb.AddForce(gameObject.transform.forward * launchForce);
        }

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Cube")
        {
            Color customColor = new Color(1f, 0.5f, 0.4f, 1f);

            col.gameObject.GetComponent<Renderer>().material.color = customColor;

        }

    }
}
