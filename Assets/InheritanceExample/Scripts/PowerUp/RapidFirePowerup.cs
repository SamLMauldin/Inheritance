using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFirePowerup : PowerupBase
{
    TurretController _yourTurret;
    private float _originalCoolDown = 0.5f;

    private void Awake()
    {
        _yourTurret = FindObjectOfType<TurretController>();
    }
    protected override void PowerDown()
    {
        _yourTurret.FireCooldown = _originalCoolDown;
    }

    protected override void PowerUp()
    {
        _yourTurret.FireCooldown = _originalCoolDown/2;
    }
}
