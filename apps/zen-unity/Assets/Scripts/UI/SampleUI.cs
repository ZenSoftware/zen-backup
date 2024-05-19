using UnityEngine;
using UnityEngine.UIElements;

namespace Zen
{
    public class SampleUI : MonoBehaviour
    {
        public string ScenePath;

        void OnEnable()
        {
            var root = GetComponent<UIDocument>().rootVisualElement;
            var buttonSample = root.Q<Button>("ButtonSample");
            buttonSample.clicked += () =>
            {
                SceneManager.LoadSceneSingle(ScenePath);
            };
        }
    }
}

