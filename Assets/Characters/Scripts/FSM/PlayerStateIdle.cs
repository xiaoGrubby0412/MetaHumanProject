﻿using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStateIdle : BaseState
{
    public PlayerStateIdle(int stateID) : base(stateID)
    {
        this.aniName = "Armature|Idle";
    }
    
    protected override void OnEnter()
    {
        base.OnEnter();
        Player.Instance.animator.CrossFadeInFixedTime(aniName, 0.1f);
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
}