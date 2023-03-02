using UnityEngine;

[System.Serializable]
public class InventoryData
{
    public InventoryData(int _slotCount)
    {
        items = new Item[_slotCount];
    }

    [field: SerializeField] public Item[] items { private set; get; }

    public bool SlotAvailable(Item _itemToAdd)
    {
        foreach (var _item in items)
        {
            if (_item.AvailableFor(_itemToAdd)) return true;
        }

        return false;
    }

    public void AddItem(ref Item _itemToAdd)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (_itemToAdd.Empty) return;//Finished

            if (items[i].AvailableFor(_itemToAdd))
            {
                items[i].Merge(ref _itemToAdd);
            }
        }
    }

    public Item Pick(int _slotID)
    {
        if (_slotID > items.Length) throw new System.Exception("Out of inventory");

        Item _item = items[_slotID];
        items[_slotID] = new Item();

        return _item;
    }
}