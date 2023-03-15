using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner3 : MonoBehaviour
{

	public Transform spawnPoint;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

	private int waveNumber = 1;

	public Transform enemy;

	void Update()
	{

		if (countdown <= 0f)
		{
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;

	}

	IEnumerator SpawnWave()
	{
		waveNumber++;

		for (int i = 0; i < waveNumber; i++)
		{
			SpawnEnemy();
			yield return new WaitForSeconds(0.5f);
		}

	}

	void SpawnEnemy()
	{
		Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
	}

}
