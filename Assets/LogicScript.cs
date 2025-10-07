using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public int PlayerScore = 0;
    public Text ScoreText;

    public void IncrementScore()
    {
        PlayerScore++;
        ScoreText.text = "Score: " + PlayerScore.ToString();
    }
}
