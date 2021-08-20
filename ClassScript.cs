using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassScript : MonoBehaviour //indica herencia de MonoBehaviour 
{
    //in script es una claseeeeee uwu
    //simulando hacer una clase para un carro 

    public string marca = "pegot";
    public string modelo = "207 cc";
    public Color color = Color.red;
    public int cv = 150;

    //al darle este scrpit a un objeto se le da a estos atributos y al ser posible llamarlo desde otros scripts se hace programacion orientada a objetos  

    private void Start()
    {
       
    }
    void Arrancar()
    {
        Debug.Log(transform.position.x); //sabiendo las componenetes de nuestros objetos 
    }

    void Stop()
    {
        
    }
}
