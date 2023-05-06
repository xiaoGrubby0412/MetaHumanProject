using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStateWalk : BaseState
{
    public PlayerStateWalk(int stateID) : base(stateID)
    {
        this.aniName = "Armature|Walk";
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