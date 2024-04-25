using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
   [SerializeField] private Transform target;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.Normalize(target.position - transform.position);
        //direction = direction.normalized;
        //direction = Vector3.Normalize(direction);

        RaycastHit hit;
        Debug.DrawRay(transform.position, direction * 10, Color.blue, 3f);

        if (Physics.Raycast(transform.position, direction, out hit, 10f))
        {
            if (hit.collider.transform == target)
            {
                transform.position += direction * 10 * Time.deltaTime;
            };
            
        }
    }

}
