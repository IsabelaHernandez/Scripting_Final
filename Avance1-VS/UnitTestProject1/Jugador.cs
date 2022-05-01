using System;

public class Jugador
{
	public int puntos = 0;
	public Jugador()
	{
		int vidas = 5;
		Random rd = new Random();
        puntos = rd.Next(1, 11);

	}

	public Jugador( int valor)
	{
		int vidas = 5;
		Random rd = new Random();

		puntos = rd.Next(1,11);
		valor = puntos;

	}
} 
