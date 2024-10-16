using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ArmorAmount : MonoBehaviour
{
    [SerializeField] private Image armorImage;
    [SerializeField] private TextMeshProUGUI armorText;

    [SerializeField] private Sprite armorFullSprite;
    [SerializeField] private Sprite armorEmptySprite;

    private float currentArmor;
    private Spaceship spaceship;
    private void Start()
    {
        spaceship = FindObjectOfType<Spaceship>();
    }
    private void Update()
    {
        currentArmor = spaceship.GetArmor();
        armorImage.sprite = (currentArmor > 0) ? armorFullSprite : armorEmptySprite;
        armorText.text = Mathf.FloorToInt(currentArmor).ToString("D1");
    }
}
