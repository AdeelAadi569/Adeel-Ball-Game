using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button resume;
    // Start is called before the first frame update
    void Start()
    {
        resume.gameObject.SetActive(false);
        //resume.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Time.timeScale=0;
           // resume.enabled=true;
             resume.gameObject.SetActive(true);
        }
        
    }
    public void Resume(){
        resume.gameObject.SetActive(false);
        Time.timeScale=1;
        //resume.enabled=true;
       // if(pause==false){
        //Time.timeScale=0;
        //GameObject.Find("pause").GetComponentInChildren<Text>().text="Resume";
    
    }
    
    
   
    
    
}
