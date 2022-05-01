using System;
using System.Collections.Generic;

public class Torre
{
	Jugador jugador = new Jugador();

	public List<int> TorreJugador; 
	//public int[] TorreJugador = { 1, 2, 3, 5 };
	public Torre()
	{
		Random rd = new Random();
        int pisos = rd.Next(1,11);

		TorreJugador = new List<int>(){pisos};
		int posicion = rd.Next(1,pisos);

		//TorreJugador[posicion] = jugador; 
	}

	//Sobrecarga
	public Torre(int niveles)
	{		
		int pisos;
		pisos = niveles;

		Random rd = new Random();
		TorreJugador = new List<int>(){pisos};

		//int posicion = rd.Next(1,pisos);

		//TorreJugador[posicion] = jugador; 
	}
}
