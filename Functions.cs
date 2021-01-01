using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.IO;

namespace LCPLauncher
{
    public static class Functions
    {
        public static string StartLCPSwagger(string pathproj)
        {
            return $"cd {pathproj} && npm run start_lcp_swagger";
        }

        public static string StartOnlySwagger(string pathproj)
        {
            return $"start \"\" \"https://localhost:5001/swagger\" && cd {pathproj} && npm run real_api";
        }

        public static string StartUnitTests(string pathproj)
        {
            return $"cd {pathproj} && start cmd /c \"npm run real_api\" && start cmd /c \"npm run test\"";
        }

        public static string StartUTCodeCoverage(string pathproj)
        {
            return $"start chrome \"file:///C:\\Users\\Luis\\Documents\\angular\\lcp\\coverage\\lcp\\index.html\" && cd {pathproj} && start cmd /c \"npm run real_api\" && start cmd /c \"npm run test_code_coverage\"";
        }

        public static string StartGenDBData(string pathproj)
        {
            if(File.Exists(pathproj + "\\scripts\\update_db.bat"))
            {
                return $"cd {pathproj} && scripts\\update_db.bat";
            }
            else
            {
                return "Error: could not find script file update_db.bat to gen db data, pls locate it.";
            }
        }

        public static string StartUpdateProject(string pathproj)
        {
            string projscrmsg;

            projscrmsg = 
            $"if exist \"{pathproj}\\node_modules\" ( rmdir /s /q \"{pathproj}\\node_modules\")\\" +
            $"if exist \"{pathproj}\\package-lock.json\" ( del /f \"{pathproj}\\package-lock.json\")\\" +
            @"
            npm cache clean --force
            npm cache verify
            npm uninstall typescript
            npm uninstall --save-dev angular-cli
            npm install --save-dev @angular/cli@latest
            npm install -g npx
            npx npm-check-updates-u
            npm install --save-dev typescript 
            npm install";

            return $"cd {pathproj} && {projscrmsg}";
        }

        public static void LoadCMD(ComboBox cb, TextBox tb)
        {
            string cmd = "/c " + cb.SelectedValue;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = cmd;
            proc.StartInfo.RedirectStandardError = true;

            proc.StartInfo.UseShellExecute = false;
            //proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();

            string consoleOutput = proc.StandardOutput.ReadToEnd();
            tb.Text = consoleOutput;

            proc.WaitForExit();
        }

        public static Dictionary<string, string> GetListCMDS(string pathproj)
        {
            return new Dictionary<string, string>() {
                {"LCP com Swagger", StartLCPSwagger(pathproj) },
                {"Só o Swagger", StartOnlySwagger(pathproj) },
                {"Testes unitários", StartUnitTests(pathproj) },
                {"Testes unitários com a cobertura do código", StartUTCodeCoverage(pathproj) },
                {"Gerar novos dados para base de dados", StartGenDBData(pathproj) },
                {"Atualizar o projeto", StartUpdateProject(pathproj) }
            };
        }
    }
}
