using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapObjectSprite : MonoBehaviour
{
    public Sprite [] sprite0;
    public Sprite [] sprite1;
    public Sprite [] sprite2;
    public Sprite [] sprite3;
    public Sprite [] sprite4;

    // Mouse Down Map Object Set Number
    public static int mapobjectnumber; // Her Bir Türün Bakması gererken sprite
    public static int mapobjectColorNumber; // Tıklanılan objenin renk sayısı
    public static int mapobjectCreateNumber; // Değiştirilicek mapdeki objenin numarası
    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<SpriteRenderer>().sprite = sprites[PlayerSettings.getMap1ObjectValue];
        if (mapobjectnumber == 0){
            this.GetComponent<SpriteRenderer>().sprite = sprite0[PlayerSettings.getMap1ObjectValue(MapObjectSprite.mapobjectCreateNumber)];
        }
        else if (mapobjectnumber == 1){
            this.GetComponent<SpriteRenderer>().sprite = sprite1[PlayerSettings.getMap1ObjectValue(MapObjectSprite.mapobjectCreateNumber)];
        }
        else if (mapobjectnumber == 2){
            this.GetComponent<SpriteRenderer>().sprite = sprite2[PlayerSettings.getMap1ObjectValue(MapObjectSprite.mapobjectCreateNumber)];
        } 
        else if (mapobjectnumber == 3){
            this.GetComponent<SpriteRenderer>().sprite = sprite3[PlayerSettings.getMap1ObjectValue(MapObjectSprite.mapobjectCreateNumber)];
        }
        else if (mapobjectnumber == 4){
            this.GetComponent<SpriteRenderer>().sprite = sprite4[PlayerSettings.getMap1ObjectValue(MapObjectSprite.mapobjectCreateNumber)];
        }
    
    }
    void Update() {
        if (mapobjectnumber == 0){
            this.GetComponent<SpriteRenderer>().sprite = sprite0[PlayerSettings.getMap1ObjectValue(MapObjectSprite.mapobjectCreateNumber)];
        }
        else if (mapobjectnumber == 1){
            this.GetComponent<SpriteRenderer>().sprite = sprite1[PlayerSettings.getMap1ObjectValue(MapObjectSprite.mapobjectCreateNumber)];
        }
        else if (mapobjectnumber == 2){
            this.GetComponent<SpriteRenderer>().sprite = sprite2[PlayerSettings.getMap1ObjectValue(MapObjectSprite.mapobjectCreateNumber)];
        } 
        else if (mapobjectnumber == 3){
            this.GetComponent<SpriteRenderer>().sprite = sprite3[PlayerSettings.getMap1ObjectValue(MapObjectSprite.mapobjectCreateNumber)];
        }
        else if (mapobjectnumber == 4){
            this.GetComponent<SpriteRenderer>().sprite = sprite4[PlayerSettings.getMap1ObjectValue(MapObjectSprite.mapobjectCreateNumber)];
        }
    }
}
