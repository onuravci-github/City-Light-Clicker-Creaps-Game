using UnityEngine;
using UnityEngine.UI;

public class UnitBuyXText : MonoBehaviour
{

    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UnitBuyX.BuyX == 0){
            text.text = "Buy x1";
        }
        else if (UnitBuyX.BuyX == 1){
            text.text = "Buy x5";
        }
        else if (UnitBuyX.BuyX == 1){
            text.text = "Buy x10";
        }
        
    }
}
