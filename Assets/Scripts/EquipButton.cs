using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipButton : MonoBehaviour
{
    private int itemNo;
    public Transform currentTransform;
    private void Start()
    {
        itemNo = GetComponent<ItemNo>().itemNo;
    }
    public void EquipItem()
    {
        //itemin durumunu kontrol et
        bool isInGunsPanel = InventoryControl.itemListNumbers.Contains(itemNo);
        Transform[] targetTransforms = isInGunsPanel ? InventoryControl.instance.inventoryTransforms : InventoryControl.instance.storeTransforms;
        List<int> sourceList = isInGunsPanel ? InventoryControl.itemListNumbers : InventoryControl.inventoryNumbers;
        List<int> targetList = isInGunsPanel ? InventoryControl.inventoryNumbers : InventoryControl.itemListNumbers;
        GameObject targetPanel = isInGunsPanel ? InventoryControl.instance.inventoryPanel : InventoryControl.instance.storePanel;

        //bos slot bul
        Transform emptyTransform = FindEmptyTransform(targetTransforms);

        if (emptyTransform != null)
        {
            //tasi
            transform.SetParent(targetPanel.transform, false);
            transform.position = emptyTransform.position;

            //listeleri guncelle
            sourceList.Remove(itemNo);
            targetList.Add(itemNo);

            //yeni transformu dolu yap
            emptyTransform.GetComponent<TransformState>().isOccupied = true;

            //eski transformu bos yap ve yeni transform olarak guncelle
            currentTransform.GetComponent<TransformState>().isOccupied = false;
            currentTransform = emptyTransform;

        }
    }
    Transform FindEmptyTransform(Transform[] transforms)//bos slot bulucu
    {
        foreach (Transform t in transforms)
        {
            TransformState state = t.GetComponent<TransformState>();
            if (state != null && !state.isOccupied)
            {
                return t;
            }
        }
        return null;
    }
}
