using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStateIdle : BaseState
{
    protected override void OnEnter()
    {
        base.OnEnter();
    }

    protected override void OnLeave()
    {
        base.OnLeave();
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();
    }

    protected override void OnPause()
    {
        base.OnPause();
    }

    protected override void OnDispose()
    {
        base.OnDispose();
    }

    public override void OnPlayAnimation()
    {
        base.OnPlayAnimation();
    }

    public PlayerStateIdle(int stateID) : base(stateID)
    {
    }
}