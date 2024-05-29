using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    [HideInInspector] public int currentHealth;

    public HealthBar healthBar;

    private float safeTime;
    public float safeTimeDuration = 0f;
    public bool isDead = false;

    public bool camShake = false;

    private void Start()
    {
        currentHealth = maxHealth;

        if (healthBar != null)
            healthBar.UpdateHealth(currentHealth, maxHealth);
    }

    public void TakeDam(int damage)
    {
        if (safeTime <= 0)
        {
            currentHealth -= damage;

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                

                Destroy(gameObject, 0.125f); // Xóa đối tượng khi currentHealth <= 0
                
                isDead = true;
                FindObjectOfType<WeaponManager>()?.RemoveEnemyToFireRange(transform);
                FindObjectOfType<Killed>()?.UpdateKilled();
                FindObjectOfType<PlayerExp>()?.UpdateExperience(UnityEngine.Random.Range(1, 4));
            }

            // If player then update health bar
            if (healthBar != null)
                healthBar.UpdateHealth(currentHealth, maxHealth);

            safeTime = safeTimeDuration;
        }
    }



    private void Update()
    {
        if (safeTime > 0)
        {
            safeTime -= Time.deltaTime;
        }
    }
}
