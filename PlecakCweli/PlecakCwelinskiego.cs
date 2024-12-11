using BepInEx;
using HarmonyLib;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;

namespace PlecakCweli
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    //[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class PlecakCwelinskiego : BaseUnityPlugin
    {
        public const string PluginGUID = "pl.zienti.cwelinskiPlecak";
        public const string PluginName = "PlecakDlaCweli";
        public const string PluginVersion = "0.0.1";
        
        // Use this class to add your own localization to the game
        // https://valheim-modding.github.io/Jotunn/tutorials/localization.html
        public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

        private void Awake()
        {
            Jotunn.Logger.LogInfo("Plecak Cweli Załadowany!");
            var harmony = new Harmony(PluginGUID);
            harmony.PatchAll();
            
        }
        
        [HarmonyPatch(typeof(Player))]
        [HarmonyPatch("GetMaxCarryWeight")]
        public class MaxCarryWeightPatch
        {
            [HarmonyPostfix]
            private static void Postfix(ref float __result)
            {
                __result = 9999f;
            }
        }
    }
}