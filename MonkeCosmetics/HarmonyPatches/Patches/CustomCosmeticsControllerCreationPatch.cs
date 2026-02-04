using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace MonkeCosmetics.HarmonyPatches.Patches
{
	[HarmonyPatch(typeof(VRRig))]
	[HarmonyPatch("Start", MethodType.Normal)]
	internal class CustomCosmeticsControllerCreationPatch
	{
		internal static void Postfix(VRRig __instance)
		{
			Photon.Realtime.Player player = __instance.photonView?.Owner;

			Plugin.Log($"MonkeCosmetics: Creating CustomCosmeticsController for {player?.NickName ?? "SELF"}");
			__instance.gameObject.AddComponent<CustomCosmeticsController>();
		}
	}
}
