﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class trashGame_Delete : MonoBehaviour
{

    public GameObject trash;
    public int score;
    public float LimiTime;
    public Text Timetext;
    public Text Scoretext;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LimiTime > 0)
        {
            LimiTime -= Time.deltaTime;
            Timetext.text = "T I M E : " + (int)LimiTime;
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
            Destroy(gameObject);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        score++;
        Scoretext.text = "SCORE : " + (int)score;
        Debug.Log(score);
        Instantiate(trash, new Vector3(0, 0, 0), Quaternion.identity);
       
    }

    
}