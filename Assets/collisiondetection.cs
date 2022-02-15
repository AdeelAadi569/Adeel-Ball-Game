using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisiondetection : MonoBehaviour
{
    private Text score,win;
    //private GameObject ball1;
   
    private static float counter=0;    
    // Start is called before the first frame update
    void Start()
    {
        //counter=0;
      //  ball1=GameObject.Find("ball1");
      //  ball1=GameObject.FindGameObjectWithTag("enamy1").GetComponent<GameObject>();
        win=GameObject.FindGameObjectWithTag("win").GetComponent<Text>();
        score=GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
       // score.text="Score :"+counter;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision col){
        if(col.gameObject.tag==("enamy")){
              Destroy(gameObject);
              counter+=1;
              Destroy(col.gameObject);
              score.text="Score :"+counter;
              //col.transform.localScale=new Vector3(0.5f,0.5f,0.5f);
        }
        if(col.gameObject.tag==("enamy1")){
            Debug.Log("Large Ball");
            col.transform.localScale=new Vector3(2,2,2);  
                  }
        if(counter==5){
           win.text="You Win";
           Time.timeScale=0;
        }
        
      
        // 
        // counter+=1;
        
    }
}
