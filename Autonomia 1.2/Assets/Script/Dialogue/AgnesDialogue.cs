using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgnesDialogue : MonoBehaviour
{
    public int choix = 0;
    //bool de conversation
    public bool startConv, curConv, endConv;
    public bool part1 = true, part2, part3, part4, part5;
    //public int i, j, k;// i main,j y
    //dialogue UI
    public GameObject DialogueUI;
    public Text mainText, textY, textN;
    public string[] Main, MainY, MainN, Y, N;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y) && startConv == true)
        {
            yChoice();
        }
        if (Input.GetKeyDown(KeyCode.N) && startConv == true)
        {
            nChoice();
        }
        if (curConv == true)
        {
            DialogueUI.SetActive(true);
        }
        else
        {
            DialogueUI.SetActive(false);
        }
        if (part1 == true && part2 == false && part3 == false && part4 == false && part5 == false)//juste changer les valeur
        {

            if (choix == 1)
            {
                
                mainText.text = Main[1];
                textY.text = Y[1];
                textN.text = N[1];
                part2 = true;
                choix = 0;
            }
            else if (choix == -1)
            {
                mainText.text = Main[1]; 
                textY.text = Y[1];
                textN.text = N[1];
                part2 = true;
                choix = 0;
            }
        }
        //parti 2
        if (part1 == true && part2 == true && part3 == false && part4 == false && part5 == false)
        {
            mainText.text = Main[1]; // exactement ...
            textY.text = Y[1];//revolution
            textN.text = N[1];


            if (choix == 1)
            {
                mainText.text = Main[2];
                textY.text = Y[2];
                textN.text = N[2];
                part3 = true;
                choix = 0;
            }
            else if (choix == -1)
            {
                mainText.text = Main[2];
                textY.text = Y[2];
                textN.text = N[2];
                part3 = true;
                choix = 0;
            }
        }
        //partie 3
        if (part1 == true && part2 == true && part3 == true )
        {
            mainText.text = Main[2];
            textY.text = Y[2];
            textN.text = N[2];
            if (choix == 1)
            {
                mainText.text = Main[3];
                textY.text = Y[3];
                textN.text = N[3];
                //part4 = true;
                endConv = true;

            }
            else if (choix == -1)
            {
                mainText.text = Main[3];
                textY.text = Y[3];
                textN.text = N[3];
                //part4 = true;
                endConv = true;

            }
        }
        //partie 4
        if (part1 == true && part2 == true && part3 == true && part4==true)
        {
            mainText.text = Main[3];
            textY.text = "";
            textN.text = "";
            
        }

    }

    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            startConv = true;
            curConv = true;
            part1 = true;
            mainText.text = Main[0];//la reforme ....
            
            textY.text = Y[0] + "[Y]";
            textN.text = N[0] + "[N]";

        }
    }

    public void OnTriggerExit(Collider other)
    {
        startConv = false;
        curConv = false;
    }

    public void yChoice()
    {
        choix = 1;
    }
    public void nChoice()
    {
        choix = -1;
    }
}
