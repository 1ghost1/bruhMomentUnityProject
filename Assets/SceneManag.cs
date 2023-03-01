using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManag : MonoBehaviour
{

    public static bool isPaused = false;
    [SerializeField]public GameObject pausedText;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.P)){
            isPaused = !isPaused;

            if(Time.timeScale == 0){
                Time.timeScale = 1;
            }else if(Time.timeScale == 1){
                Time.timeScale = 0;
            }

            pausedText.SetActive(isPaused);
        }
            
        
    }
}
