using UnityEngine;
using UnityEngine.UI;
public class UnitsTextColor : MonoBehaviour
{
    public Color [] colors;
    private Text text;
    private int unitnumber;
    private int unitlevel;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
        unitnumber = this.GetComponentInParent<UnitProperty>().unitnumber;
        unitlevel = PlayerSettings.getMap1UnitLevel(unitnumber);
    }

    // Update is called once per frame
    void Update()
    {
        unitlevel = PlayerSettings.getMap1UnitLevel(unitnumber);
        if (unitlevel < 25)        {text.color = colors[0];}
        else if (unitlevel < 50)   {text.color = colors[1];}
        else if (unitlevel < 75)   {text.color = colors[2];}
        else if (unitlevel < 100)  {text.color = colors[3];}
        else if (unitlevel < 125)  {text.color = colors[4];}
        else if (unitlevel < 150)  {text.color = colors[5];}
        else if (unitlevel < 200)  {text.color = colors[6];}
        else {text.color = colors[7];}
    }
}
