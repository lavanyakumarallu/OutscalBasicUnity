using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class myScript : MonoBehaviour
{
    public Button button;
    public string newScene;

    public Button Button { get => button; set => button = value; }

    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

   private void OnButtonClick()
    {
        Debug.Log("Button Clicked!!");
        SceneManager.LoadScene(newScene);
    }
}
