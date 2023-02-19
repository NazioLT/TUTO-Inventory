using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Item itemToPush, pickedItem;

    private Inventory inventory;

    private void Awake()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    [ContextMenu("test 1")]
    public void Test1()
    {
        itemToPush = inventory.AddItem(itemToPush);
    }

    [ContextMenu("test 2")]
    public void Test2()
    {
        pickedItem = inventory.PickItem(1);
    }
}
