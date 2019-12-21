using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health = 100;

    private DeathHandler deathHandler;

    private void Start()
    {
        deathHandler = GetComponent<DeathHandler>();
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= Mathf.Epsilon)
        {
            deathHandler.HandleDeath();
        }
    }
}
