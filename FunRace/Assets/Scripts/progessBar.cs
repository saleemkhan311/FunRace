using UnityEngine;
using UnityEngine.UI;

public class progessBar : MonoBehaviour
{
    [SerializeField] private Image progressBar;
    float lastValue;
    float timer;

    // Update is called once per frame
    void Update()
    {
        
        if (!gameManager.singleton.gameHasStarted)
        { return; }

        float traveldDistance = gameManager.singleton.entireDistance - gameManager.singleton.distanceLeft;
        float value = (traveldDistance / gameManager.singleton.entireDistance) ;
        Debug.Log("Value is: "+value);
        /*if (gameManager.singleton.gameObject && value < lastValue)
            return;*/
         timer  += Time.deltaTime;
        progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount, value, timer);
        //progressBar.fillAmount = timer;
        lastValue = value;
        
    }
}
