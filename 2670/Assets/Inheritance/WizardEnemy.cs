using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardEnemy : EnemyBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    protected override void Update()
    {
        base.Update();
        DoDamage();
    }
}
