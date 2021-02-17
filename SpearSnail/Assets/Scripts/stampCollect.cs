using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stampCollect : MonoBehaviour
{
    private GameManager gameLevelManager;
    public int stampValue;

    // Start is called before the first frame update
    void Start()
    {
        gameLevelManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameLevelManager.collectStamps(stampValue);
            Destroy(gameObject);
        }
    }
}
