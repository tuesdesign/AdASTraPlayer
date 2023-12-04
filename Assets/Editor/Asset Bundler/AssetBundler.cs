using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Linq;
using UnityEditor.SceneManagement;
public class AssetBundler
{
    [MenuItem("File/Export AIMFAR Asset Bundle (scene build)")]
    static void BuildSceneAssetBundle()
    {
        // Get the currently active scene
        SceneAsset scene = Selection.activeObject as SceneAsset;

        if (scene == null)
        {
            Debug.LogError("You didn't click on a scene file! Do that first!");
            return;
        }

        // Save the current scene
        string currentScenePath = EditorSceneManager.GetActiveScene().path;
        EditorSceneManager.SaveOpenScenes();

        // Open the selected scene
        EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(scene), OpenSceneMode.Single);

        // Find all objects in the scene and create prefabs
        GameObject[] rootObjects = GameObject.FindObjectsOfType<GameObject>();
        foreach (var obj in rootObjects)
        {
            PrefabUtility.SaveAsPrefabAsset(obj, "Assets/Temp/" + obj.name + ".prefab");
        }

        // Build the AssetBundle
        BuildPipeline.BuildAssetBundles("Assets/AIMFAR_OUT", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);

        // Restore the original scene
        EditorSceneManager.OpenScene(currentScenePath, OpenSceneMode.Single);
    }
}