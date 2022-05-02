using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    [SerializeField] int health = 3;
    public InGameObject enemyStats;
    

    private void Start()
    {
        enemyStats = new InGameObject();
        enemyStats.SetHealth(health);
        enemyStats.HealthText = GetComponentInChildren<TMPro.TextMeshPro>();
    }

    private void Update()
    {
        health = enemyStats.GetHealth();
        enemyStats.HealthText.text = health.ToString();
        if (health <= 0) { Destroy(gameObject); }
    }
}
