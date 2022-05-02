using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] int initialHealth = 5;
    [SerializeField] int currentHealth;
    public InGameObject playerStats;

    private void Start()
    {
        playerStats = new InGameObject(); playerStats.SetHealth(initialHealth);
        playerStats.HealthText = GetComponentInChildren<TMPro.TextMeshPro>();
    }

    private void Update()
    {
        currentHealth = playerStats.GetHealth();
        playerStats.HealthText.text = currentHealth.ToString();
        if (currentHealth <= 0)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyLogic enemyLogic = collision.GetComponentInParent<EnemyLogic>();
            int enemyHealth = enemyLogic.enemyStats.GetHealth();

            if (enemyHealth < currentHealth)
            {
                enemyLogic.enemyStats.RecieveDamage(playerStats.DealDamage(enemyHealth));
            }
            else
            {
                playerStats.RecieveDamage(enemyLogic.enemyStats.DealDamage(currentHealth));
            }

        }
    }

}
