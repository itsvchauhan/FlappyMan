using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public int points = 1;
    public Text scoreText;

    public GameObject Gameover;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        score += points;
        scoreText.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        Gameover.SetActive(true);
    }

}
