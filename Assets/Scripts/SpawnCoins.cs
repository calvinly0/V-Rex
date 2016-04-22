using UnityEngine;
using System.Collections;
using System.Threading;

public class SpawnCoins : MonoBehaviour
{
    public float fallSpeed = 8.0f;
    // Optional if the object should spin while it falls
    public float spinSpeed = 100.0f;
    public Transform[] coinSpawns;
    public int coinNumber = 100;
    public GameObject coin;

    void Start()
    {
        // Set interval for falling
        float startIn = 0;
        float every = 1;
        // Repeat behavior
        InvokeRepeating("Spawn", startIn, every);
    }

    void Spawn()
    {
      Instantiate(coin, new Vector3(Random.Range(-12f, 12f), 14f, 0f), Quaternion.identity);
    }

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);

        // Destroys coin if it falls past a certain threshold to avoid excess memory consumption
		DestroyImmediate(this.coin, true);

    }

}
