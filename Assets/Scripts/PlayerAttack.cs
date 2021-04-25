using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public LayerMask vending;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwAttack <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("ATTACK!");
                timeBtwAttack = startTimeBtwAttack;
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(
                    attackPos.position, attackRange, whatIsEnemies);
                Collider2D[] vendingMachines = Physics2D.OverlapCircleAll(
                    attackPos.position, attackRange, vending);
                for (int i = 0; i < vendingMachines.Length; i++)
                {
                    vendingMachines[i].GetComponent<VendingMachine>().HealPlayer();
                }
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }
}
