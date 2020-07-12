using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    private GameObject r1;
    private GameObject r2;
    private GameObject r3;
    private GameObject r4;
    private GameObject r9;
    private GameObject r11;

    private GameObject r5;
    private GameObject r6;
    private GameObject r7;
    private GameObject r8;
    private GameObject r10;
    private GameObject r12;

    public LayerMask whatIsRail;
    public GameObject MoveableRail;

    Vector3 targetPos;

    private float SnapDistance = 5f;

    private bool isFixed;

    [Header("Rails")]
    public GameObject leftFacingRail;
    public GameObject upFacingRail;
    public GameObject rightFacingRail;
    public GameObject rightFacingStraightRail;
    public GameObject leftFacingStraightRail;
    public GameObject leftFacingRail1;
    public GameObject rightFacingRail1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isFixed = !isFixed;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!isFixed)
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + SnapDistance);
                transform.position = targetPos;
                r1 = Instantiate(MoveableRail, transform.position, Quaternion.identity);
            }
            else
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                r5 = Instantiate(upFacingRail, transform.position, Quaternion.identity);
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (!isFixed)
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - SnapDistance);
                transform.position = targetPos;
                r2 = Instantiate(MoveableRail, transform.position, Quaternion.identity);
            }
            else
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                r6 = Instantiate(upFacingRail, transform.position, Quaternion.identity);
            }        
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (!isFixed)
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                targetPos = new Vector3(transform.position.x - SnapDistance, transform.position.y, transform.position.z);
                transform.position = targetPos;
                r3 = Instantiate(MoveableRail, transform.position, Quaternion.identity);
            }
            else
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                r7 = Instantiate(leftFacingRail, transform.position, Quaternion.identity);
            }     
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!isFixed)
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                targetPos = new Vector3(transform.position.x + SnapDistance, transform.position.y, transform.position.z);
                transform.position = targetPos;
                r4 = Instantiate(MoveableRail, transform.position, Quaternion.identity);
            }
            else
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                r8 = Instantiate(rightFacingRail, transform.position, Quaternion.identity);
            }           
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (!isFixed)
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                targetPos = new Vector3(transform.position.x + SnapDistance, transform.position.y, transform.position.z);
                transform.position = targetPos;
                r9 = Instantiate(rightFacingStraightRail, transform.position, Quaternion.identity);
                r9.transform.Rotate(Vector3.up, 90f);
            }
            else
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                r10 = Instantiate(rightFacingRail1, transform.position, Quaternion.identity);
                r10.transform.Rotate(Vector3.up, 90f);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (!isFixed)
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                targetPos = new Vector3(transform.position.x - SnapDistance, transform.position.y, transform.position.z);
                transform.position = targetPos;
                r11 = Instantiate(leftFacingStraightRail, transform.position, Quaternion.identity);
                r11.transform.Rotate(Vector3.up, -90f);
            }
            else
            {
                Destroy(r1);
                Destroy(r2);
                Destroy(r3);
                Destroy(r4);
                Destroy(r5);
                Destroy(r6);
                Destroy(r7);
                Destroy(r8);
                Destroy(r9);
                Destroy(r10);
                Destroy(r11);
                Destroy(r12);
                r12 = Instantiate(leftFacingRail1, transform.position, Quaternion.identity);
                r12.transform.Rotate(Vector3.up, -90f);
            }
        }
    }
}
