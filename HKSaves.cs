using System.IO;
using System.Collections.Generic;

namespace HK_Multisave
{
    class HKSaves
    {
        public static List<string> ListLoadedSaves()
        {
            List<string> ValidSaves = new List<string>();

            foreach (string file in Directory.GetFiles(Settings.SavesPath))
            {
                if (file.EndsWith("user1.dat"))
                {
                    ValidSaves.Add($"Slot 1");
                }
                else if (file.EndsWith("user2.dat"))
                {
                    ValidSaves.Add($"Slot 2");
                }
                else if (file.EndsWith("user3.dat"))
                {
                    ValidSaves.Add($"Slot 3");
                }
                else if (file.EndsWith("user4.dat"))
                {
                    ValidSaves.Add($"Slot 4");
                }
            }

            return ValidSaves;
        }

        public static List<string> ListBackupSaves()
        {
            List<string> ValidSaves = new List<string>();

            foreach(string file in Directory.GetFiles(Settings.BackupSavesPath))
            {
                if (file.EndsWith(".dat"))
                {
                    ValidSaves.Add(file);
                }
            }

            return ValidSaves;
        }

        public static string SlotToFile(string slot)
        {
            switch (slot)
            {
                case "Slot 1":
                    return Settings.SavesPath + "/user1.dat";

                case "Slot 2":
                    return Settings.SavesPath + "/user2.dat";

                case "Slot 3":
                    return Settings.SavesPath + "/user3.dat";

                case "Slot 4":
                    return Settings.SavesPath + "/user4.dat";
            }

            return "Unknown";
        }

        public static bool ValidateString(string checkString)
        {
            string[] validChars = { "/", "\\", ":", "*", "?", "\"", "<", ">", "|"};

            foreach (string charStr in validChars)
            {
                if (checkString.Contains(charStr))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
