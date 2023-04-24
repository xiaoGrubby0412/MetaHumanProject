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
    public Animator animator;

    private void Awake()
    {
        Instance = this;
        animator = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        fsmMachine = new PlayerFsmMachine();
        fsmMachine.AddState(new PlayerStateIdle((int)PlayerFsmMachine.PlayerStateID.Idle));
        fsmMachine.AddState(new PlayerStateRun((int)PlayerFsmMachine.PlayerStateID.Running));
        fsmMachine.AddState(new PlayerStateSitting((int)PlayerFsmMachine.PlayerStateID.Sitting));
        fsmMachine.AddState(new PlayerStateStandToSit((int)PlayerFsmMachine.PlayerStateID.StandToSit));
        fsmMachine.SetInitState((int)PlayerFsmMachine.PlayerStateID.Idle);
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

    public void SwitchState(PlayerFsmMachine.PlayerStateID stateID)
    {
        if (fsmMachine.curState.stateID != (int)stateID)
        {
            if (fsmMachine.curState.stateID == (int)PlayerFsmMachine.PlayerStateID.Sitting ||
                fsmMachine.curState.stateID == (int)PlayerFsmMachine.PlayerStateID.StandToSit)
            {
                if (stateID == PlayerFsmMachine.PlayerStateID.Idle)
                {
                    return;
                }
            }

            fsmMachine.Switch((int)stateID);
        }
    }
}