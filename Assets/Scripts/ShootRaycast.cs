using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRaycast : MonoBehaviour
{
    public Transform shootPoint;
    public LayerMask layerEnemy;

    void Update()
    {
            Debug.DrawRay( shootPoint.transform.position , 
            transform.TransformDirection( Vector3.forward ) * 20f , Color.green );

        if ( Physics.Raycast( shootPoint.transform.position , 
            transform.TransformDirection(Vector3.forward) 
            ,out RaycastHit hitInfo , 20f , layerEnemy))
        {
            Debug.Log( $"Hit { hitInfo.collider.gameObject.tag }!" );

            Debug.DrawRay(shootPoint.transform.position, 
                transform.TransformDirection(Vector3.forward)
                * hitInfo.distance, Color.red);
        }

    }// Update
}//ShootRaycast

