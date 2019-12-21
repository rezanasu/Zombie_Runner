using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        this.hitPoints -= damage;
        if(hitPoints <= Mathf.Epsilon)
        {
            Destroy(gameObject);
        }
    }
}
