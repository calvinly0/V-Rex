using UnityEngine;
using System.Collections;

public class PickupCoin : MonoBehaviour {

	public Texture2D coinIconTexture;
	public Texture2D steakIconTexture;
	private int coinCount;

	// Use this for initialization
	void Start ()
	{
		coinCount = 50;
	}

	// Update is called once per frame
	void Update ()
	{

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (gameObject.name == "steak") {
			coinCount--;
			if (coinCount < 0) {
				coinCount = 0; //this should be changed so that he dies...
			}
		} else {
			// Increment score by 1 for every coin collected
			coinCount++;
		}
		if (other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}

	void DisplayCoinsCount()
	{
    // Draw GUI box for icon to live in
		Rect coinIconRect = new Rect(10, 10, 32, 32);
		GUI.DrawTexture(coinIconRect, coinIconTexture);

		GUIStyle style = new GUIStyle();
		style.fontSize = 30;
		style.fontStyle = FontStyle.Bold;
		style.normal.textColor = Color.yellow;

    // Display score next to icon
		Rect labelRect = new Rect(coinIconRect.xMax, coinIconRect.y, 60, 32);
		GUI.Label(labelRect, coinCount.ToString(), style);
	}

	void OnGUI()
	{
		DisplayCoinsCount();
	}

}
