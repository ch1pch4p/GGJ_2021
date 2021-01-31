using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFinancialSupport : MonoBehaviour
{
    public GameObject financialSupportObj;
    void Start()
    {
        StartCoroutine(SpawnMoney());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator SpawnMoney()
    {
        while (true)
        {
            yield return new WaitForSeconds(((Countdown.currCountdownValue / 80f) * 3) + 0.01f);
            Instantiate(financialSupportObj, new Vector3(Random.Range(-7f, 7f), 5.48f, 0), new Quaternion());
        }
    }
}
