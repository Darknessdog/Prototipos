using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    // Variable para guardar el movimiento del jugador 

    public int movJugador = 0; 
    
    // Movimienot de la computaroda 

    public int movPc = 0; 


    void Start()
    {
        Debug.Log("Soy start");
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Soy Update");
        
    }

    public void AsignarMovimiento (int movimiento)
    {
        movJugador = movimiento;

    }

    public void AsignarMovimientoAI()
    {
        movPc = Random.Range(1,3);
    }

    //1:piedra 2:papel 3:tijeras
    void Resultado()
    {
        if (movJugador == movPc)
        {
            Debug.Log("Empate");
            return;
        }

        if (movJugador == 1 && movPc == 2)
        {
            Debug.Log("Computadora gana");

        }

        if (movJugador == 1 && movPc == 3)
        {
            Debug.Log("Jugador gana");
            
        }

        if (movJugador == 2 && movPc == 1)
        {
            Debug.Log("Jugador gana");
        }

        if (movJugador == 2 && movPc == 3)
        {
            Debug.Log("Computadora gana");
        }

        if (movJugador == 3 && movPc == 1)
        {
            Debug.Log("Computadora gana");  
        }

        if (movJugador == 3 && movPc == 2)
        {
            Debug.Log("Jugador gana");
        }
    }


}
