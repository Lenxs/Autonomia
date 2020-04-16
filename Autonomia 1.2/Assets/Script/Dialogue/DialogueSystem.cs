using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public int choiceY = 0,choiceN=0;
    //bool de conversation
    public bool startConv, endConv;
    public bool part1, part2, part3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y)&&startConv==true)
        {
            yChoice();
            Debug.Log("nb y:" + choiceY);
        }
        if(Input.GetKeyDown(KeyCode.N)&&startConv==true)
        {
            nChoice();
            Debug.Log("nb n:" + choiceN);
        }
    }

    public void yChoice()
    {
        choiceY++;
    }
    public void nChoice()
    {
        choiceN++;
    }
}
