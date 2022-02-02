using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using System;
using HarmonyLib;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnhollowerBaseLib;
using TownOfHost;

namespace TownOfHost
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    class HudManagerPatch
    {
        public static void Postfix(HudManager __instance)
        {
            var TaskTextPrefix = "";
            var FakeTasksText = DestroyableSingleton<TranslationController>.Instance.GetString(StringNames.FakeTasks, new Il2CppReferenceArray<Il2CppSystem.Object>(0));
            //壁抜け
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                if (AmongUsClient.Instance.GameState != InnerNet.InnerNetClient.GameStates.Started ||
                AmongUsClient.Instance.GameMode == GameModes.FreePlay)
                {
                    PlayerControl.LocalPlayer.Collider.offset = new Vector2(0f, 127f);
                }
            }
            //壁抜け解除
            if(PlayerControl.LocalPlayer.Collider.offset.y == 127f) {
                if(!Input.GetKey(KeyCode.LeftControl) || AmongUsClient.Instance.IsGameStarted) {
                    PlayerControl.LocalPlayer.Collider.offset = new Vector2(0f,-0.3636f);
                }
            }
            //Madmate
            if (PlayerControl.LocalPlayer.getCustomRole() == CustomRoles.Madmate)
            {
                TaskTextPrefix = "<color=#ff0000>" + main.getRoleName(CustomRoles.Madmate) + "</color>\r\n" +
                "<color=#ff0000>" + main.getLang(lang.MadmateInfo) + "</color>\r\n";
                TaskTextPrefix += FakeTasksText;
            }
            //MadGuardian
            if (PlayerControl.LocalPlayer.getCustomRole() == CustomRoles.MadGuardian)
            {
                TaskTextPrefix = "<color=#ff0000>" + main.getRoleName(CustomRoles.Madmate) + "</color>\r\n" +
                "<color=#ff0000>" + main.getLang(lang.MadGuardianInfo) + "</color>\r\n";
                TaskTextPrefix += FakeTasksText;
            }
            //Jester
            if (PlayerControl.LocalPlayer.getCustomRole() == CustomRoles.Jester)
            {
                TaskTextPrefix = "<color=#d161a4>" + main.getRoleName(CustomRoles.Jester) + "</color>\r\n" +
                "<color=#d161a4>" + main.getLang(lang.JesterInfo) + "</color>\r\n";
                TaskTextPrefix += FakeTasksText;
            }
            //Bait
            if (PlayerControl.LocalPlayer.getCustomRole() == CustomRoles.Bait)
            {
                TaskTextPrefix = "<color=#00bfff>" + main.getRoleName(CustomRoles.Bait) + "</color>\r\n" +
                "<color=#00bfff>" + main.getLang(lang.BaitInfo) + "</color>\r\n";
            }
            //Terrorist
            if (PlayerControl.LocalPlayer.getCustomRole() == CustomRoles.Terrorist)
            {
                TaskTextPrefix = "<color=#00ff00>" + main.getRoleName(CustomRoles.Terrorist) + "</color>\r\n" +
                "<color=#00ff00>" + main.getLang(lang.TerroristInfo) + "</color>\r\n";
            }
            //Sidekick
            if (PlayerControl.LocalPlayer.getCustomRole() == CustomRoles.Sidekick)
            {
                var ImpostorCount = 0;
                foreach (var pc in PlayerControl.AllPlayerControls)
                {
                    if (pc.Data.Role.Role == RoleTypes.Impostor &&
                       !pc.Data.IsDead) ImpostorCount++;
                }
                if (ImpostorCount > 0)
                {
                    TaskTextPrefix = "<color=#ff0000>" + main.getRoleName(CustomRoles.Sidekick) + "</color>\r\n" +
                    "<color=#ff0000>" + main.getLang(lang.BeforeSidekickInfo) + "</color>\r\n";
                }
                else
                {
                    TaskTextPrefix = "<color=#ff0000>" + main.getRoleName(CustomRoles.Sidekick) + "</color>\r\n" +
                    "<color=#ff0000>" + main.getLang(lang.AfterSidekickInfo) + "</color>\r\n";
                }
            }
            //Vampire
            if (main.isVampire(PlayerControl.LocalPlayer))
            {
                TaskTextPrefix = "<color=#a557a5>" + main.getRoleName(CustomRoles.Vampire) + "</color>\r\n" +
                "<color=#a557a5>" + main.getLang(lang.VampireInfo) + "</color>\r\n";
            }
            //SabotageMaster
            if (main.isSabotageMaster(PlayerControl.LocalPlayer))
            {
                TaskTextPrefix = "<color=#0000ff>" + main.getRoleName(CustomRoles.SabotageMaster) + "</color>\r\n" +
                "<color=#0000ff>" + main.getLang(lang.SabotageMasterInfo) + "</color>\r\n";
            }
            //Mayor
            if (main.isMayor(PlayerControl.LocalPlayer))
            {
                TaskTextPrefix = "<color=#ff00ff>" + main.getRoleName(CustomRoles.Mayor) + "</color>\r\n" +
                "<color=#ff00ff>" + main.getLang(lang.MayorInfo) + "</color>\r\n";
            }
            //Opportunist
            if (main.isOpportunist(PlayerControl.LocalPlayer))
            {
                TaskTextPrefix = "<color=#00ff00>" + main.getRoleName(CustomRoles.Opportunist) + "</color>\r\n" +
                "<color=#00ff00>" + main.getLang(lang.OpportunistInfo) + "</color>\r\n";
            }
            //Sheriff
            if (main.isSheriff(PlayerControl.LocalPlayer))
            {
                TaskTextPrefix = "<color=#ffff00>" + main.getRoleName(CustomRoles.Sheriff) + "</color>\r\n" +
                "<color=#ffff00>" + main.getLang(lang.SheriffInfo) + "</color>\r\n";
                if(PlayerControl.LocalPlayer.Data.Role.Role != RoleTypes.GuardianAngel) {
                    PlayerControl.LocalPlayer.Data.Role.CanUseKillButton = true;
                    __instance.KillButton.enabled = true;
                    __instance.KillButton.Show();
                } else {
                    PlayerControl.LocalPlayer.Data.Role.CanUseKillButton = false;
                    __instance.KillButton.enabled = false;
                    __instance.KillButton.Hide();
                }
            }

            if (!__instance.TaskText.text.Contains(TaskTextPrefix))
            {
                __instance.TaskText.text = TaskTextPrefix + "\r\n" + __instance.TaskText.text;
            }

            if (main.OptionControllerIsEnable)
            {
                __instance.GameSettings.text = CustomOptionController.GetOptionText();
                __instance.GameSettings.fontSizeMin = 2f;
                __instance.GameSettings.fontSizeMax = 2f;
                __instance.GameSettings.m_maxHeight = 0.5f;
            } else {
                __instance.GameSettings.fontSizeMin = 1.3f;
                __instance.GameSettings.fontSizeMax = 1.3f;
            }

            if(Input.GetKeyDown(KeyCode.Y) && AmongUsClient.Instance.GameMode == GameModes.FreePlay) {
                Action<MapBehaviour> tmpAction = (MapBehaviour m) => { m.ShowSabotageMap(); };
                __instance.ShowMap(tmpAction);
                if (PlayerControl.LocalPlayer.AmOwner) {
                    PlayerControl.LocalPlayer.MyPhysics.inputHandler.enabled = true;
                    ConsoleJoystick.SetMode_Task();
                }
            }

            if(AmongUsClient.Instance.GameMode == GameModes.OnlineGame) RepairSender.enabled = false;
            if(Input.GetKeyDown(KeyCode.RightShift) && AmongUsClient.Instance.GameMode != GameModes.OnlineGame) {
                RepairSender.enabled = !RepairSender.enabled;
                RepairSender.Reset();
            }
            if(RepairSender.enabled && AmongUsClient.Instance.GameMode != GameModes.OnlineGame) {
                if(Input.GetKeyDown(KeyCode.Alpha0)) RepairSender.Input(0);
                if(Input.GetKeyDown(KeyCode.Alpha1)) RepairSender.Input(1);
                if(Input.GetKeyDown(KeyCode.Alpha2)) RepairSender.Input(2);
                if(Input.GetKeyDown(KeyCode.Alpha3)) RepairSender.Input(3);
                if(Input.GetKeyDown(KeyCode.Alpha4)) RepairSender.Input(4);
                if(Input.GetKeyDown(KeyCode.Alpha5)) RepairSender.Input(5);
                if(Input.GetKeyDown(KeyCode.Alpha6)) RepairSender.Input(6);
                if(Input.GetKeyDown(KeyCode.Alpha7)) RepairSender.Input(7);
                if(Input.GetKeyDown(KeyCode.Alpha8)) RepairSender.Input(8);
                if(Input.GetKeyDown(KeyCode.Alpha9)) RepairSender.Input(9);
                if(Input.GetKeyDown(KeyCode.Return)) RepairSender.InputEnter();
                __instance.TaskText.text = RepairSender.getText();
            }
        }
    }
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.ToggleHighlight))]
    class ToggleHighlightPatch {
        public static void Postfix(PlayerControl __instance, [HarmonyArgument(0)] bool active, [HarmonyArgument(1)] RoleTeamTypes team) {
            if(PlayerControl.LocalPlayer.getCustomRole() == CustomRoles.Sheriff) {
                ((Renderer) __instance.myRend).material.SetColor("_OutlineColor", Color.yellow);
            }
        }
    }
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.FindClosestTarget))]
    class FindClosestTargetPatch {
        public static void Prefix(PlayerControl __instance, [HarmonyArgument(0)] ref bool protecting) {
            if(PlayerControl.LocalPlayer.getCustomRole() == CustomRoles.Sheriff && 
            __instance.Data.Role.Role != RoleTypes.GuardianAngel) {
                protecting = true;
            }
        }
    }
    class RepairSender {
        public static bool enabled = false;
        public static bool TypingAmount = false;

        public static int SystemType;
        public static int amount;

        public static void Input(int num) {
            if(!TypingAmount) {
                //SystemType入力中
                SystemType = SystemType * 10;
                SystemType += num;
            } else {
                //Amount入力中
                amount = amount * 10;
                amount += num;
            }
        }
        public static void InputEnter() {
            if(!TypingAmount) {
                //SystemType入力中
                TypingAmount = true;
            } else {
                //Amount入力中
                send();
            }
        }
        public static void send() {
            ShipStatus.Instance.RpcRepairSystem((SystemTypes)SystemType, amount);
            Reset();
        }
        public static void Reset() {
            TypingAmount = false;
            SystemType = 0;
            amount = 0;
        }
        public static string getText() {
            return SystemType.ToString() + "(" + ((SystemTypes)SystemType).ToString() + ")\r\n" + amount;
        }
    }
}
