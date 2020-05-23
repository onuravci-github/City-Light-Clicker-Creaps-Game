using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    private int unitnumber;
    public int unitlevel;
    public int unitextrapower;
    public int unitfunction;
    public Sprite [] sprites;

    private static Color color1 = new Color(1f,1f,1f,1f);
    private static Color color2 = new Color(1f,1f,1f,0.5f);

    private Image img;

    // Start is called before the first frame update
    void Start()
    {
        unitnumber = this.GetComponentInParent<UnitProperty>().unitnumber;
        img = this.GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        unitlevel = PlayerSettings.getMap1UnitLevel(unitnumber);

        if (unitfunction == 0){
            if (unitlevel < 25)      {img.sprite = sprites[0];}
            else if (unitlevel < 50) {img.sprite = sprites[1];}
            else if (unitlevel < 75) {img.sprite = sprites[2];}
            else if (unitlevel < 100){img.sprite = sprites[3];}
            else if (unitlevel < 125){img.sprite = sprites[4];}
            else if (unitlevel < 150){img.sprite = sprites[5];}
            else if (unitlevel < 200){img.sprite = sprites[6];}
            else {img.sprite = sprites[7];} 
        }
        else if (unitfunction == 1){
            if(unitextrapower == 0 && unitlevel > 0)         {img.color = color1;}
            else if (unitextrapower == 1 && unitlevel >24)   {img.color = color1;}
            else if (unitextrapower == 2 && unitlevel >49)   {img.color = color1;}
            else if (unitextrapower == 3 && unitlevel >74)   {img.color = color1;}
            else if (unitextrapower == 4 && unitlevel >99)   {img.color = color1;}
            else if (unitextrapower == 5 && unitlevel >124)  {img.color = color1;}
            else if (unitextrapower == 6 && unitlevel >149)  {img.color = color1;}
            else if (unitextrapower == 7 && unitlevel >199)  {img.color = color1;}
            else {img.color = color2;}
        }
    }
}
