using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneball : MonoBehaviour {
	public Text txtScore;
	public Text txtattack;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	int Score = 0;
	int attack = 0;
	public void DoPushButton(){
		Score++;
		attack++;
		txtattack.text = "Score : " + attack.ToString ();
		txtScore.text = "Score : " + Score.ToString ();
	}
	public void DoChangScene(){
		SceneManager.LoadScene (1);
	}
}
