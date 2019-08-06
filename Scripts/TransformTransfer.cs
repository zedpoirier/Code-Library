// Author: Zed Poirier
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// In combination with a custom editor. This script will take an array of gameobjects and copy 
/// their position and rotation data into the respective arrays. That can be used to copy the data
/// back into the target objects. The goal is to move the objects in the world using the physics 
/// system and then save the trasnform data to copy it back into the objects outside of play mode.
/// 
/// Process:
/// 1. Add physics components to objects and reference the objects in the targetObjects array.
/// 2. Play. Let the physics run.
/// 3. When done. Click the Save Transform GUI button.
/// 4. Copy this component.
/// 5. Exit playmode.
/// 6. Paste component values to this component.
/// 7. Click the Apply Transform GUI button.
/// 8. Remove the physics components from the game objects.
/// </summary>
[ExecuteInEditMode]
public class TransformTransfer : MonoBehaviour
{
    public Vector3[] positions;
    public Quaternion[] rotations;
    public GameObject[] targetObjects;

    // Save Transforms
    public void SaveTransforms() {
        positions = new Vector3[targetObjects.Length];
        rotations = new Quaternion[targetObjects.Length];
        for (int i = 0; i < targetObjects.Length; i++) {
            positions[i] = targetObjects[i].transform.position;
            rotations[i] = targetObjects[i].transform.rotation;
        }
    }

    // Apply Transforms
    public void ApplyTransforms() {
        for (int i = 0; i < targetObjects.Length; i++) {
            targetObjects[i].transform.SetPositionAndRotation(positions[i], rotations[i]);
        }
    }
}
