using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    public Rail path;
    public PlayMode mode;

    public float Speed;

    private int currentSeg;
    private float transition;
    private bool Completed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!path)
        {
            return;
        }

        if (!Completed)
        {
            Play();
        }
    }

    void Play()
    {
        float m = (path.nodes[currentSeg + 1].position - path.nodes[currentSeg].position).magnitude;
        float speed = (Time.deltaTime * 1 / m) * Speed;
        transition += speed;
        if(transition > 1)
        {
            transition = 0;
            currentSeg++;
            if (currentSeg == path.nodes.Length - 1)
            {
                Completed = true;
                return;
            }
        }
        else if (transition < 0)
        {
            transition = 1;
            currentSeg++;
        }

        transform.position = path.posOnRail(currentSeg, transition, mode);
        transform.rotation = path.Orientation(currentSeg, transition);
    }
}
