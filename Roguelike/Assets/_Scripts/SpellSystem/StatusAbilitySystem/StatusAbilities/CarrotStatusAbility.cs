using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class CarrotStatusAbility : StatusAbility
{

    private CarrotStatusConfig _config;

    private BaseEnemy _enemyObject;

    public CarrotStatusAbility(StatusAbilityConfig config)
    {
        _config = (CarrotStatusConfig)config;
    }

    public override void Added(BaseEnemy enemyObject)
    {
        _enemyObject = enemyObject;
    }
    public override void Update()
    {
        if (IsActive)
        {
            LifeTime += Time.deltaTime;
            CheckDelayTimer += Time.deltaTime;

            if (CheckDelayTimer >= DelayTime) 
            {
                _enemyObject.TakeDamage(DamegeCount);
                CheckDelayTimer = 0.0f;
            }

            if (LifeTime >= ActionTime)
            {
                StopCast();
            }
        }
    }
    public override void StartCast()
    {
        LifeTime = 0.0f;
        CheckDelayTimer = 0.0f;
        IsActive = true;
    }
    public override void StopCast()
    {
        IsActive = false;
    }
}