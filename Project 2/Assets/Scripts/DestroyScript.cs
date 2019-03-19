using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DestroyScript : MonoBehaviour
{
    public Text lives;
    public Text score;
    private int livesCount;
    // Start is called before the first frame update
    void Start()
    {
        livesCount = 3;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "points(Clone)")
            livesCount -= 1;
        lives.text = "Lives: " + livesCount;
        if(livesCount == 0)
        {
            if (System.Int32.Parse(score.text) > PlayerPrefs.GetInt("Scores9"))
            {
                PlayerPrefs.SetInt("Scores9", System.Int32.Parse(score.text));
            }
            SceneManager.LoadScene("HighScores");
        }
        Destroy(collision.gameObject);
    }
}
