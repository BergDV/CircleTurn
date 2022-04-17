using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BallScripts : MonoBehaviour
{
    public int score;
    public bool isMulti;
    [SerializeField] Text scoreText;

    public GameObject bonusEffect; 
    public void Start()
    {
        isMulti = PlayerPrefs.GetInt("isMulti") == 1 ? true : false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);
            Instantiate(bonusEffect, transform.position, Quaternion.identity);
            if (isMulti == true)
            {
                score += 2;
            }
            else
                score += 1;
        }
        if (other.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene(2);
        }
    }
    void Update()
    {
        scoreText.text = score.ToString();
    }
   
}
