using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColleccionesYOperadores : MonoBehaviour
{
    //Arrays  
    //los Arrarys viven en Sistem.Collections
    //los Arrays son mas rapidos en su procesamiento
    //los arrays no cambian de tamaño despues de ser creados en la asignacion 
    public int[] jugadores = new int[8]; //asi se declara un array con el tamaño de entrada 
    public string[] enemigos = new string[] { "Malo", "Ciclope", "Murcielago", "Coche", "Jefe" }; //asi se declara un array con los valores que van dentro  


    //Listas 
    //las listas pueden ser flexibles pero al ser grandes es un poco mas lento en su procesamiento 
    //las listas viven en Sistem.Collections.Generic
    //las listas pueden cambiar su tamaño en cualquier momento, introduciendo cualquier otro si es de su forma de dato 
    public List<string> enemigos2 = new List<string>(); //declaracion de una lista 


    //ArrayList
    //Se le puede meter cualquier tipo de dato, se tiene que tener cudiado porque puede que no se recuerde que se guardo 
    public ArrayList userInfo = new ArrayList(); //declarando un ArrayList


    //Diccionarios o hashtables
    //Aunque sean publicos estos no se mostraran en el editor 
    public Hashtable personalInfo = new Hashtable();  //declarando un Diccionario o HashTable 


    private void Awake()
    {
        //===========================================================================================================
        //Arrays
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemigo"); //FindGameObjecctsWithTag ** bsucamso todos los GameObjects que tienen en tag "Enemigo"
        //buscando a los gameobjects que tienen la etiqueta "Enemigo"

        string firstEnemy = enemigos[0]; //Sacando los elementos de los arrays  

        int arrayLength = enemigos.Length; //saber el tamaño del array
        //===========================================================================================================

        //===========================================================================================================
        //Listas
        enemigos2.Add("Malo");
        enemigos2.Add("Ciclope");
        enemigos2.Add("Murcierla"); //añadiendo componentes a la lista

        enemigos2.Remove("Murcielago"); //quitando un elemento de la lista 

        enemigos2.Clear();//quitando todos los elementos de las listas

        enemigos2.Contains("Ciclope"); //Saber si "Ciclope" se encuentra dentro de la lista 

        enemigos2.Insert(2, "carro"); //insertando un elemento en la lista 

        enemigos2.ToArray(); //convierte la lista a un Array 

        string firstEnemy2 = enemigos2[0]; //Sacando los elementos de las listas  

        int listLength = enemigos2.Count; //saber el tamaño de la lista 
        //===========================================================================================================

        //===========================================================================================================
        //ArrayList
        userInfo.Add(10); //metiendo elementos a la Arraylist 
        userInfo.Add(3.5);
        userInfo.Add("Hola como estas");
        userInfo.Add(true);
        //===========================================================================================================

        //===========================================================================================================
        //Diccionarios 
        personalInfo.Add("userName", "Abe");//metiendo nuevas claves y valores a los diccionarios 
        personalInfo.Add("timePlayed", 3.5);

        string name = (string)personalInfo["userName"]; //casteando un valor, sacando un valor de una lista 
        personalInfo.Contains("timePlayed");//saber si la lista contiene la clave timePlayed 
        //===========================================================================================================
    }
    void Operador_If()
    {
        //comando negativo "!" negacion
        //comando and "&&" compuerta and
        //comando or "||" compuerta or 

        if (!true) 
        {
            //declaracion basica del comando if 
        }
        else //declaracion basica para el comando else 
        {

        }
    }
    void Bucle_Foreach()
    {

        //no le decimos cuanto de largo es
        //no es el bucle correcto para los Arraylist porque no sabes que regresara 
        //tipo de dato,in lista o array
        foreach (string enemigo in enemigos) //declaracion basica de un bucle
                                             
        {

        }

        foreach (string key in personalInfo) //declaracion de un foreach utilizando una estructura de diccionario
        {
            Debug.Log( personalInfo[key]);
        }
    }

    void Bucle_For()
    {
        //inicializacion; condicion de continuacion ;aumento 
        for (int i = 0; i < 15; i++) //declaracion basica de un ciclo for 
        {
            Debug.Log(enemigos[i]);
            break; //el break romple el bucle for para que ya no siga buscando 
        }
    }

    void Bucle_While()
    {
        //el while pued impirmir o tener tu variable de  iteracion despues del bucle 
        int i = 0;
        while (i<15) //declaracion basica de un cilco while 
        {
            i++;
        }
    }
}
