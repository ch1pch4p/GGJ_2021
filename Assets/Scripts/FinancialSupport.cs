using UnityEngine;

public class FinancialSupport : MonoBehaviour
{
    public delegate void AddMoney();
    public static event AddMoney OnAddMoney;

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if ("bernie".Equals(col.gameObject.name))
        {
            OnAddMoney();
            Destroy(gameObject);
        }
    }
}
