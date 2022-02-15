using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemymovement : MonoBehaviour
{
    public float speed;
    public bool left,right,up,bottom;
    private Text num;
    private static float counter=3;
    
   // public Transform tanrgetleft,targetright,targetup,targetbottom;
    //public GameObject[] targets;
    // Start is called before the first frame update
    void Start()
    {
        num=GameObject.FindGameObjectWithTag("counter").GetComponent<Text>();
       // num.transform.position=transform.position;
        num.text="2";
        
      //  InvokeRepeating("MoveRandom",1,Random.Range(1,1.5f));
    }

    // Update is called once per frame
    void Update()
    {     
       
        
        if(left==true){
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        }
        if(right==true){
            transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
        if(up==true){
            transform.Translate(Vector3.up*speed*Time.deltaTime);
        }
        if(bottom==true){
            transform.Translate(Vector3.down*speed*Time.deltaTime);
        }
        //    Vector3 a=transform.position;
          //  var alltarget=Random.Range(0,targets.Length);
            
          //  transform.position=Vector3.MoveTowards(a,alltarget,speed);
            //for(int i=0;i<=targets.Length;i++){
               // transform.Translate(Vector3.right*alltarget*speed*Time.deltaTime);
            //}
            
        



        // transform.Translate(Vector3.right*speed*Time.deltaTime);
        // var x=Random.Range(8,-8);
        // if(rightmove==true){
        //      transform.Translate(Vector3.right *speed*Time.deltaTime);
        // }
        // if(leftmove==true){
        //      transform.Translate(Vector3.left*speed*Time.deltaTime);
        // }
        // if(transform.position.x<=-8){
        //     leftmove=false;
        //     rightmove=true;
        //   //  transform.position= new Vector3(-8,transform.position.y,transform.position.z);
        // }
        // if(transform.position.x>=8 ){
        //     rightmove=false;
        //     leftmove=true;
        //     //transform.Translate(Vector3.left*speed*Time.deltaTime);
       // }
     //   if(transform.position.x<=8){
       //     transform.Translate(Vector3.down*speed*Time.deltaTime);
        //}
        //if(transform.position.x>=8){
          //  transform.Translate(Vector3.down*speed*Time.deltaTime);
        //}
       // Vector3 spawnPosz=new Vector3(Random.Range(5,-5),Random.Range(5,-5),0);
        // var x=Random.Range(5,-5);
        // var y=Random.Range(5,-5);
        // transform.Translate(Vector3.right*x*speed*Time.deltaTime);
    }
    public void OnCollisionEnter(Collision col){
        if(col.gameObject.tag=="right"){
           right=false;
           bottom=true;
           left=true;
          // transform.position=new Vector3(transform.position.x,transform.position.y-1,transform.position.z);

        }
         if(col.gameObject.tag=="left"){
           left=false;
           right=true;
           up=false;
           bottom=true;
           
           //transform.position=new Vector3(transform.position.x+1,transform.position.y,transform.position.z);
        }
         if(col.gameObject.tag=="bottom"){
           bottom=false;
           up=true;
          
           //transform.position=new Vector3(transform.position.x,transform.position.y+1,transform.position.z);
        }
         if(col.gameObject.tag=="up"){
           up=false;
           right=false;
           right=true;
           bottom=true;
          
           transform.position=new Vector3(transform.position.x,transform.position.y-1,transform.position.z);
        }
        if(col.gameObject.tag==("bulet")){
           
        }
        if(col.gameObject.tag=="bulet"){
        Debug.Log("collided");
        }
        
    }
       
}
