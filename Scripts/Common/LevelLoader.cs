using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    public GameObject loadObject;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        //AsyncOperation operation = SceneManager.LoadSceneAsync(1);
        
        //SceneManager.LoadSceneAsync(operation,);
        //StartCoroutine(LoadAsynchronously());    
    }
    
    void StartLoadScene(){
        StartCoroutine(LoadAsynchronously1());    
    }


    IEnumerator LoadAsynchronously1(){
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);
        yield return new WaitForSeconds(2);
        //loadObject.SetActive(true);
        yield return null;        /*while(!operation.isDone){
            float progress = Mathf.Clamp01(operation.progress / .9f);

            //slider.value = progress;
            
        }*/
       // yield return null;
    }

}
