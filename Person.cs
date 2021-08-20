using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person 
{
    //Clase separada de MonoBehaviour
    //como la clase no pertenece a MonoBehaviour no es necesario que este en un objeto de la escena para ser usada 

    //variables de nuestra clase 
    public string nombre = "";
    public string apellido1 = "";
    public string apellido2 = "";
    public int age = 0;
    public string direction = "";
    public bool esHombre = false;
    public bool esCasado = false;

    public Person esposo;

    public Person() //Este es el constructor de nuestra clase, este es el constructor por defecto 
    {

    }
    public Person(string pNombre, string pApellido1, string pApellido2, int pAge) //sobrecargando el constructor de
                                                                                     //la clase para que pueda ser llamado y contruido de una manera mas eficiente 
    {
        this.nombre = pNombre; //al poner this. hace referencia al objeto en si mismo, su nombre del padre, de la madre pero no en general 
        this.apellido1 = pApellido1;
        this.apellido2 = pApellido2;
        this.age = pAge;
    }

    public Person(string pNombre, string pApellido1, string pApellido2, int pAge, bool pEsHombre,bool pEsCasado) //sobrecargando el constructor de
                                                                                  //la clase para que pueda ser llamado y contruido de una manera mas eficiente 
    {
        this.nombre = pNombre; //al poner this. hace referencia al objeto en si mismo, su nombre del padre, de la madre pero no en general 
        this.apellido1 = pApellido1;
        this.apellido2 = pApellido2;
        this.age = pAge;
        this.esHombre = pEsHombre;
        this.esCasado = pEsCasado;
    }

    public bool EstaCasadoCon(Person person)
    {
        if (person == esposo)
        {
            return true;
        }
        return false;
    }
}
