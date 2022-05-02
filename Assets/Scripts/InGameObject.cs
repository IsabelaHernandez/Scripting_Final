using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InGameObject
{
    [SerializeField] private int currentHealth = 5;
    public TMPro.TextMeshPro HealthText;

    public int GetHealth() { return currentHealth; }
    public void SetHealth(int healthValue) { currentHealth = healthValue; }

    private void Grow(int growValue) { currentHealth += growValue; }
    public int DealDamage(int enemyHealth) { Grow(enemyHealth); return currentHealth; }    
    public void RecieveDamage(int damageValue)
    {
        currentHealth -= damageValue;
        currentHealth = Mathf.Clamp(currentHealth, 0, 100000);
    }
}
