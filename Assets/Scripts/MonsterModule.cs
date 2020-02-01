using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterModule : MonoBehaviour
{
    private Animator animator;
    private bool isDeath = false;
    public AnimationClip deathclip = null;

    void Awake()
    {
        animator = transform.GetChild(0).GetComponent<Animator>();
    }

    
    public void Death()
    {
        if (isDeath) return;

        StartCoroutine(UpdateDeath());
    }

    private IEnumerator UpdateDeath()
    {
        isDeath = true;
        animator.Play("Death");

        yield return new WaitForSeconds(deathclip.length);
       

        DestroyImmediate(gameObject);
        yield break;
        
    }
}
