using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonAggressiveEnemyState
{
    protected readonly NonAggressiveEnemy enemy;
    protected NonAggressiveStateMachine nonAggressiveEnemyStateMachine;

    protected NonAggressiveEnemyState(NonAggressiveEnemy enemy, NonAggressiveStateMachine nonAggressiveEnemyStateMachine)
    {
        this.enemy = enemy;
        this.nonAggressiveEnemyStateMachine = nonAggressiveEnemyStateMachine;
    }
    
    public virtual void EnterState() {}
    public virtual void ExitState() {}
    public virtual void FrameUpdate() {}
    public void FixedUpdate() {}
}