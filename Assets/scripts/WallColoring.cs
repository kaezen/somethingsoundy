using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColoring : MonoBehaviour {

    Material thisMat;
    float emission;
    float decayRate = 1;
    public bool _Glowing = false;
    Color baseColor;
    Color finalColor;

	// Use this for initialization
	void Start () {
        thisMat = GetComponent<Material>();

       // Glow();
    }
	
	// Update is called once per frame
	void Update () {
        if (_Glowing)
        {
            emission -= Time.deltaTime * decayRate;

            finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

            thisMat.SetColor("_EmissionColor", finalColor);
            print(emission);
            if (emission < 0) StopGlow();
        }
	}

    public void StopGlow()
    {
        _Glowing = false;

        thisMat.SetColor("_EmissionColor", Color.black);
        
    }

    public void Glow()
    {
        Renderer renderer = GetComponent<Renderer>();
       thisMat = renderer.material;

        _Glowing = true;

        emission = 1.5f;
        baseColor = Color.blue; //Replace this with whatever you want for your base color at emission level '1'

       
    }
}
