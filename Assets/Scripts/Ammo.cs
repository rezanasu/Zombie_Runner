﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] AmmoSlot[] ammoSlots;

    [System.Serializable]
    private class AmmoSlot
    {
        public AmmoType ammoType;
        public int ammoAmount;
    }

    public int GetCurrentAmmo(AmmoType ammoType)
    {
        AmmoSlot currentSlot = GetAmmoSlot(ammoType);
        return currentSlot.ammoAmount;
    }

    public void ReduceCurrentAmmo(AmmoType ammoType)
    {
        AmmoSlot currentSlot = GetAmmoSlot(ammoType);
        currentSlot.ammoAmount--;
    }

    public void IncreaseCurrentAmmo(AmmoType ammoType, int ammoAmount)
    {
        AmmoSlot currentSlot = GetAmmoSlot(ammoType);
        currentSlot.ammoAmount += ammoAmount;
    }

    private AmmoSlot GetAmmoSlot(AmmoType ammoType)
    {
        foreach(AmmoSlot slot in ammoSlots)
        {
            if(slot.ammoType == ammoType)
            {
                return slot;
            } 
        }
        return null;
    }

}
