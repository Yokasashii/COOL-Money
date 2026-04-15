using UnityEngine;
using TMPro; 

public class UpdateMoney : MonoBehaviour 
{
    public TMP_Text moneyText; 
    public TMP_Text priceUp1Text;
    public TMP_Text priceUp2Text;
    public TMP_Text priceUp3Text;
    
    private int money;
    private int multi;

    private int up1 = 1;
    private int up2 = 0;
    private int up3 = 1;

    private int price_up1 = 10;
    private int price_up2 = 50;
    private int price_up3 = 200;
    
    void Start()
    {
        UpdateUI();
    }
    
    void Update()
    {
    }
    
    public void AddMoney()
    {
        multi = up1 + up2 * up3;
        money = money + multi;
        moneyText.text = money + " c";
    }
    
    public void Upgrade_1()
    {
        if (money >= price_up1) 
        {
            money = money - price_up1;
            price_up1 = price_up1 + 5;
            up1 = up1 + 1;
            UpdateUI();
        }
    }
    
    public void Upgrade_2()
    {
        if (money >= price_up2)
        {
            money = money - price_up2;
            price_up2 = price_up2 + 15;
            up2 = up2 + 2;
            UpdateUI();
        }
    }
    
    public void Upgrade_3()
    {
        if (money >= price_up3)
        {
            money = money - price_up3;
            price_up3 = price_up3 + 100;
            up3 = up3 * 2;
            UpdateUI();
        }
    }

    public void Victory()
    {
        if (money >= 50000)
        {
            moneyText.text = "ESCAPED !!!";
        }
    }
    
    void UpdateUI()
    {
        moneyText.text = money + " c";
        priceUp1Text.text = "Prix: " + price_up1;
        priceUp2Text.text = "Prix: " + price_up2;
        priceUp3Text.text = "Prix: " + price_up3;
    }
}