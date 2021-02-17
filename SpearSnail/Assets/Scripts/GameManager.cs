using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance { get; private set; }

    public GameObject dialogBox;
    public GameObject dialogText;
    public int stamps;
    public Text scoreText;

    public string endGameScene;

    void Start()
    {
        scoreText.text = "Stamps: " + stamps;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartDialog(string text)
    {
        dialogBox.SetActive(true);
        dialogText.GetComponent<TextMeshProUGUI>().text = text;
    }

    public void HideDialog()
    {
        dialogBox.SetActive(false);
    }

    public void collectStamps(int numStamps)
    {
        stamps += numStamps;
        scoreText.text = "Stamps: " + stamps;
        if (stamps == 5)
        {
            SceneManager.LoadScene(endGameScene);
        }
    }
    
}
