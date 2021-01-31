using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddMoneyListener : MonoBehaviour
{
    public static int totalMoney;
    private Text totalMoneyTxt;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        FinancialSupport.OnAddMoney += DisplayNewAmount;
        totalMoneyTxt = GetComponent<Text>();
        DisplayCurrentMoney();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayNewAmount()
    {
        audioSource.Play();
        totalMoney += 10;
        DisplayCurrentMoney();
    }

    void DisplayCurrentMoney()
    {
        totalMoneyTxt.text = "$" + totalMoney.ToString();
    }
}
