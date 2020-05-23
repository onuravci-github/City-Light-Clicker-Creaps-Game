using UnityEngine;
using UnityEngine.UI;

public class LevelBarText : MonoBehaviour
{
  public Text levelbartext;
  
  public int barposition; // 5 Bar is Value -2 / -1 / 0 / 1 / 2 
  

  private void Start() {
    levelbartext = this.GetComponent<Text>();
    
  }

  public void NextLevelUpdate(int level){
    if(level + barposition <=0){
      levelbartext.text = 0.ToString();
    }
    else
      levelbartext.text = (level+barposition).ToString();
  }
}
