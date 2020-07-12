using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinRail : MonoBehaviour
{
    public LayerMask whatIsTrain;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] other = Physics.OverlapSphere(transform.position, 2f, whatIsTrain);
        foreach(Collider col in other)
        {
            if (col.CompareTag("Train"))
            {
                Debug.Log("You Win!");
            }
        }
        
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 2f);
    }
}
