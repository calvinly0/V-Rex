using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public GameObject platform;

    private Vector2 currentPosition;
    private Vector2 heroPosition;
    private Vector2 diffPosition;


    void Start ()
    {
        float startIn = 0;
        float every = 3;
        InvokeRepeating("Spawn", startIn, every);
	}

	void Spawn()
	{
        heroPosition = GameObject.Find("char_dino").transform.position;
        diffPosition = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        currentPosition = heroPosition + diffPosition;
        Instantiate(platform, currentPosition, Quaternion.identity);
    }

}
