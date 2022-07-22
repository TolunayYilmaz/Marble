using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public GameObject manager;
    // private int coinSayisi=18;
    int a;
    int b;
    private void Start()
    {
        a=  GameObject.FindGameObjectsWithTag("Coin").Length;
        b= GameObject.FindGameObjectsWithTag("StarCoin").Length;
    }

    private void OnTriggerEnter(Collider other)
    {
        //foreach (var item in Coin)
        //{
        //    if (item.tag == "Coin")
        //    {
        //        Destroy(item);
        //    }
        //}

        if (other.gameObject.tag == "Coin")
        {
            a = a - 1;
            Destroy(other.gameObject);

            manager.GetComponent<GameManager>().TriggerTest(a,b);

        }
        if (other.gameObject.tag == "StarCoin")
        {
            b = b - 1;
            Destroy(other.gameObject);

            manager.GetComponent<GameManager>().TriggerTest(a, b);
            
        }

        
        if (other.gameObject.tag == "Restart")
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
}
