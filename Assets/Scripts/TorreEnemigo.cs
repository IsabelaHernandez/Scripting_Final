using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreEnemigo : Torre
{
    Random randi = new Random();

    public Torreenemigo()
    {
        CrearTorre(TorreSize);
    }
}
