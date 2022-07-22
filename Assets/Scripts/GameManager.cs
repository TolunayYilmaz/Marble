using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Duvar;
    private Rigidbody Player;
    private Text UýText;
    private Text UýText2;
    private int scorePoint;
    private void Start()
    {
        // Duvar = GameObject.FindGameObjectWithTag("Duvar").GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        UýText = GameObject.FindGameObjectWithTag("Text").GetComponent<Text>();
        UýText2 = GameObject.FindGameObjectWithTag("Text2").GetComponent<Text>();
        UýText2.text = "Skor";
        UýText.text = " ";

    }
    public void TriggerTest(int say,int say2)// özelleþtir.
    {

        Score();
        if (say == 1)
        {
            Debug.Log("açýldý");
            Duvar.SetBool("OpenDoor", true);
        

        }
       
        if (say2 == 0)
        {
            Player.isKinematic = true;
            Debug.Log("Kazandýn");
            UýText.text = "Kazandýn";
        }
        Debug.Log(say.ToString() + "  " + say2.ToString());
    }

    void Score()
    {

        scorePoint += 10;
        UýText2.text = "Skor " + scorePoint;
        
    }
}
