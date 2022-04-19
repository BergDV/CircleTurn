using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseScene : MonoBehaviour
{
    public int score;
    public Text scoreText;
    private void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        scoreText.text = score.ToString();

    }
    
    public void LoseGame()
    {
        SceneManager.LoadScene(1);
     }
}

