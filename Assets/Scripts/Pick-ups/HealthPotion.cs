using UnityEngine;

public class HealthPotion : Pickup, ICollectable
{
    public int healthToStore;
    public void Collect()
    {
        PlayerStats player = FindObjectOfType<PlayerStats>();
        player.RestoreHealth(healthToStore);

    }

}
