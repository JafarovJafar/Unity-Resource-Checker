using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialDetails
{

    public Material material;

    public List<Renderer> FoundInRenderers=new List<Renderer>();
    public List<Graphic> FoundInGraphics=new List<Graphic>();
    public bool instance;
    public bool isgui;
    public bool isSky;

    public MaterialDetails()
    {
        instance = false;
        isgui = false;
        isSky = false;
    }
};