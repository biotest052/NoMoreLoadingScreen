using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

using CapuchinTemplate.Patches;
using UnityEngine;
using BepInEx.Logging;
using Il2CppInterop.Runtime.Injection;

namespace NoMoreLoadingScreen
{
    [BepInPlugin(ModInfo.GUID, ModInfo.NAME, ModInfo.VERSION)]
    public class Init : BasePlugin
    {
        public Harmony harmonyInstance;
        public Plugin pluginInstance;
        public static Init initInstance;

        public override void Load()
        {
            harmonyInstance = HarmonyPatcher.Patch(ModInfo.GUID);
            initInstance = this;

            ClassInjector.RegisterTypeInIl2Cpp<Plugin>();
            pluginInstance = AddComponent<Plugin>();
        }

        public override bool Unload()
        {
            if (harmonyInstance != null)
                HarmonyPatcher.Unpatch(harmonyInstance);

            return true;
        }
    }
}
