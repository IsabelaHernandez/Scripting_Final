using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InGameObject
{
    //Esto está instanciado como una clase que comparten el enemigo y el jugador ya que tienen los mismos stats (vida, daño, grow)
    [SerializeField] private int currentHealth = 5;
    public TMPro.TextMeshPro HealthText; //texto de la vida

    public int GetHealth() { return currentHealth; }
    public void SetHealth(int healthValue) { currentHealth = healthValue; }

    private void Grow(int growValue) { currentHealth += growValue; } //grow pasa la vida para que aumente en el current health
    public int DealDamage(int enemyHealth) { Grow(enemyHealth); return currentHealth; } //cantidad de daño que hace según el current health
    public void RecieveDamage(int damageValue)
    {
        currentHealth -= damageValue; //se le resta la cantidad de daño hecho
        currentHealth = Mathf.Clamp(currentHealth, 0, 100000); //funcionan como limites para que la vida no de negativo, que lo mínimo sea cero
    }
}
