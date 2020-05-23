using UnityEngine;
using UnityEngine.UI;

public class UnitBuyX : MonoBehaviour
{
    public static int BuyX; // Public Buy Button X Change Number
    public int xnumb; // 0 : x1   1 : x5  2 : x10
    private UnitsText [] units;
    private Text text;
    Color color1 = new Color(0.2631137f,0.5660378f,0f,1f);
    Color color2 = new Color(0.2631137f,0.5660378f,0f,0.3f);
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
        if (BuyX == xnumb)  {text.color = color1;}
        else    {text.color = color2;}
        units = FindObjectsOfType<UnitsText>();
    }
    void Update()
    {
        if (BuyX == xnumb)  {text.color = color1;}
        else    {text.color = color2;}
    }
    public void BuyXChange(){

       

        if (BuyX == 0){
            BuyX = 1;
        }
        else if (BuyX == 1){
            BuyX = 2;
        }
        else{
            BuyX = 0;
        }
        
        foreach (var unit in units)
        {
            unit.UnitXUpdate();
        }
    }
}
