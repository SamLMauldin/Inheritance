using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{
    private bool _isHit = false;
    protected override void OnHit()
    {
        if (!_isHit)
        {
            _isHit = true;
            MoveSpeed = 0f;
            StartCoroutine(stopTimer());
        }
    }

    IEnumerator stopTimer()
    {
        yield return new WaitForSeconds(1);
        MoveSpeed = 0.05f;
        _isHit = false ;
    }
}
