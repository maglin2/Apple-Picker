using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DestroyScript : MonoBehaviour
{
    public Text lives;
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
            SceneManager.LoadScene("MainScene");
        }
        Destroy(collision.gameObject);
    }
}
