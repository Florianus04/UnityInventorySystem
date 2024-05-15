using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{
    public GameObject[] itemListPrefabs;//itemler

    public Transform[] storeTransforms;//magazadaki slotlar
    public Transform[] inventoryTransforms;//envanterdeki slotlar

    public GameObject storePanel;//magaza kismi
    public GameObject inventoryPanel;//envanter kismi

    public static List<int> itemListNumbers = new List<int>();
    public static List<int> inventoryNumbers = new List<int>();

    public static InventoryControl instance;
    void Awake()
    {
        //singleton pattern
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }
    void Start()
    {
        InitializeGuns();//itemleri magazaya ekle
    }
    public void InitializeGuns()
    {
        int j = 0;

        for (int i = 0; i < itemListPrefabs.Length; i++)
        {
            GameObject item = Instantiate(itemListPrefabs[i], storeTransforms[j].position, Quaternion.identity, storePanel.transform);
            item.gameObject.GetComponent<EquipButton>().currentTransform = storeTransforms[i];

            j += 1;

            itemListNumbers.Add(i);

            storeTransforms[i].gameObject.GetComponent<TransformState>().isOccupied = true;
        }
    }
}
