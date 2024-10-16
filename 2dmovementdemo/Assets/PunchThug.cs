using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchThug : Thug
{
    [SerializeField] private Transform playerCheck;
    [SerializeField] private LayerMask playerLayer;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject hitbox;
    [SerializeField] AudioClip dieSoundClip;

    public bool Flip = false;

    // Start is called before the first frame update
    void Start()
    {
        if (Flip)
        {
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsPlayer", IsPlayer());
    }

    bool IsPlayer()
    {
        return Physics2D.OverlapCircle(playerCheck.position, 0.2f, playerLayer);
    }

    public void HitboxOn()
    {
        hitbox.SetActive(true);
    }

    public void HitboxOff()
    {
        hitbox.SetActive(false);
    }

    public GameObject deathEffect;

    public override void Die()
    {
        GameObject CE = Instantiate(deathEffect, transform.position, transform.rotation);
        SFXManager.Instance.PlaySoundFXClip(dieSoundClip, transform, 1f);
        Destroy(gameObject);
    }
}
