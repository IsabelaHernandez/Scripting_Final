using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    void Start()
    {        
        gameObject.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0); //carga la escena n�mero 0 si se le da al bot�n de restart
    }
}
