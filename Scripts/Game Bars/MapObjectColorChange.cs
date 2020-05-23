using UnityEngine;

public class MapObjectColorChange : MonoBehaviour
{
    public int colornumber;

    // Mouse Down Map Object Set Colors
    private static Color [] Colors ; 
    // Start is called before the first frame update
    void Start()
    {
        if(colornumber < MapObjectSprite.mapobjectColorNumber){
            this.GetComponent<Transform>().localScale = new Vector3(0f,0f,0f);
        }
        this.GetComponent<SpriteRenderer>().color = Colors[colornumber];
    }
 
    void OnMouseDown()
    {
        PlayerSettings.setMap1ObjectValue(MapObjectSprite.mapobjectCreateNumber,colornumber);
    }
}
