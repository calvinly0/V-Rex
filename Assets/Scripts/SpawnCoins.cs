using UnityEngine;
using System.Collections;
using System.Threading;

public class SpawnCoins : MonoBehaviour
{
    public float fallSpeed = 8.0f;
    // Optional if the object should spin while it falls
    public float spinSpeed = 100.0f;
    public Transform[] coinSpawns;
    public int coinNumber = 10000;
    public GameObject coin;
	private Vector2 heroPosition;

	//Steaks
	public GameObject steak;

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
		int choice = Random.Range (0, 25);
		heroPosition = GameObject.Find ("char_dino").transform.position;
		heroPosition.y += 14f;
		heroPosition.x += Random.Range (-12f, 12f);

		if (choice <= 20) {
				Instantiate (coin, new Vector2 (heroPosition.x, heroPosition.y), Quaternion.identity);
		} else {
				Instantiate (steak, new Vector2 (heroPosition.x, heroPosition.y), Quaternion.identity);
		}
    }

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);

        // Destroys coin if it falls past a certain threshold to avoid excess memory consumption
		Destroy(this.coin, 5);

    }

}
