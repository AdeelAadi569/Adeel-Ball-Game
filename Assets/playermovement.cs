using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermovement : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public Text gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontal*speed*Time.deltaTime);
        if(transform.position.x<=-12){
            transform.position=new Vector3(-12,transform.position.y,transform.position.z);
        }
        if(transform.position.x>=14){
            transform.position=new Vector3(14,transform.position.y,transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("pressed space key for instantiate the bullet");
            Instantiate(bullet,transform.position,bullet.transform.rotation);
        }
    }
    public void OnCollisionEnter(Collision col){
        if(col.gameObject.tag=="enamy"){
            Debug.Log("Player Collided with Ball");
            Destroy(gameObject);
            Destroy(col.gameObject);
            Time.timeScale=0;
            gameover.text="Game Over";
        }
    }
}
