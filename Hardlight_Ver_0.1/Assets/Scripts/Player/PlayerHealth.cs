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
        StartCoroutine(StartHealing());
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Respawn();
        }
        if(health > maxHealth)
        {
            health = maxHealth;
            canHeal = false;
        }
        if(!canHeal)
        {
            healthRegenDelay -= Time.deltaTime;
        }
        if(healthRegenDelay <= 0)
        {
            healthRegenDelay = 5f;
            canHeal = true;
        }
    }

    public void TakeDamage(int damage)
    {
        canHeal = false;
        health -= damage;
        Debug.Log("ow");
        healthRegenDelay = 5f;

    }

    IEnumerator StartHealing()
    {
        while (true)
        {
            yield return new WaitForSeconds(healthRegenCooldown);
            if (canHeal && health < maxHealth)
            {
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
