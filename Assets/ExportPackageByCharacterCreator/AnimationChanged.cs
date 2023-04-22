using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChanged : MonoBehaviour
{
    public enum AnimationState 
    {
        Idle01 = 1,
        Run = 2,
        Sitting01 = 3,
        Sitting02 = 4,
        Sitting03 = 5,
        SitToStand = 6,
        StandToSitting = 7,
    }

    string aniStr = "Armature|";

    public AnimationState CurState = AnimationState.Idle01;
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
        animator.CrossFadeInFixedTime(aniName, 0.25f);
        CurState = state;
          
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            PlayerAnimationByState(AnimationState.Idle01);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            PlayerAnimationByState(AnimationState.Run);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            PlayerAnimationByState(AnimationState.Sitting01);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            PlayerAnimationByState(AnimationState.Sitting02);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            PlayerAnimationByState(AnimationState.Sitting03);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            PlayerAnimationByState(AnimationState.SitToStand);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            PlayerAnimationByState(AnimationState.StandToSitting);
        }
    }
}
