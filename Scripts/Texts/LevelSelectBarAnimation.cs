using UnityEngine;

public class LevelSelectBarAnimation : MonoBehaviour
{
    public LevelBarText [] texts;
    
    // Start is called before the first frame update
    void Start()
    {
        texts = GetComponentsInChildren<LevelBarText>();

        // is 5 Level Bar Identified 
        while(texts.Length != 5 ){
            System.Array.Clear(texts,0,texts.Length);
            texts = GetComponentsInChildren<LevelBarText>();
        }

    }

    void NextLevel(){
        foreach (var text in texts)
        {
            //text.NextLevelUpdate();
        }
    }
}