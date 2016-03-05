using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameController : MonoBehaviour {

    // Use this for initialization
    public Text scoreText;
    private int score;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void addScore()
    {
        score++;
        UpdateScore();
    }
    void UpdateScore()
    {
        scoreText.text = "得分： " + score;
    }

    void OnGUI()
    {
        int sw = Screen.width;
        int sh = Screen.height;
        GUI.TextArea(new Rect(10, 10, 80, 30), scoreText.text);
    }
}
