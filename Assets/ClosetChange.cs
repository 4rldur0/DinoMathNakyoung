using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetChange : MonoBehaviour
{
    public GameObject HatPanel, ClothesPanel, AccessoryPanel;

    public void ShowHats()
    {
        HatPanel.SetActive(true);
        ClothesPanel.SetActive(false);
        AccessoryPanel.SetActive(false);
    }
    public void ShowClothes()
    {
        HatPanel.SetActive(false);
        ClothesPanel.SetActive(true);
        AccessoryPanel.SetActive(false);
    }
    public void ShowAccessories()
    {
        HatPanel.SetActive(false);
        ClothesPanel.SetActive(false);
        AccessoryPanel.SetActive(true);
    }
}
