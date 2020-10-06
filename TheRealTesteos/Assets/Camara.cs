using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject player;
    public GameObject reference;

    private Vector3 distancia;


    // Start is called before the first frame update
    void Start()
    {
        distancia = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * distancia;

        transform.position = player.transform.position + distancia;
        transform.LookAt(player.transform.position);

        distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * 2, Vector3.right) * distancia;

        transform.position = player.transform.position + distancia;
        transform.LookAt(player.transform.position);


        Vector3 copiaRotacion = new Vector3(0, transform.eulerAngles.y, 0);
        reference.transform.eulerAngles = copiaRotacion;
    }
}
