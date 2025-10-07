using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public int PlayerScore = 0;
    public Text ScoreText;
    public GameObject GameOverPanel;

    public void IncrementScore(int scoretoAdd)
    {
        PlayerScore = PlayerScore + scoretoAdd;
        ScoreText.text = PlayerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void Gameover()
    {
        GameOverPanel.SetActive(true);
    }
}
