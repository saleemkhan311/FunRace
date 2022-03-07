using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager singleton;
    public bool gameHasStarted;
    public bool gameHasEnded = false;
    public bool failed = false;
    PlayerMovement movement;
    public Transform player;
    public Transform endPoint;
    public Transform startPoint;
    public int currentLevel = 0;
    public int nextLevel;

   

    public float entireDistance { private set;  get; }
    public float distanceLeft { private set;  get; }

    private void Awake()
    {
        if(singleton == null)
        {
            singleton = this;

        }
        else if(singleton !=this)
        {
            Destroy(gameObject);
        }

        gameHasStarted = true;
    }

    void Start()
    {
        entireDistance = endPoint.position.z- startPoint.position.z;
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

    void NextLevel()
    {
        currentLevel ++;

        nextLevel = currentLevel + 1;
        

    }
    void Update()
    {
        distanceLeft = Vector3.Distance(player.position, endPoint.position);

        if(distanceLeft > entireDistance)
        {
            distanceLeft = entireDistance;
        }
        if (player.position.z > endPoint.position.z)
        {
            distanceLeft = 0;
        }

        
    }
}
