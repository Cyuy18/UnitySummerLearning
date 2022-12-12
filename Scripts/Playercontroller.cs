using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour
{      
    private Rigidbody rb;
    public float speed;
    public Text countText;
    private int score;
    //初始化
    void Start()
    {
       rb= GetComponent<Rigidbody>();//赋值
        score = 0;
        countText.text="Count:"+score.ToString();
 
    }
    //更新
    void Update()
    {   
        Vector3 movement;
        movement = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        rb.AddForce(movement*speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score++;
            countText.text = "Count:" + score.ToString();
        }
    }
}

