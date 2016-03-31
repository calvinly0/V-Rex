using UnityEngine;
using System.Collections;

public class SpawnCoins : MonoBehavior
{
    public float fallSpeed = 8.0f;
    // Optional if the object should spin while it falls
    public float spinSpeed = 100.0f;
    public Transform[] coinSpawns;
    public GameObject coin;

    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        for (int i = 0; i < coinSpawns.Length; i++)
        {
            int coinFlip = Random.Range(0, 2);
            if (coinFlip > 0)
            {
                // Spawn new coin at top of screen
                Instantiate(coin, new Vector3(Random.Range(-6, 6), 10, 0), Quaternion.identity);

            }
        }
    }

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);

        // Need additional script to destroy coin  if it falls past the lower boundary on the y-axis
    }

}
