using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocoSuelo : MonoBehaviour
{
    public Movement Mov;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Mov.puedoSaltar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Mov.puedoSaltar = false;
    }
}
