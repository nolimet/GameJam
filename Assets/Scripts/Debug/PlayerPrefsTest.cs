using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TextMesh))]
public class PlayerPrefsTest : MonoBehaviour {

    public int score = 0;
    public int highScore = 0;
    public TextMesh txt;
	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(0.4f, 0.4f, 1f);
        highScore = PlayerPrefs.GetInt("highScore", 0);
        PlayerPrefs.SetInt("highScore", highScore);
      txt = GetComponent<TextMesh>();
      PlayerPrefs.Save();
	}

    void Update()
    {
        if (Application.loadedLevel == 0)
        {
            if(highScore<10000)
            txt.text ="Highscore:" + highScore;
            else
                txt.text = "Highscore:\n" + highScore;
        }
        else
        {
            txt.text = "Score : " + score + "\nHighscore: " + highScore;
            if (score > highScore)
            {
                highScore = score;
            }
        }
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("highScore", highScore);
        // Make sure prefs are saved before quitting.
        PlayerPrefs.Save();
    }
}
