using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public delegate void TimesUp(int totalMoneyRaised);
    public static event TimesUp OnTimesUp;
    public static int currCountdownValue = 75;

    private Text timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown());
        timeRemaining = GetComponent<Text>();
        timeRemaining.text = currCountdownValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator StartCountdown()
    {
        while (currCountdownValue > 0)
        {
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
            timeRemaining.text = currCountdownValue.ToString();
        }

        if (currCountdownValue == 0)
        {
            OnTimesUp(AddMoneyListener.totalMoney);
        }
    }

}
