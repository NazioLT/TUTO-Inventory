using UnityEngine;
/// <summary>Un stack d'item "réel", qui peut etre stocké dans l'inventaire</summary>
[System.Serializable]
public struct Item
{
    [SerializeField] private int count;
    [SerializeField] private ItemData data;
}