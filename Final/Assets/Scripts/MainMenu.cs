using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartGameButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void StartGameButton(){
        SceneManager.LoadScene("Final");
    }
}
