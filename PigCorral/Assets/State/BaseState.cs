using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    protected readonly Enemy _enemy;
    protected readonly IStationStateSwitcher _stateSwitcher;

    protected BaseState(Enemy enemy, IStationStateSwitcher stateSwitcher)
    {
        _enemy = enemy;
        _stateSwitcher = stateSwitcher;
    }
    public abstract void EnterState();
    public abstract void UpdateState();
    
    
}
    