using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public float PersonajeP;
    public float enemigo;

    public static Puntaje instancia = null;
   

    public static Puntaje Instancia
    {
        get
        {
            if (instancia == null)
            {
                instancia = new Puntaje();
            }
            return instancia;
        }
    }

    public Puntaje()
    {
        PersonajeP = 0;
        Enemigo = 0;
    }

    public class Personaje
    {
        public Puntaje puntaje;

        public Personaje()
        {
            puntaje = Puntaje.Instancia;
        }

        public void ataqueDado()
        {
            puntaje.PersonajeP++;
            if(instancia != null)
                instancia(PersonajeP);
        }
    }

    public class Enemigo
    {
        public Puntaje puntaje;

        public Enemigo()
        {
            puntaje = Puntaje.Instancia;
        }

        public void ataqueRecivido()
        {
            puntaje.enemigo--;
            if(instancia != null)
                instancia(Enemigo);
        }
    }
    
}
