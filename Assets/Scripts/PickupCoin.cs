using UnityEngine;
using System.Collections;

public class PickupCoin : MonoBehaviour {

	public Texture2D coinIconTexture;
	public int coinCount = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			coinCount++;
			Destroy(gameObject);
		}
	}

	void DisplayCoinsCount()
	{
		Rect coinIconRect = new Rect(10, 10, 32, 32);
		GUI.DrawTexture(coinIconRect, coinIconTexture);

		GUIStyle style = new GUIStyle();
		style.fontSize = 30;
		style.fontStyle = FontStyle.Bold;
		style.normal.textColor = Color.yellow;

		Rect labelRect = new Rect(coinIconRect.xMax, coinIconRect.y, 60, 32);
		GUI.Label(labelRect, coinCount.ToString(), style);
	}

	void OnGUI()
	{
		DisplayCoinsCount();
	}
}
