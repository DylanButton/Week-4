//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
//
//public class FastIKFabric : MonoBehaviour
//{
//  public int ChainLength = 2;
//  public Transform TargetLocation;
//  public Transform Pole;
//void Awake(){
//    Init();
//}
//void Init(){
//    Bones = new Transform[ChainLength +1];
//    Positions = new Vector3[ChainLength +1];
//    BonesLength = new float [ChainLength];
//
//    completeLength = 0;
//
//    var current = transform;
//    for (int i = Bones.length - 1; i >= 0; i--)
//    {
//        Bones[i] = current;
//
//        if(i== Bones.length - 1){
//
//    }else{
//        BonesLength[i] = (Bones[i+1].position - current.position).magnitude;
//        CompleteLength += BonesLength[i];
//
//        
//    }
//    current = current.parent;
//
//
//    }
//}
//  void OnDrawGizmos()
//{
//    var current = this.transform;
//    for (int i = 0; i < ChainLength && current !=null && current.parent != null; i++){
//        var scale = Vector3.Distance(current.position, current.parent.position) * 0.1f;
//        Handles.matrix = Matrix4x4.TRS(current.position, Quaternion.FromToRotation(Vector3.up, current.parent.position - current.position), new Vector3(scale, Vector3.Distance(current.parent.position, current.position), scale));
//        Handles.color = Color.green;
//        Handles.DrawWireCube(Vector3.up * 0.5f, Vector3.one);
//        current = current.parent;
//
//    }
//
//
//        
//    }
//}
//
//
//