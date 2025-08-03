using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    public TMP_InputField nameInputField;

    void Start()
    {
        bestScoreText.text += GameManager.Instance.name + ": " + GameManager.Instance.highestScore;
        nameInputField.text = GameManager.Instance.name;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        if (nameInputField.text != "")
        {
            GameManager.Instance.name = nameInputField.text;
        }
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit(); // original code to quit Unity player
        #endif
    }
}
