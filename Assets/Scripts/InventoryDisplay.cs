using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    private InventorySlot[] slots;

    /// <summary>Return slot count.</summary>
    public int Initialize()
    {
        slots = GetComponentsInChildren<InventorySlot>();

        for (var i = 0; i < slots.Length; i++)
        {
            slots[i].Initialize(this, i);
        }

        return slots.Length;
    }

    public void UpdateDisplay(Item[] _items)
    {
        for (var i = 0; i < _items.Length; i++)
        {
            slots[i].UpdateDisplay(_items[i]);
        }
    }

    public void ClickSlot(int _index)
    {
        Debug.Log($"Clic on slot {_index}");
    }
}