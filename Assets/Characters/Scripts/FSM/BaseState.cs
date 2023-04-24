using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState
{
    public int stateID;
    public bool isPaused;

    public BaseState(int stateID)
    {
        this.stateID = stateID;
        this.isPaused = false;
    }

    public void Enter()
    {
        this.isPaused = false;
        this.OnEnter();
    }

    protected virtual void OnEnter()
    {
    }

    public void Leave()
    {
        this.isPaused = false;
        this.OnLeave();
    }

    protected virtual void OnLeave()
    {
    }

    public void Update()
    {
        this.OnUpdate();
    }

    protected virtual void OnUpdate()
    {
    }

    public void Pause()
    {
        this.isPaused = true;
        this.OnPause();
    }

    protected virtual void OnPause()
    {
    }

    public void Resume()
    {
        this.isPaused = false;
        this.OnResume();
    }

    public void OnResume()
    {
    }

    public void Dispose()
    {
        this.OnDispose();
    }

    protected virtual void OnDispose()
    {
    }

    public void PlayAnimation()
    {
        this.OnPlayAnimation();
    }

    public virtual void OnPlayAnimation()
    {
    }
}