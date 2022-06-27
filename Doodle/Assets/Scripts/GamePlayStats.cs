using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GamePlayStats : MonoBehaviour
{
    public Text ScoreText;
    public PlayerMovement playerMovement;
    public Text coinstext;
    public Text HighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        HighScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = playerMovement.Score.ToString();
        coinstext.text = playerMovement.CoinsCount.ToString();
    }
}
