using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	//maingais kas ieglaba textu no inputfield
	private string text;
	private string[] options = { "Sveiks!", "Jauku dienu!", "Tinies!", "LOL", ":tf:" };
	int x;

	public GameObject inputfield;
	public GameObject outputfield;

	public void Uzglabat() 
	{
		x = Random.Range(0, options.Length);
		text = inputfield.GetComponent<Text>().text;
		outputfield.GetComponent<Text>().text = options[x]+" "+text.ToUpper()+"!";
	}
	/*int kadrs = 0;
	// Use this for initialization
	void Start () {
		Debug.Log("Startēta programma!");
	}
	
	// Update is called once per frame
	void Update () {
		kadrs++;
		Debug.Log("Kadrs: "+kadrs);
	}*/
}
