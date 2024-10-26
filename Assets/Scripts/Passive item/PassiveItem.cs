
using UnityEngine;

public class PassiveItem : MonoBehaviour
{
    protected PlayerStats player;
    public PassiveItemScriptableObject passiveItemData;

    protected virtual void ApplyModifier()
    {

    }

    private void Start()
    {
        player = FindObjectOfType<PlayerStats>();
        ApplyModifier();
    }
}
