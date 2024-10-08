using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffect : MonoBehaviour
{
    private Rigidbody2D rb;
    private float thrust = 6f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        rb.AddForce(transform.right * Random.Range(-2f, 2f), ForceMode2D.Impulse);
        rb.AddTorque(Random.Range(-4f, 4f), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
