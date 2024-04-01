using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool isReadyToSpawn=true;
    [SerializeField] private float Delay;
    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog
        if(Input.GetKeyDown(KeyCode.Space)&&isReadyToSpawn)
            SpawnDogs();
    }
    void SpawnDogs()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        isReadyToSpawn=false;
        StartCoroutine(TimeSpawning());
    }
    IEnumerator TimeSpawning()
    {
        yield return new WaitForSeconds(Delay);
        isReadyToSpawn=true;
    }
}
