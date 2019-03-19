using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void Click()
    {
        if (active)
        {
            this.gameObject.SetActive(false);
            active = false;
        }
        else
        {
            this.gameObject.SetActive(true);
            active = true;
        }
    }
}
