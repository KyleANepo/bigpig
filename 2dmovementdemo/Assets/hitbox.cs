using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().GetComponent<Player>() && !collision.GetComponent<Collider2D>().GetComponent<Player>().isDead)
        {
            collision.GetComponent<Collider2D>().GetComponent<Player>().Die();
        }
    }
}
