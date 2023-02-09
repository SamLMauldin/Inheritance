using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerupBase : MonoBehaviour
{
    [SerializeField] private AudioClip _hitSound;
    [SerializeField] protected float PowerupDuration = 2f;
    [SerializeField] private GameObject _art;
    protected virtual void OnHit()
    {
        PowerUp();
        _art.SetActive(false);
        //gameObject.GetComponent(Collider).isTrigger = false;
        StartCoroutine(stopTimer());
    }

    private void Awake()
    {
        _art = GameObject.Find("Art");
    }

    protected abstract void PowerUp();

    protected abstract void PowerDown();

    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            AudioHelper.PlayClip2D(_hitSound, 1, .1f);
            OnHit();
        }
    }

    IEnumerator stopTimer()
    {
        yield return new WaitForSeconds(PowerupDuration);
        PowerDown();
        Debug.Log("Gone");
        this.gameObject.SetActive(false);
    }
}
