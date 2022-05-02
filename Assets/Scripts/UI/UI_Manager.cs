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

    // Update is called once per frame
    void Update()
    {
        if (playerLogic.playerStats.GetHealth() <= 0)
        {
            GameOverScreen.SetActive(true);
        }
    }
}
