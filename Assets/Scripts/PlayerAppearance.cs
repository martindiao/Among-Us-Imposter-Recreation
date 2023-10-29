using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAppearance : MonoBehaviour
{
    Material player_mat;

    public Color color_r;
    public Color color_g = new Color(0.6274509804f, 0.9882352941f, 1.0f);
    public Color color_b;

    // Start is called before the first frame update
    void Start()
    {
        player_mat = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        player_mat.SetColor("_Color_r", color_r);
        player_mat.SetColor("_Color_g", color_g);
        player_mat.SetColor("_Color_b", color_b);
    }
}
