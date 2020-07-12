using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimateTrain : MonoBehaviour
{
    public float Speed = 1f;
    public float BigWheelSpeedScaling = 0.5f;
    public Transform BigWheel;
    public Transform MidWheel;
    public Transform FrontWheel;
    public float WobbleSpeed;
    private int WobbleHash;
    private Animator Animator;

    private void Awake()
    {
        Animator = GetComponent<Animator>();
        WobbleHash = Animator.StringToHash("WobbleSpeed");
    }

    // Update is called once per frame
    void Update()
    {
        RotateWheels();
        SetWobbleSpeed();
    }

    void SetWobbleSpeed()
    {
        Animator.SetFloat(WobbleHash, Speed);
    }

    void RotateWheels()
    {
        BigWheel.Rotate(Speed * BigWheelSpeedScaling, 0, 0);
        MidWheel.Rotate(Speed, 0, 0);
        FrontWheel.Rotate(Speed, 0, 0);
    }
}
