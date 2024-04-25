using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recastIT : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private float distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction =transform.forward;
        //direction = direction.normalized;
        //direction = Vector3.Normalize(direction);

        RaycastHit hit;
        Debug.DrawRay(transform.position, direction * distance, Color.blue, 3f);

       
        if (Physics.SphereCast(transform.position, 1f, direction, out hit, distance))
        {
            if (hit.collider.transform == target)
            {
                transform.position += direction * 10 * Time.deltaTime;
            };
            
        }
    }

}
