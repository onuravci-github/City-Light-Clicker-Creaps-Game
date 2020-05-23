using UnityEngine;

public class UnitInfoSprite : MonoBehaviour
{
    public Sprite [] sprites;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[UnitInfoBarText.UnitNumber];
    }
    
    void Update()
    {
       spriteRenderer.sprite = sprites[UnitInfoBarText.UnitNumber];
    }

}
