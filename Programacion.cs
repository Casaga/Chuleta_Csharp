using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Programacion : MonoBehaviour
{
    //para que los scripts puedan ser "escuchados" o puedan ser usados tiene que ir dentro de un gameObject(un objeto en la escena)
    //los componentes son las cosas que se les ponen a los objetos del juego, siendo scripts, colliders, triggers, riggibodys, etc
    //cuando el juego esta en ejecucion no se guardan, preferencias, colores, playmode cambiar color 

    //las variables privadas no pueden ser llamadas por otros programas dentro del juego o modificadas desde el editor 
    //las variables publicas pueden ser llamadas y cambiadas por otros programas dentro del juego  o modificadas desde el editor 
    //por default las variables seran privadas 
    //las variables deben ir en minuscula la primera letra y lo demas las principales en mayusculas 

    private string playerName = "Abe"; //declaracion de una variable string 
    public int playerScore = 50; //declarando variable int, este numero sera el numero por defecto 
    public bool isTrue = false; //declarando una variable bool 
    public float floatNumber = 5.4f; //declarando una variabla flotante 
    public double pi = 3.141567558; //los doubles no necesitan la f  y son mas precisos

    private int numeroDeManzanas = 5;

    private void Awake() //el usuario aun no ve nada y se puede configurar en este momento, hacer que los coches no caigan  del cielo 
    {
        Debug.Log(numeroDeManzanas / 2); //nos dara un numero entero "2"
        Debug.Log(numeroDeManzanas % 2); //sacandole el residuo

        int hola = 0; //esta que esta declarada en el awake entonces no existira en los demas modulos y solo sera llamada duespues de ser declarada   
    }

    void Start() //el start va antes del update y solo se ejecuta al principio
    {
        Debug.Log("Hola como estas"); //imprimiendo algo y que se vea en la consola 
        Debug.Log(playerName + playerScore); //imprimiendo un string con un numero 
    }

    
    void Update() //el update se refresca 60 veces cada segundo, no es buena idea que se sobrecargue 
    {
        if (Input.GetKeyUp(KeyCode.B)) 
        {
            Birthday(); //llamando al metodo Birthday 
        }
    }

    void Birthday() //asi se pone una funcion que no devuelve nada, debe empezar con mayusculas 
    {
        Debug.Log(playerName + 1);
    }

    //los metodos pueden ser declarados varias veces dependiendo de que peuda hacer o que necesite hacer para repetir lo que menos podamos el codigo
    int Arrancones(int numeroDeArrancones) //introduciendo un numero o algo dentro de los metodos, al poner int al inicio sabremos que regresara un numero entero
    {
        return numeroDeArrancones;
    }

    void Arrancones(string grito) //es posible sobrecargar un metodo y esto nos dira que se puede llamar de diferentes maneras y puede regresar cosas diferentes 
    {
        Debug.Log(grito);
    }
   
    //Documentacion correcta de un metodo, ya que la ser llamado nos dara una pequeña descripcion de lo que estamos solicitando 
    /// <summary>
    /// Aqui se pone lo que hace el metodo para que pueda ser impreso cuando es llamado 
    /// </summary>
    /// <param name="gritos"> aqui ponemos lo que se necesita meter</param>
    /// <returns>aqui pondremos lo que nos devolvera el metodo</returns>
    string GritoDeGuerra(int gritos)
    {
        return gritos.ToString();
    }
}
