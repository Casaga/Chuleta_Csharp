using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    // en training utiizare algunas partes de los codigos para poder hacer referencia a ellos y poder aprender 

    //utilizando la clase vacia person 
    public Person padre;
    public Person madre;
    public Person hijo;

    private void Awake()
    {
        //utilizando la clase vacia person
        padre = new Person(); //creando a la nueva persona 
        padre.nombre = "Abe";
        padre.apellido1 = "Castillo";
        padre.apellido2 = "Galant";
        padre.age = 25;
        padre.esHombre = true;
        padre.esCasado = true;

        madre = new Person("Carla", "Santos", "Rivera",23); //creando a la nueva persona con un constructor difefrente 
        madre.esHombre = false;
        madre.esCasado = true;

        hijo = new Person("Arturo", padre.nombre, madre.nombre,3,true,false); //creando a la nueva persona con un cosntructor completo  

        padre.esposo = madre;
        madre.esposo = padre; //puede que als clases interactuen entre ellas mismas 

        padre.EstaCasadoCon(madre); //se puede usar los metodos de las clases siempre que estas sean publicas 


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
