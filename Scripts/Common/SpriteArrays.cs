using UnityEngine;

public class SpriteArrays : MonoBehaviour
{
    public Sprite [] sprites;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = sprites[0];
    }

}
