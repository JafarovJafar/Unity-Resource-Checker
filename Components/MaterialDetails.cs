using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace handcircus.ResourceCheck
{
    internal class MaterialDetails
    {
        public Material material;

        public List<Renderer> FoundInRenderers = new List<Renderer>();
        public List<Graphic> FoundInGraphics = new List<Graphic>();
        public bool instance = false;
        public bool isgui = false;
        public bool isSky = false;
    }
}