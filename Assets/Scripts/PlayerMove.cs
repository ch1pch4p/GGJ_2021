using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        FollowMouse();
    }

    private void FollowMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenPointToRay(Input.mousePosition).origin;
        float dist = Vector3.Distance(transform.position, mousePosition);
        transform.position = Vector3.MoveTowards(transform.position, mousePosition, dist * 0.02f);
    }
}
