using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    private int index;

    [SerializeField] private TextMeshProUGUI itemCountText;
    [SerializeField] private Image itemImage;
    private Button button;
    private InventoryDisplay inventoryDisplay;

    /// <summary>Methode qui initialise l'objet</summary>
    public void Initialize(InventoryDisplay _inventoryDisplay, int _index)
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(OnClick);
        index = _index;
        inventoryDisplay = _inventoryDisplay;
    }

    public void OnClick()
    {
        inventoryDisplay.ClickSlot(index);
    }

    public void UpdateDisplay(Item _item)
    {
        if (!_item.Empty)
        {
            itemCountText.text = _item.Count.ToString();
            itemImage.sprite = _item.Data.icon;
            itemImage.color = Color.white;
            return;
        }

        itemCountText.text = "";
        itemImage.sprite = null;
        itemImage.color = new Color(0,0,0,0);
    }
}