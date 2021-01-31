using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseListener : MonoBehaviour
{
    private AudioSource notEnoughFundingVoiceClip;
    public const int fundingGoal = 420;
    private Text winLoseText;
    // Start is called before the first frame update
    void Start()
    {
        Countdown.OnTimesUp += DisplayMessage;
        winLoseText = GetComponent<Text>();
        notEnoughFundingVoiceClip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayMessage(int totalMoney)
    {
        if (totalMoney >= fundingGoal)
        {
            winLoseText.color = new Color(0, 255, 0);
            winLoseText.text = "Thank you for your financial support.";
        } else
        {
            notEnoughFundingVoiceClip.Play();
            winLoseText.color = new Color(255, 0, 0);
            winLoseText.text = "I am once again asking for your financial support.";
        }
    }
}
