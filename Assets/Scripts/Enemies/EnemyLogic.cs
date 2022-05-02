using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    [SerializeField] int health = 3; //Vida inicial
    public InGameObject enemyStats; //crea el objeto tipo InGameObject

    private void Start()
    {
        enemyStats = new InGameObject(); enemyStats.SetHealth(health); //definir cantidad de vida
        enemyStats.HealthText = GetComponentInChildren<TMPro.TextMeshPro>(); //Texto correspondiente a la vida del enemigo
    }

    private void Update()
    {
        health = enemyStats.GetHealth(); //mantener la vida siempre actualizada
        enemyStats.HealthText.text = health.ToString(); //el int de la vida del enemigo se convierte a texto con el ToString
        if (health <= 0) { Destroy(gameObject); } //cuando la vida del enemigo sea 0, se va a detruir el objeto enemigo
    }
}
