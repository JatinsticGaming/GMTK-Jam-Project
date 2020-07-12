using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EndRails : MonoBehaviour
{
    public Canvas WinScreen;
    private Animator[] AnimatorsFound;
    public Animator WinScreenBackgroundAnim;
    public Animator UIAnim;

    // Start is called before the first frame update
    void Start()
    {
        AnimatorsFound = FindObjectsOfType<Animator>();
        foreach(Animator other in AnimatorsFound)
        {
            if(other.name == "Background")
            {
                WinScreenBackgroundAnim = other;
            }
            else if(other.name == "UI")
            {
                UIAnim = other;
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            // End the Level...
            WinScreenBackgroundAnim.SetTrigger("FadeIn");
            UIAnim.SetTrigger("ComeDown");
        }
    }
}
