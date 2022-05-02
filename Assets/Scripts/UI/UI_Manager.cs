using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    PlayerLogic playerLogic;

    [SerializeField] GameObject GameOverScreen;
    void Start()
    {
        playerLogic = FindObjectOfType<PlayerLogic>();
    }
        
    void Update()
    {
        if (playerLogic.playerStats.GetHealth() <= 0) //cuando la vida llega a cero se activa la pantalla de Game Over
        {
            GameOverScreen.SetActive(true);
        }
    }
}
