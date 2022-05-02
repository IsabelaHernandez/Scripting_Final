using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] int initialHealth = 5; //vida inicial
    [SerializeField] int currentHealth; //vida durante todo el juego
    public InGameObject playerStats;

    private void Start()
    {
        playerStats = new InGameObject(); playerStats.SetHealth(initialHealth); //Inicializa objeto
        playerStats.HealthText = GetComponentInChildren<TMPro.TextMeshPro>(); //Inicializa vida
    }

    private void Update()
    {
        currentHealth = playerStats.GetHealth();
        playerStats.HealthText.text = currentHealth.ToString();
        if (currentHealth <= 0) { Destroy(gameObject); }
    }

    //Los enemigos tienen dos colliders, uno de ellos es el Action Area. Cuando el player esta dentro de esta area, interactua con el enemigo
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.CompareTag("Enemy")) //si el tag es enemy accede
        {
            EnemyLogic enemyLogic = collision.GetComponentInParent<EnemyLogic>();
            int enemyHealth = enemyLogic.enemyStats.GetHealth();

            if (enemyHealth < currentHealth) //compara: si la vida del enemigo es menor a la del player entonces se ejecuta recibir daño (que será la current health del player)
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
