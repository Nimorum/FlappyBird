using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject ui;


    [SerializeField]
    private Vector2 spawnTubePos;
    private float minTubeY=-0.1f;
    private float maxTubeY=0.8f;

    private float spawnTimmer = 1.8f;
    private float timmerTemp;

    [SerializeField]
    private GameObject tubePrefab;

    private void Awake()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timmerTemp <= 0)
        {
            SpawnTubes();
            timmerTemp = spawnTimmer;
        }
        timmerTemp -= Time.deltaTime;
    }


    private void SpawnTubes()
    {
        spawnTubePos.y = Random.Range(minTubeY, maxTubeY);
        GameObject go = GameObject.Instantiate(tubePrefab, spawnTubePos, Quaternion.identity);
        GameObject.Destroy(go, 10);
    }

    public void StartGame()
    {
        ui.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Tubes[] tubes = GameObject.FindObjectsOfType<Tubes>();
        for (int i = 0; i < tubes.Length; i++)
        {
            GameObject.Destroy(tubes[i].gameObject);
        }

        ui.SetActive(true);

        Time.timeScale = 0;

    }

}
