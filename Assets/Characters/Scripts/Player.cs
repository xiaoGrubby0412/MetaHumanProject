using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public Transform trackingOriginTransform;
    public Transform trackingInterliningTransform;
    public Transform hmdTransform;

    private PlayerFsmMachine fsmMachine;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        fsmMachine = new PlayerFsmMachine();
    }

    private void Update()
    {
        fsmMachine.Update();
    }

    private void OnDestroy()
    {
        fsmMachine.Dispose();
        Instance = null;
    }
}