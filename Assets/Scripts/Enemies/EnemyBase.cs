﻿using UnityEngine;
using System.Collections;

public class EnemyBase : EntityBase
{
    public bool IsActive = false;

    public override void Die()
    {
        Debug.Log("EnemeyBase Die");
    }

    public void Activate()
    {
        IsActive = true;
    }


}
