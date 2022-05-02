using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    public List<Piso> torre = new List<Piso>();
    int torreSize;
    Random randi = new Random();
    
    public Torre()
    {
        torreSize = randi.Next(1, 7);

        CrearTorre(torreSize);
    }

    public void CrearTorre(int size)
    {
        for (int i = 0; i < size; i++)
        {
            torre.Add(new Piso());
        }
    }
}
