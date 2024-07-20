using Cysharp.Threading.Tasks;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

namespace App.Framework
{
    public class SceneLoader : MonoBehaviour
    {
        // 呼び出すシーンのパス配列
        [SerializeField] private string[] ScenePaths;

        // 始まったら登録したシーンを呼び出す
        private async UniTaskVoid Start()
        {
            foreach (var scenePath in ScenePaths)
            {
                // シーンを重ねて表示する
                await SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Additive);
            }

            // 最後のシーンをアクティブのシーンとする
            var lastScene = SceneManager.GetSceneByPath(ScenePaths.Last());
            SceneManager.SetActiveScene(lastScene);
        }

        /// <summary>
        /// インスペクタ上でシーンを開けるようにする
        /// </summary>
        [ContextMenu(nameof(OpenAllScenes))]
        private void OpenAllScenes()
        {
            foreach (var scenePath in ScenePaths)
            {
                EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Additive);
            }
        }

        [ContextMenu(nameof(RemoveAllOpenedScenes))]
        private void RemoveAllOpenedScenes()
        {
            foreach (var scenePath in ScenePaths)
            {
                var scene = SceneManager.GetSceneByPath(scenePath);
                EditorSceneManager.CloseScene(scene, true);
            }
        }
    }
}
