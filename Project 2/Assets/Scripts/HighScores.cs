using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    public Text scorebox;
    // Start is called before the first frame update
    void Start()
    {
        string scores = "";
        int[] highscores = new int[10];
        for(int i = 0; i < 10; i++)
        {
            highscores[i] = PlayerPrefs.GetInt("Scores" + i.ToString());
        }
        int temp;
        for(int i = 0; i<10; i++)
        {
            for(int j = 0; j<9-i; j++)
            {
                if(highscores[j]>highscores[j+1])
                {
                    temp = highscores[j];
                    highscores[j] = highscores[j + 1];
                    highscores[j + 1] = temp;
                }
            }
        }
        for(int i = 0; i < 10; i++)
        {
            PlayerPrefs.SetInt("Scores" + (i).ToString(), highscores[9-i]);
            scores += (i+1).ToString() + ".  " + highscores[9-i] + "\n";
        }
        scorebox.text = scores;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
