using UnityEngine;
using UnityEngine.UI;

public class InventoryContextMenu : MonoBehaviour
{
    private int targetSlotID;

    [SerializeField] private Button dropButton, closeButton;
    private Inventory inventory;

    private void Awake()
    {
        dropButton.onClick.AddListener(Drop);
        closeButton.onClick.AddListener(Close);
    }

    public void Init(Inventory _inventory)
    {
        inventory = _inventory;
    }

    public void Select(int _slotID, InventorySlot _slot)
    {
        Item _slotItem = inventory.Data[_slotID];

        if(_slotItem.Empty) 
        {
            Close();
            return;
        }

        gameObject.SetActive(true);
        transform.position = _slot.transform.position;
        targetSlotID = _slotID;
    }

    #region Inputs

    private void Drop()
    {
        inventory.PickItem(targetSlotID);
        Close();
    }

    private void Close()
    {
        gameObject.SetActive(false);
    }

    #endregion
}