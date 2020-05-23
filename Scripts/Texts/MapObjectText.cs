using UnityEngine;
using UnityEngine.UI;

public class MapObjectText : MonoBehaviour
{
    private Text mapobjecttext;

    private static string [] ObjectName = {"House","Basic House","Car","WareHouse"};
    // Start is called before the first frame update
    void Start()
    {
        mapobjecttext = this.GetComponent<Text>();
        mapobjecttext.text = ObjectName[MapObjectSprite.mapobjectnumber];
    }

}
