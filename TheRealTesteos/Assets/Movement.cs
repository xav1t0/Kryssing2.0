using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Dynamic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;

    public float fuerzaSalto = 8f;
    public bool puedoSaltar;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        puedoSaltar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(0,0,-1 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(0, 0, 1 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate(1 * Time.deltaTime, 0, 0 );
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(-1 * Time.deltaTime, 0, 0 );
        }
            
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.Translate(0, 50 * Time.deltaTime, 0);
        }
      
        /*void OnCollisionEnter(Collision collision)
        {
            GameObject objeto1 = GameObject.Find("Player");
            if (collision.gameObject.name == "suelo")
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    player.transform.Translate(0, 50 * Time.deltaTime, 0);
                }
            }
        }*/

        /*if (puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);

                //Debug.Log("salto"); 
            }
        }*/
    }
}
