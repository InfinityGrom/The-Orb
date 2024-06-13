using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollider : MonoBehaviour
{
    
    private int live = 3;
    private int currentLevel = 0;

    void Update()
    {
        


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Portal")
        {
            SceneManager.LoadScene(currentLevel);
        }
    }
}
