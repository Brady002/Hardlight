using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int health = 10;
    public int maxHealth = 10;
    public float healthRegenDelay = 5f;
    public float healthRegenCooldown = 1f;
    public int amountHealed = 1;
    bool canHeal = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(health);
        
    }

    // Update is called once per frame
    void Update()
    {;
        if(health <= 0)
        {
            Respawn();
        }
        if(health > maxHealth)
        {
            canHeal = false;
        }
        Debug.Log(health);
    }

    public void TakeDamage(int damage)
    {
        StopCoroutine(DelayTimer());
        StopCoroutine(StartHealing());
        canHeal = false;
        health -= damage;
        if (health < maxHealth)
        {
            StartCoroutine(DelayTimer());
        }

    }

    IEnumerator DelayTimer()
    {
        yield return new WaitForSeconds(healthRegenDelay);
        canHeal = true;
        
        StartCoroutine(StartHealing());
        StopCoroutine(DelayTimer());
    }

    IEnumerator StartHealing()
    {
        yield return new WaitForSeconds(healthRegenCooldown);
        if (canHeal && health < maxHealth) 
        {
            for(int i = health; i < maxHealth; i += amountHealed)
            {
                yield return new WaitForSeconds(healthRegenCooldown);
                health += amountHealed;
                
            }
            
        }
        
        
    }

    void Respawn()
    {
        health = maxHealth;
        Debug.Log("You Died");
    }

}
