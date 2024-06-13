using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private int currLevel = 0;
    GameObject cam;
    void Start()
    {
        GameObject cam = GameObject.FindGameObjectWithTag("Main Camera");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            cam.GetComponent<MainMenuManager>();
        }
    }
}
