using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health = 100;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= Mathf.Epsilon)
        {
            Debug.Log("You Are Dead!");
        }
    }
}
