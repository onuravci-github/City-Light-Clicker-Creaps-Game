using UnityEngine;

public class Clicker : MonoBehaviour
{
    public static float [] ClickerPower = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
    
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnMouseDown() {
        for (int i = 0; i < 30; i++)
        {
            PlayerSettings.setMainGold1(i,PlayerSettings.getMainGold1(i) + ClickerPower[i]);
            Battary.nowBattaryValue[i] +=  ClickerPower[i];
        }
        PlayerSettings.setClickNumb(PlayerSettings.getClickNumb() + 1);
    }
}
