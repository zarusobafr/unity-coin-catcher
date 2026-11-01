using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 0.8f;
    public float minX = -8f;
    public float maxX = 8f;
    public float spawnY = 6f;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            float x = Random.Range(minX, maxX);
            Instantiate(coinPrefab, new Vector3(x, spawnY, 0), Quaternion.identity);
        }
    }
}