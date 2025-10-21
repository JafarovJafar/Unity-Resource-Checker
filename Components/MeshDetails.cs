using System.Collections.Generic;
using UnityEngine;

namespace handcircus.ResourceCheck
{
    public class MeshDetails
    {
        public Mesh mesh;

        public List<MeshFilter> FoundInMeshFilters = new List<MeshFilter>();
        public List<SkinnedMeshRenderer> FoundInSkinnedMeshRenderer = new List<SkinnedMeshRenderer>();
        public List<GameObject> StaticBatchingEnabled = new List<GameObject>();
        public bool instance = false;
    }
}