using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public interface IInputService
{
    public event Action JumpPressed;
    public event Action UseStarted;
    public event Action UseStopped;
    public event Action<Vector2> LookPerformed;

    public Vector2 Direction { get; }
    public bool IsUsing { get; }
}

//SCHOOL MASTER