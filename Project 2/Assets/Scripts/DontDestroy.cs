using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    // Update is called once per frame
    public AudioSource player;
    void Update()
    {
        DontDestroyOnLoad(this);
    }
    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        player.Play();

    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player.Stop();
        player.Play();
    }
}
