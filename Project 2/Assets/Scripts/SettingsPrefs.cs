using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPrefs : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;
    // Start is called before the first frame update
    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicPref");
        sfxSlider.value = PlayerPrefs.GetFloat("sfxPref");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("musicPref", musicSlider.value);
        PlayerPrefs.SetFloat("sfxPref", sfxSlider.value);
    }
}
