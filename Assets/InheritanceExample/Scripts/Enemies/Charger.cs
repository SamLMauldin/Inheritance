using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{

    [SerializeField] GameObject _rapidFirePowerup;
    protected override void OnHit()
    {
        // increase speed when hit 
        MoveSpeed *= 2;
    }
    public override void Kill()
    {
        base.Kill();
        Instantiate(_rapidFirePowerup, transform.position, transform.rotation);
    }
}
