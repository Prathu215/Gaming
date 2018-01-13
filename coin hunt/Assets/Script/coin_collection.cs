using UnityEngine;
using System.Collections;

public class coin_collection : MonoBehaviour {

	int score ;
	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		Time.timeScale = 1;
	}
	
	
	void OnTriggerEnter (Collider other) {
		if (other.tag == "coin") {
			score += 1;
			Destroy(other.gameObject);
		}
		
	}
	
	void OnGUI() {
		GUIStyle myStyle = new GUIStyle();
		myStyle.fontSize = 30;
		myStyle.normal.textColor = Color.red;
		myStyle.hover.textColor = Color.red;
		GUI.Label (new Rect (50,10, 50, 50), "Score " + score, myStyle);
		if (score == 50 ) {
		Application.LoadLevel(2);
		}
	}
}
