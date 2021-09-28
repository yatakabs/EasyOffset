using HarmonyLib;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.XR;

namespace EasyOffset.HarmonyPatches {
    [HarmonyPatch(typeof(OculusVRHelper))]
    [HarmonyPatch("AdjustControllerTransform")]
    internal class OculusVRHelperAdjustControllerTransform {
        [UsedImplicitly]
        private static bool Prefix(
            XRNode node,
            Transform transform,
            Vector3 position,
            Vector3 rotation
        ) {
            TransformUtils.AdjustControllerTransformOculus(node, transform);
            return false;
        }
    }
}