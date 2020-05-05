using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisadDialogue : MonoBehaviour
{
    //dial sans reel choix
    public int choix = 0;
    //bool de conversation
    public bool startConv, curConv, endConv;
    public bool part1 = true, part2, part3, part4,part5;
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
                mainText.text = Main[1];//avant j'était
                textY.text = Y[1];
                textN.text = N[1];
                part2 = true;
                choix = 0;
            }
            else if (choix == -1)
            {
                mainText.text = Main[1]; // avant j'était
                textY.text = Y[1];
                textN.text = N[1];
                part2 = true;
                choix = 0;
            }
        }
        //parti 2
        if (part1 == true && part2 == true && part3 == false && part4 == false && part5 == false)
        {
            mainText.text = Main[1];//avant ..
            textY.text = Y[1];
            textN.text = N[1];
            if (choix == 1)
            {
                mainText.text = Main[2];//meme pas ...
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
        if (part1 == true && part2 == true && part3 == true && part4 == false && part5 == false)
        {
            mainText.text = Main[2];//meme pas frapper...
            textY.text = Y[2];
            textN.text = N[2];
            if (choix == 1)
            {
                mainText.text = Main[3];//tu rep ...
                textY.text = Y[3];
                textN.text = N[3];
                part4 = true;
                choix = 0;

            }
            else if (choix == -1)
            {
                mainText.text = Main[3];
                textY.text = Y[3];
                textN.text = N[3];
                part4 = true;
                choix = 0;

            }
        }
        //Parti 4
        if (part1 == true && part2 == true && part3 == true && part4==true && part5==false)
        {
            mainText.text = Main[3];//tu rep ...
            textY.text = Y[3];
            textN.text = N[3];
            if (choix == 1)
            {
                mainText.text = Main[4];//tu m'as l'air sym...
                textY.text = Y[3];
                textN.text = N[3];
                part5 = true;

            }
            else if (choix == -1)
            {
                mainText.text = Main[4];
                textY.text = Y[3];
                textN.text = N[3];
                part5 = true;

            }

        }
        if (part1 == true && part2 == true && part3 == true && part4 == true&&part5==true)
        {
            mainText.text = Main[4];
            textY.text = "";
            textN.text = "";
            endConv = true;
        }
    }

    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            startConv = true;
            curConv = true;
            part1 = true;
            mainText.text = Main[0];// oh desolé ...
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
