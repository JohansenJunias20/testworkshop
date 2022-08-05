using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public GameObject GO_PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        GO_PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // LISTEN ON ESCAPE KEY BUTTON
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        GO_PauseMenu.SetActive(!GO_PauseMenu.active);
            //pause the scene

        }

        
    }
}
