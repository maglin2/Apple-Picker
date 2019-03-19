using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int score;
    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bullet(Clone)")
        {
            score -= 10;
            textbox.text = score.ToString();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "points(Clone)")
        {
            score += 30;
            textbox.text = score.ToString();
            Destroy(collision.gameObject);
        }
    }
}
