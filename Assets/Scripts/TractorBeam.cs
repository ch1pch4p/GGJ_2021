using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorBeam : MonoBehaviour
{
    [SerializeField]
    float beamStrength = 5.0f;

    private ParticleSystem beamVisual;
    // Start is called before the first frame update
    void Start()
    {
        beamVisual = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerStay2D(Collider2D col)
    {
        col.gameObject.TryGetComponent<Rigidbody2D>(out Rigidbody2D component);
        if (component != null)
        {
            if (!beamVisual.isPlaying)
            {
                beamVisual.Play();
            }
            Vector2 towardsUFO = transform.parent.transform.position - col.transform.position;
            component.AddForce(towardsUFO * beamStrength);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        beamVisual.Stop();
    }
}
