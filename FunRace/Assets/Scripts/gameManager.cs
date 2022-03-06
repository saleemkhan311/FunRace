using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public bool gameHasStarted;
    public bool gameHasEnded = false;
    public bool failed = false;
    PlayerMovement movement;
    public Transform endPoint;

    GameObject player;
    void Start()
    {
        
        movement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame

   public void EndGame()
    {
        
        //Invoke("Restart", 30);
    }

    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    void Update()
    {
       
    }
}
