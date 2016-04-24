using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public GameObject platform;

	private Vector2 previousLogPosition;
    private Vector2 newPosition;
    private Vector2 heroPosition;
    private Vector2 diffPosition;

    void Start ()
    {
		for (int i = 0; i < 50; i++) {
			if (i == 0) {
				previousLogPosition = GameObject.Find ("env_logPlatform1").transform.position;
			} 

			int leftRight = Random.Range(0, 10);

			if (leftRight <= 5) {
				diffPosition = new Vector2 (Random.Range (-10f, -5f), 5f);
				if (diffPosition.x <= -25f) {
					diffPosition = new Vector2 (Random.Range (5f, 10f), 5f);
				}
			} else {
				diffPosition = new Vector2 (Random.Range (5f, 10f), 5f);
				if (diffPosition.x >= 25f) {
					diffPosition = new Vector2 (Random.Range (-10f, -5f), 5f);
				}
			}
			newPosition = previousLogPosition + diffPosition;
			Instantiate (platform, newPosition, Quaternion.identity);
			previousLogPosition = newPosition;
		}

    }

}
