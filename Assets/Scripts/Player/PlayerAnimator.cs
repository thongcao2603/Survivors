using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    //Ref
    Animator anim;
    PlayerMovement pm;
    SpriteRenderer sr;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        pm = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (pm.moveDir.x != 0 || pm.moveDir.y != 0)
        {
            anim.SetBool("Move", true);
            SpriteDirectionChecker();
        }
        else
        {
            anim.SetBool("Move", false);
        }
    }

    void SpriteDirectionChecker()
    {
        if (pm.moveDir.x < 0)
        {
            sr.flipX = true;
        }
        else if (pm.moveDir.x > 0)
        {
            sr.flipX = false;
        }
    }
}
