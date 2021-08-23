using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStates //los estados que puede tomar el juego al ponerlo fuera de la clase lo hacemos global para todos los scripts 
{
    menu,
    inTheGame,
    gameOver
}

public class GameManagerTraining : MonoBehaviour
{
    public static GameManagerTraining sharedInstance;

    private void Awake()
    {
        sharedInstance = this;

        PlayerPrefs.GetFloat("highscoret", 0); //tomar el valor de highscore
        PlayerPrefs.SetFloat("highscoret", 100); //darle un valor de 100 a las variables que se guardan 
    }

    private void Update()
    { //los botones son usados para no hacer el juego solo para un tipo de entrada, se pueden cambiar en el proyect settings/ input manager, name es el que se le pone "start"
        if (Input.GetButtonDown("start"))
        {
            StartGame();
        }
    }

    //el game manager no tiene nada que ver con la jugabilidad del juego a el solo le importa el flujo de este 
    public void StartGame()
    {

    }

    public void GameOver()
    {

    }

    public void BackToMainMenu()
    {

    }
}
