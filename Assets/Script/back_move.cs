using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back_move : MonoBehaviour
{
    Vector2 vec;
    MeshRenderer mesh;
    [SerializeField]
    float speed;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }


    void Update()
    {
        vec.x +=Time.deltaTime*speed;

        mesh.material.SetTextureOffset("_MainTex", vec);
    }
}
