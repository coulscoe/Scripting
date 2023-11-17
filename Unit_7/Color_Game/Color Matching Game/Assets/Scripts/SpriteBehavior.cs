using UnityEngine; 

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj; 
    private void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>(); //allows for the control of sprite renderers
    }

    public void ChangeRenderColor(ColorID obj) //this function allows the color to be changed for any object
    {
        rendererObj.color = obj.value;
    }

    public void ChangeRendererColor(ColorIDDataList obj)
    {
        rendererObj.color = obj.currentColor.value;
    }
}
