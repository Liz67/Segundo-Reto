using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int ballNumber = Random.Range(0, ballPrefabs.Length); //SE HACE ESTA LINEA PARA RANDOMIZAR LA POSICION DE LA PELOTA, SE UTILIZA BALLPREFABS PARA CONTINUAR CON EL ARREGLO QUE SE ESTA UTILIZANDO
        Instantiate(ballPrefabs[ballNumber], spawnPos, ballPrefabs[ballNumber].transform.rotation); //ballPrefabs[0] - HACE QUE SOLO APAREZCA LA PELOTA AZUL POR LO QUE TENEMOS QUE CAMBIARLO POR EL VALOR CREADO "BALLNUMBER"
    }

}
