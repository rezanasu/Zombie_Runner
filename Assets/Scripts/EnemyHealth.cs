using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    private Animator enemyAnimator;
    private bool isDead = false;

    public bool IsDead() { return isDead; }

    private void Start()
    {
        enemyAnimator = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        this.hitPoints -= damage;
        if(hitPoints <= Mathf.Epsilon)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;

        isDead = true;
        enemyAnimator.SetTrigger("die");
    }
}
