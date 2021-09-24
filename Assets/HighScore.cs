using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //need this line for uGUI to work

public class HighScore : MonoBehaviour{
	static public int score = 1000;

	void Awake(){
		if(PlayerPrefs.HasKey("HighScore")){
			score = PlayerPrefs.GetInt("HighScore");
		}
		PlayerPrefs.SetInt("HighScore", score);
	}
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: "+score;

        //update the playerprefs highscore if necessary
        if(score>PlayerPrefs.GetInt("HighScore")){
        	PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
