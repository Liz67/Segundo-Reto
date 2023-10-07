using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //pizza
    private float topBound = 30;
    //animales
    private float lowerBound = -10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si un objeto pasa el jugador se remueve el objeto
        if (transform.position.z > topBound)
        {
            //Destruye cada vez que la comida pasa por encima
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) // Returns an iterator pointing to the first element in the range
        {
            //indicar algo en unity
            Debug.Log("¡Fin del juego!");
            //Destruye cada vez que los animales pasan el jugador
            Destroy(gameObject);
        }
    }
}
