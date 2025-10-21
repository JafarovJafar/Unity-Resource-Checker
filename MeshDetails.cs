using System.Collections.Generic;
using UnityEngine;

public class MeshDetails
{

    public Mesh mesh;

    public List<MeshFilter> FoundInMeshFilters=new List<MeshFilter>();
    public List<SkinnedMeshRenderer> FoundInSkinnedMeshRenderer=new List<SkinnedMeshRenderer>();
    public List<GameObject> StaticBatchingEnabled =new List<GameObject>();
    public bool instance;

    public MeshDetails()
    {
        instance = false;
    }
};