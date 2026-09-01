using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button exit_btn, point_btn, credits_btn;
    public GameObject creditsPrefab;
    public ScoreHolder memoryObject;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        exit_btn.onClick.AddListener(QuitOnClick);
        credits_btn.onClick.AddListener(OpenCredits);
        point_btn.onClick.AddListener(IncreaseScore);
        scoreText.SetText("Your Score: {0}", memoryObject.Score);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OpenCredits()
    {
        Instantiate(creditsPrefab);
    }

    void QuitOnClick()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
                Application.Quit();
    #endif
    }

    void IncreaseScore()
    {
        memoryObject.Score++;
        Debug.Log(memoryObject.Score);
        scoreText.SetText("Your Score: {0}", memoryObject.Score);
    }
}