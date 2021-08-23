using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody : MonoBehaviour
{
    private Rigidbody2D rb; //declarando una variable rigidbody 
    public Animator animator; //declarando un animador, este se cambiara desde el editor 

    //al ponerla publica nos despliega un menu de layers(de los objects) ya creadas y escogemos cual nos venga bien 
    public LayerMask groundLayerMask; //una mascara de capa 
    public float runnungSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();//dandole el objeto de mi rigidbody 
    }
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Vector2.up * 3,ForceMode2D.Impulse); //agregando una fuerza a mi rigidbody para que salte dandole una fuerza de impulso 

        animator.SetBool("isAlive", true); //esto es parte del animator y las variables que se le pueden dar en parameters en la ventana animator 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//apretando el boton del mouse 
        {

        }
    }
    private void FixedUpdate() //fuerzas cosntantes o furezas que siempre tengan que existir 
    {
        if (rb.velocity.x < runnungSpeed)
        {
            rb.velocity = new Vector2(runnungSpeed, rb.velocity.y); //introduciendo velocidad constante a un rigidbody 
        }
    }

    bool Raycast()
    {
        //fisica 2D tirame un rayo desde el centro de mi objeto hacia el suelo de largo .2 y comprueba si choca con grondLayer Mask 
        if (Physics2D.Raycast(this.transform.position, Vector2.down, 0.2f, groundLayerMask.value))
        {
            return true;   
        }
        return false;
    }

    private void OnTriggerEnter2D(Collider2D theobject)
    {
        if (theobject.tag == "Player")
        {
            theobject.GetComponent<PlayerController>().KillPlayer(); //llamando a un script en especifico 
        }
    }
}
