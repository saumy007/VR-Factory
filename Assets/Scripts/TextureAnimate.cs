using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureAnimate : MonoBehaviour
{
    public float scrollX;
    public float scrollY;
    public Material ConveyorMaterial;
        
    void Update() {

        float offsetx =Time.time * scrollX;
        float offsety = Time.time * scrollY;

        ConveyorMaterial.mainTextureOffset = new Vector2(offsetx, offsety);
            }
}
