using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Duvar;
    private Rigidbody Player;
    private Text U�Text;
    private Text U�Text2;
    private int scorePoint;
    private void Start()
    {
        // Duvar = GameObject.FindGameObjectWithTag("Duvar").GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        U�Text = GameObject.FindGameObjectWithTag("Text").GetComponent<Text>();
        U�Text2 = GameObject.FindGameObjectWithTag("Text2").GetComponent<Text>();
        U�Text2.text = "Skor";
        U�Text.text = " ";

    }
    public void TriggerTest(int say,int say2)// �zelle�tir.
    {

        Score();
        if (say == 1)
        {
            Debug.Log("a��ld�");
            Duvar.SetBool("OpenDoor", true);
        

        }
       
        if (say2 == 0)
        {
            Player.isKinematic = true;
            Debug.Log("Kazand�n");
            U�Text.text = "Kazand�n";
        }
        Debug.Log(say.ToString() + "  " + say2.ToString());
    }

    void Score()
    {

        scorePoint += 10;
        U�Text2.text = "Skor " + scorePoint;
        
    }
}
