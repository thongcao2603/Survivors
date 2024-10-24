using UnityEngine;

public class KnifeBehavior : ProjectileWeaponBehaviour
{

    protected override void Start()
    {
        base.Start();

    }
    private void Update()
    {
        transform.position += direction * currentSpeed * Time.deltaTime;
    }
}
