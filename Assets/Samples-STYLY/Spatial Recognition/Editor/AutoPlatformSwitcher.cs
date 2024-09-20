using UnityEditor;
using UnityEditor.Compilation;

namespace Styly.VisionOs
{
    [InitializeOnLoad]
    public static class AutoPlatformSwitcher
    {
        static AutoPlatformSwitcher()
        {
            EditorApplication.delayCall += DelayedInitialize;
        }

        private static void DelayedInitialize()
        {
            EditorApplication.delayCall -= DelayedInitialize;

            if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.VisionOS) return;
        
            if (!IsVisionOSModuleInstalled())
            {
                UnityEngine.Debug.LogError("VisionOS module is not installed, please install from Unity Hub.");
                return;
            }
            
            UnityEngine.Debug.Log("Switch platform to VisionOS.");

            var switchResult = EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.VisionOS, BuildTarget.VisionOS);

            if (switchResult)
            {
                CompilationPipeline.compilationFinished += OnCompilationFinished;
            }
            else
            {
                UnityEngine.Debug.LogError("Switch platform failed.");
            }
        }
        
        private static bool IsVisionOSModuleInstalled()
        {
            // BuildPipeline を使用してサポートを確認
            return BuildPipeline.IsBuildTargetSupported(BuildTargetGroup.VisionOS, BuildTarget.VisionOS);
        }
        private static void OnCompilationFinished(object obj)
        {
            CompilationPipeline.compilationFinished -= OnCompilationFinished;

            UnityEngine.Debug.Log("Recompilation of the script is complete.");
        }
    }
}
