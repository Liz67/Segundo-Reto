using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30; //SE CAMBIA YA QUE VA HACIA EL LADO DERECHO, ANTES DE CORREGIR EL PROBLEMA  (30) SPAWNEANDO A UN PERRO SE PODIA OBSERVAR QUE ESTE IBA DE EL CERO A MENOS INFINITO. POR ESO LO CAMBIAMOS A NEGATIVO
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit) //EL LIMITE TIENE QUE SER MAYOR QUE LA POSICION PARA QUE PUEDA DESTRUIRSE EN EL LIMITE - SI NO CAMBIAMOS EL MAYOR QUE EL PERRO NO AVANZARA NADA, SOLO APARECE Y DESAPARECE
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit) //TENEMOS QUE CAMBIAR LA Z POR LA Y DESAPARECE EN EL -5
        {
            Destroy(gameObject);
        }

    }
}
