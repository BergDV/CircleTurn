using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopAssist : MonoBehaviour
{ 
 public int money;
public Text moneyText;
    public Text buyText;
    public bool isMulti;
    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
    }
    private void Update()
    {
        moneyText.text = money.ToString();
    }

    public void BuyMulti()
    {
        isMulti = PlayerPrefs.GetInt("isMulti") == 1 ? true : false;
        if (money >= 10 && isMulti == false)
        {
            isMulti = true;
            money -= 10;
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("isMulti", isMulti ? 1 : 0);          
        }
        else
            buyText.text = "Куплено";        
    }
    public void ExitShop()
    {
        SceneManager.LoadScene(0);
    }

}
