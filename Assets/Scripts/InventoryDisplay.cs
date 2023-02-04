using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    private InventorySlot[] slots;

    /// <summary>Return slot count.</summary>
    public int Initialize()
    {
        slots = GetComponentsInChildren<InventorySlot>();

        return slots.Length;
    }

    public void UpdateDisplay(Item[] _items)
    {

    }
}