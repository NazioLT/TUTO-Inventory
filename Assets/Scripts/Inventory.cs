using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private InventoryDisplay display;
    [SerializeField] private InventoryData data;

    private InventoryContext context;

    private void Awake()
    {
        int _slotCount = display.Initialize(this);

        data = new InventoryData(_slotCount);

        display.UpdateDisplay(data.items);
    }

    public Item AddItem(Item _item)
    {
        if(!data.SlotAvailable(_item)) return _item;

        data.AddItem(ref _item);

        display.UpdateDisplay(data.items);

        return _item;
    }

    public Item PickItem(int _slotID)
    {
        Item _result = data.Pick(_slotID);

        display.UpdateDisplay(data.items);

        return _result;
    }

    public void SwapSlots(int _slotA, int _slotB)
    {
        data.Swap(_slotA, _slotB);

        display.UpdateDisplay(data.items);
    }

    public Item[] Data => data.items;
    public InventoryContext Context => context;
}