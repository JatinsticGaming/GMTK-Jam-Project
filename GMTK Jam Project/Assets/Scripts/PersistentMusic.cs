using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PersistentMusic : MonoBehaviour
{
    private AudioSource audio;
    public bool FastMode = false;
    public float FastModeSpeed = 1.25f;
    // Start is called before the first frame update
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
        DontDestroyOnLoad(this);
    }

    private void Start()
    {

    }
}
