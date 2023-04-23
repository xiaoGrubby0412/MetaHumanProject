using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChanged : MonoBehaviour
{
    public enum AnimationState 
    {
        Idle = 1,
        Running = 2,
        SitToStand = 3,
        Sitting = 4,
        SittingIdle = 5,
        StandToSit = 6,
        Walk = 7,
    }

    string aniStr = "Armature|";

    public AnimationState CurState = AnimationState.Idle;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //PlayerAnimationByState(AnimationState.Idle1);
    }

    private void PlayerAnimationByState(AnimationState state)
    {
        string aniName = aniStr + Enum.GetName(typeof(AnimationState), state);
        if (state == AnimationState.SitToStand)
        {
            aniName = "Armature|Sit To Stand";
        }
        else if (state == AnimationState.StandToSit)
        {
            aniName = "Armature|Stand To Sit";
        }
        else if (state == AnimationState.SittingIdle)
        {
            aniName = "Armature|Sitting Idle";
        }

        animator.CrossFadeInFixedTime(aniName, 0.25f);
        CurState = state;
          
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            PlayerAnimationByState(AnimationState.Idle);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            PlayerAnimationByState(AnimationState.Running);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            PlayerAnimationByState(AnimationState.SitToStand);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            PlayerAnimationByState(AnimationState.Sitting);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            PlayerAnimationByState(AnimationState.SittingIdle);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            PlayerAnimationByState(AnimationState.StandToSit);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            PlayerAnimationByState(AnimationState.Walk);
        }
    }
}
