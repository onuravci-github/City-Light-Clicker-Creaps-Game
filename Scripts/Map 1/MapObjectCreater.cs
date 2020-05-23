using UnityEngine;

public class MapObjectCreater : MonoBehaviour
{
    private int levelmap;
    private int activemap;
    public Object[] mapobject;
    public int objectValue;
    
    // Start is called before the first frame update
    void Start()
    {
        activemap = PlayerSettings.getActiveMap();
        levelmap = PlayerSettings.getLevelMap(activemap);
    }

    public void Create(){
        if(objectValue >= levelmap){
            GameObject myPrf = Instantiate(mapobject[PlayerSettings.getMap1ObjectNumber(objectValue-1)], this.transform.position,Quaternion.identity)as GameObject;
            myPrf.transform.parent = transform;
            
            myPrf.transform.localScale = new Vector3(myPrf.transform.localScale.x*this.transform.localScale.x,myPrf.transform.localScale.y*this.transform.localScale.y);
            myPrf.transform.localPosition = new Vector3(0f,0f,-25f);
        }
    }

    public void LevelCreate(){
        Instantiate(mapobject[PlayerSettings.getMap1ObjectNumber(objectValue)], this.transform.position,Quaternion.identity);
    }

    public void CreateChange(){
        foreach (Transform child in transform) {
            GameObject.Destroy(child.gameObject);
        }
        Instantiate(mapobject[PlayerSettings.getMap1ObjectNumber(objectValue)], this.transform.position,Quaternion.identity);
    }
}