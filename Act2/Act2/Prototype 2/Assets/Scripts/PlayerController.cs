using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //crear variable
    public float horizontalInput;
    public float speed = 10.0f;
    //si se cambia el 10 cambia el rango de movimiento izquierda y derecha
    public float xRange = 10;

    //Nueva variable para que el jugador tenga de referencia la comida que se utiliza
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mantiene al jugador dentro de los rangos y z
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //ciclo para que el jugador obtenga pizzas

        //SPACE - cada que se presione la barra espaciadora se ejecutara la accion
        if (Input.GetKeyDown(KeyCode.Space)) //KEYCODE - MAPEA TODAS LAS LETRAS DEL TECLADO
        {
            //Lanzar comida desde el jugador
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            //TRANSOFRM.POSITION - Posicion de el jugador
            //PROJECTILE.ROTATION - Aqui se almacena la rotation de el objeto
        }

    }
}
