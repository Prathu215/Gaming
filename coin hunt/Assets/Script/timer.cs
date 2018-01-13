using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour 
{
	private string timedis;
	private float ttimer = 180.0f;
	private int min;
	private int hou;
	
	public bool startime = false;
	void Start() 
	{
	}
	void Update () 
	{   

		if(startime == true)
		{

			ttimer -= Time.deltaTime;
			timedis = (Mathf.Floor(ttimer).ToString());

		}
	}
	void OnGUI(){
		GUIStyle Label2 = new GUIStyle(GUI.skin.GetStyle("label"));
		Label2.fontSize = 27;
		Label2.normal.textColor = Color.red ;

		GUI.Label(new Rect(50,40,200,200), "Time Left : " + timedis, Label2);
		if(ttimer <= 1){
			Application.LoadLevel("gameover");
		}
	}
}