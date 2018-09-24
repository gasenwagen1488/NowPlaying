﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Management;

namespace NowPlaying
{
    class SteamidLooker
    {
        public static string SteamID64; //
<<<<<<< HEAD
        private static string ReadPath; //C:\Program Files (x86)\Steam\Steam.exe
        public static string SteamProcessPath()
        {
            foreach (Process PPath in Process.GetProcessesByName("steam"))
            {
                ReadPath = PPath.MainModule.FileName;
            }
=======
        private static string ReadPath; //
        public static string SteamProcessPath()
        {
            ReadPath = Process.GetProcessesByName("steam")[0].StartInfo.FileName;
>>>>>>> beb13fa2970aafae469dbb19885ec4d706036653
            return ReadPath;
        }
        public static void SteamCfgReader()
        {
            using (StreamReader sr = new StreamReader(ReadPath))
                sr.ReadToEnd();
        }
        public static string urlMaker()
        {
            string url = "http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={0}&steamids={1}";
            string.Format(url, AppInfo.SteamAPIKey, SteamID64);
            return url;
        }
    }
}