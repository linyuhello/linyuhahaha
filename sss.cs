using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class sss : MonoBehaviour
{
    List<int> lis = new List<int>();
    public Image img;

    public Image ima1;
    public Image ima2;
    // Start is called before the first frame update
    void Start()
    {
        lis.Add(0);
        lis.Add(0);
        lis.Add(0);
        lis.Add(0);
        lis.Add(0);
        lis.Add(0);
        lis.Add(0);
        lis.Add(0);
        //Debug.Log(lis.Capacity);
        //Debug.Log(lis.Count);


        //º”‘ÿÕººØ
        SpriteAtlas atlas = AssetDatabase.LoadAssetAtPath<SpriteAtlas>("Assets/Atlas/MyAtlas.spriteatlas");
        Debug.Log(Application.dataPath + "/Atlas/MyAtlas.spriteatlas");
        img.sprite = atlas.GetSprite("1001");

        ima1.sprite = atlas.GetSprite("1002");
        ima2.sprite = atlas.GetSprite("5001");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
