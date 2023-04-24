using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BaseFsmMachine
{
    private Dictionary<int, BaseState> states;
    private BaseState curState;

    public BaseFsmMachine()
    {
        this.states = new Dictionary<int, BaseState>();
    }

    public void Init()
    {
        this.OnInit();
    }

    public virtual void OnInit()
    {
    }

    public void AddState(BaseState state)
    {
        this.states[state.stateID] = state;
    }

    public void SetInitState(int stateID)
    {
        if (this.states[stateID] == null)
        {
            Debug.LogError("in FsmMachine:SetInitState id == " + stateID);
            return;
        }

        this.curState = this.states[stateID];
    }

    public void Update()
    {
        if (this.curState != null)
        {
            this.curState.Update();
        }
    }

    public void Switch(int stateID)
    {
        if (this.curState.stateID != stateID)
        {
            this.curState.Leave();
            this.curState = this.states[stateID];
            if (this.curState.isPaused)
            {
                this.curState.Resume();
            }
            else
            {
                this.curState.Enter();
            }
        }
        else
        {
            this.curState.Enter();
        }
    }

    public void SwitchWithPause(int stateID)
    {
        if (this.curState.stateID != stateID)
        {
            this.curState.Pause();
            this.curState = this.states[stateID];
            this.curState.Enter();
        }
    }

    public void Dispose()
    {
        this.curState = null;
        if (this.states != null)
        {
            foreach (KeyValuePair<int, BaseState> pair in this.states)
            {
                pair.Value.Dispose();
            }
        }

        this.states = null;
    }
}