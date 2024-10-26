using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<WeaponController> weaponSlots = new List<WeaponController>();
    public int[] weaponLevels = new int[6];
    public List<PassiveItem> passiveItems = new List<PassiveItem>();
    public int[] passiveItemLevels = new int[6];


    public void AddWeapon(int slotIndex, WeaponController weapon)
    {
        weaponSlots[slotIndex] = weapon;
    }

    public void AddPassiveItem(int slotIndex, PassiveItem passiveItem)
    {
        passiveItems[slotIndex] = passiveItem;
    }

}
