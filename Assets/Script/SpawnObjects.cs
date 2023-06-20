using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public float minX = -5f;
    public float maxX = 5f;
    public GameObject[] objectToSpawn;
    public Transform spawnPoint;

    public float tiempoToSpawn;
    private float time;


    private float tiempoPasado;

    private bool isEnabled;
    // Start is called before the first frame update
    void Start()
    {
        time = tiempoToSpawn;
        isEnabled = false;

        StartCoroutine(ActivarSpawn());
    }

    IEnumerator ActivarSpawn()
    {
        yield return new WaitForSeconds(3f);
        isEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isEnabled == true)
        {
            time -= Time.deltaTime;

            tiempoPasado += Time.deltaTime;

            if (tiempoToSpawn >= 0.8)
            {
                if (tiempoPasado > 60f)
                {
                    tiempoToSpawn -= 0.2f;
                    tiempoPasado = 0;


                }
            }


            if (time <= 0)
            {
                // Genera una posición aleatoria en el rango establecido
                FindObjectOfType<SoundManager>().Play("apear");

                float randomX = Random.Range(minX, maxX);

                // Crea una instancia del objeto en la posición de spawn aleatoria
                Vector3 spawnPosition = new Vector3(randomX, spawnPoint.position.y, spawnPoint.position.z);
                Instantiate(objectToSpawn[Random.Range(0, objectToSpawn.Length)], spawnPosition, Quaternion.identity);

                time = tiempoToSpawn;
            }
        }
        
    }
}
