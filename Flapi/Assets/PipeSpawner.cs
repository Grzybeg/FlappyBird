using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeSpawner : MonoBehaviour
{
    public float SpawnRateMax;
    public float SpawnRateMin;
    public GameObject PipeObject;

    private void Start()
    {
        SpawnPipes();
    }

    public void SpawnPipes()
    {
        float randomY = ((float)Random.Range(-200, 200))/100;
        Vector3 spawnPosition = new Vector3(14, randomY);
        Instantiate(PipeObject, spawnPosition, Quaternion.identity);
        Invoke("SpawnPipes", Random.Range(SpawnRateMin,SpawnRateMax));
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }
}
