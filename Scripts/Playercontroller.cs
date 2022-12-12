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
    //��ʼ��
    void Start()
    {
       rb= GetComponent<Rigidbody>();//��ֵ
        score = 0;
        countText.text="Count:"+score.ToString();
 
    }
    //����
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

