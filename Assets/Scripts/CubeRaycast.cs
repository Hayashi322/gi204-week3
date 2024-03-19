using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRaycast : MonoBehaviour
{
    

    
    void Update()
    {

        Debug.DrawRay( transform.position, transform.forward * 20 , Color.green );

        if (Physics.Raycast( transform.position, transform.forward , out RaycastHit hitInfo , 20f ))
        {
            if( hitInfo.collider.tag == "Star" )
            {
                hitInfo.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;

                hitInfo.collider.gameObject.GetComponent<Rigidbody>().useGravity = true;
            }
        }

    }// Update
}//CubeRaycast
