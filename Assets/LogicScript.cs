using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public int PlayerScore = 0;
    public Text ScoreText;

    public void IncrementScore(int scoretoAdd )
    {
        PlayerScore=PlayerScore+scoretoAdd;
        ScoreText.text = PlayerScore.ToString();
    }
}
