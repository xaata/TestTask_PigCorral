using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{
    public IdleState(Enemy enemy, IStationStateSwitcher stateSwitcher) : base(enemy, stateSwitcher)
    {
    }

    public override void EnterState() { }
    public override void UpdateState() { }
}
