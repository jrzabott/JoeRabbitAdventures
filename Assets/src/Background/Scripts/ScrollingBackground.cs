using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    
    public float additionalScrollSpeed;
    
    public GameObject[] backgrounds;
    
    public float[] scrollSpeeds;
    
    private void FixedUpdate()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            // access the renderer component of the current background
            Renderer renderer = backgrounds[i].GetComponent<Renderer>();
            
            // calculate the offset based on the current time and the scroll speed
            float offset = Time.time * (scrollSpeeds[i] + additionalScrollSpeed);
            
            // set the offset of the texture, offset means how much the texture is shifted to the right
            renderer.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
         }
    }
}
