using System.Collections;
using UnityEngine;

public class MapObjectCreaterControl : MonoBehaviour
{
    private int levelmap;
    private int activemap;
    public MapObjectCreater [] mapObjects;
    // Start is called before the first frame update
    void Start()
    {
        activemap = PlayerSettings.getActiveMap();
        levelmap = PlayerSettings.getLevelMap(activemap);
        mapObjects = FindObjectsOfType<MapObjectCreater>();

        //StartCoroutine(Create());
    }
    
    public void Create(){
        levelmap = PlayerSettings.getLevelMap(activemap);
        mapObjects[levelmap].Create();
    }
    
    IEnumerator Create1(){
       /* foreach (var item in mapObjects)
        {
            item.Create();
            yield return new WaitForSeconds(100f);
        }*/
        yield return null;
    }
 
}
