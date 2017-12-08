using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour 
{

    public Text HighScoreText;

    void Update()
    {

        string text = "HIGH SCORE\\n<b><size=250>" + PlayerPrefs.GetInt("HighScore").ToString() + "</size></b>";
        HighScoreText.text = text.Replace("\\n", "\n");

    }

}
