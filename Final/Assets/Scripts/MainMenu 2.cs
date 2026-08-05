using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{

    public void StartGameButton(){
        SceneManager.LoadScene("Final Game + tutorial Aidan");
    }

    public Button startButton;
    // Start is called before the first frame update
    void Start()

    {
        startButton.onClick.AddListener(StartGameButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
