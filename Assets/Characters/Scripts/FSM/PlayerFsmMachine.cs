using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFsmMachine : BaseFsmMachine
{
    public enum PlayerStateID
    {
        Idle = 1,
        Running = 2,
        Sitting = 4,
        StandToSit = 6,
        Walk = 7,
    }
    
    public override void OnInit()
    {
        base.OnInit();
    }
}