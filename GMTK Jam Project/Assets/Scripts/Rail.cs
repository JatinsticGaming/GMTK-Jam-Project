using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayMode
{
    Linear,
    Catmull,
}

[ExecuteInEditMode]
public class Rail : MonoBehaviour
{
    public Transform[] nodes;

    void OnDrawGizmos()
    {
        for (int i = 0; i < nodes.Length - 1; i++)
        {
            Debug.DrawLine(nodes[i].position, nodes[i + 1].position, Color.white);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        nodes = GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    public Vector3 posOnRail(int seg, float ratio, PlayMode mode)
    {
        switch (mode)
        {
            default:
            case PlayMode.Linear:
                return LPos(seg, ratio);
            case PlayMode.Catmull:
                return CatMolPos(seg, ratio);
        }
    } 



    public Vector3 LPos(int seg, float ratio)
    {
        Vector3 pos1 = nodes[seg].position;
        Vector3 pos2 = nodes[seg + 1].position;

        return Vector3.Lerp(pos1, pos2, ratio);
    }

    public Vector3 CatMolPos(int seg, float ratio)
    {
        Vector3 pos1, pos2, pos3, pos4;

        if (seg == 0)
        {
            pos1 = nodes[seg].position;
            pos2 = pos1;
            pos3 = nodes[seg + 1].position;
            pos4 = nodes[seg + 2].position;
        }
        else if (seg == nodes.Length - 2)
        {
            pos1 = nodes[seg - 1].position;
            pos2 = nodes[seg].position;
            pos3 = nodes[seg + 1].position;
            pos4 = pos3;
        }
        else
        {
            pos1 = nodes[seg - 1].position;
            pos2 = nodes[seg].position;
            pos3 = nodes[seg + 1].position;
            pos4 = nodes[seg + 2].position;
        }

        float t2 = ratio * ratio;
        float t3 = t2 * ratio;

        float x = 0.5f * ((2.0f * pos2.x) + (-pos1.x + pos3.x) * ratio + (2.0f * pos1.x - 5.0f * pos2.x + 4 * pos3.x - pos4.x) * t2 + (-pos1.x + 3.0f * pos2.x - 3.0f * pos3.x + pos4.x) * t3);
        float y = 0.5f * ((2.0f * pos2.y) + (-pos1.y + pos3.y) * ratio + (2.0f * pos1.y - 5.0f * pos2.y + 4 * pos3.y - pos4.y) * t2 + (-pos1.y + 3.0f * pos2.y - 3.0f * pos3.y + pos4.y) * t3);
        float z = 0.5f * ((2.0f * pos2.z) + (-pos1.z + pos3.z) * ratio + (2.0f * pos1.z - 5.0f * pos2.z + 4 * pos3.z - pos4.z) * t2 + (-pos1.z + 3.0f * pos2.z - 3.0f * pos3.z + pos4.z) * t3);

        return new Vector3(x, y, z);
    }

    public Quaternion Orientation(int seg, float ratio)
    {
        Quaternion qua1 = nodes[seg].rotation;
        Quaternion qua2 = nodes[seg + 1].rotation;

        return Quaternion.Lerp(qua1, qua2, ratio);
    }
}
