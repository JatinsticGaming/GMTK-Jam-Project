using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ClickySoundOnSelection : MonoBehaviour
{
    private AudioSource clickSource;

    private void Awake()
    {
        clickSource = GetComponent<AudioSource>();
    }
    private void OnMouseEnter()
    {
        clickSource.Play();
    }
}
