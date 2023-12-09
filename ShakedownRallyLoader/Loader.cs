using System.Diagnostics;
using System.Text;

namespace ShakedownRallyLoader
{
    public partial class Loader : Form
    {
        private readonly List<KeyValuePair<string, string>> maps = [];
        private readonly List<KeyValuePair<string, string>> cars = [];
        private string? iniCar, iniMap;

        public Loader()
        {
            InitializeComponent();

            LoadConfig();

            if (!string.IsNullOrWhiteSpace(txtGamePath.Text))
            {
                LoadAssets(txtGamePath.Text);
            }
        }

        private void LoadGameIniData()
        {
            string configPath = txtGamePath.Text + "\\config.ini";

            var configText = File.ReadAllLines(configPath);
            iniCar = configText.FirstOrDefault(line => line.StartsWith("car = "));
            iniMap = configText.FirstOrDefault(line => line.StartsWith("map = "));

            if (iniCar != null)
                iniCar = iniCar.Replace("car = ", "");
            if (iniMap != null)
                iniMap = iniMap.Replace("map = ", "");
        }

        private void SaveConfig()
        {
            StringBuilder configText = new();
            configText.AppendLine(txtGamePath.Text);

            File.WriteAllText("config.txt", configText.ToString());
        }

        private void LoadConfig()
        {
            try
            {
                var configText = File.ReadAllLines("config.txt");

                if (configText.Length > 0)
                {
                    txtGamePath.Text = configText[0];
                }
            }
            catch (FileNotFoundException)
            {
            }
        }

        private void LoadAssets(string gamePath)
        {
            SaveConfig();

            LoadMaps(gamePath);
            LoadCars(gamePath);

            LoadGameIniData();

            listBoxMaps.DataSource = null;
            listBoxMaps.DataSource = maps;
            listBoxMaps.DisplayMember = "Key";
            listBoxMaps.ValueMember = "Value";
            if (iniMap != null)
                listBoxMaps.SelectedValue = gamePath + "\\res\\" + iniMap;

            listBoxCars.DataSource = null;
            listBoxCars.DataSource = cars;
            listBoxCars.DisplayMember = "Key";
            listBoxCars.ValueMember = "Value";
            if (iniCar != null)
                listBoxCars.SelectedValue = gamePath + "\\res\\" + iniCar;
        }

        private void LoadMaps(string gamePath)
        {
            maps.Clear();

            EnumerationOptions options = new();
            options.RecurseSubdirectories = true;

            string mapsPath = gamePath + @"\res\maps";
            foreach (var mapFile in Directory.EnumerateFiles(mapsPath, "*.map.ini", options))
            {
                FileInfo file = new(mapFile);
                maps.Add(new KeyValuePair<string, string>(file.Name ?? "Unnamed", mapFile));
            }
        }

        private void LoadCars(string gamePath)
        {
            cars.Clear();

            EnumerationOptions options = new();
            options.RecurseSubdirectories = true;

            string carsPath = gamePath + @"\res\cars";
            foreach (var mapFile in Directory.EnumerateFiles(carsPath, "*.car.ini", options))
            {
                FileInfo file = new(mapFile);
                cars.Add(new KeyValuePair<string, string>(file.Name ?? "Unnamed", mapFile));
            }
        }

        private void btnFindPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_GamePath.ShowDialog(this) == DialogResult.OK)
            {
                txtGamePath.Text = folderBrowserDialog_GamePath.SelectedPath;
            }
        }

        private void btnLoadAssets_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGamePath.Text))
            {
                LoadAssets(txtGamePath.Text);
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            string configPath = txtGamePath.Text + "\\config.ini";

            string car, map;
            if (listBoxCars.SelectedValue != null)
                car = listBoxCars.SelectedValue.ToString() ?? "cars\\spec17\\spec17.car.ini";
            else
                return;

            if (listBoxMaps.SelectedValue != null)
                map = listBoxMaps.SelectedValue.ToString() ?? "maps\\finland\\finland.map.ini";
            else
                return;

            car = car.Replace(txtGamePath.Text + "\\res\\", "");
            map = map.Replace(txtGamePath.Text + "\\res\\", "");

            var configLines = File.ReadAllLines(configPath);
            for (int i = 0; i < configLines.Length; i++)
            {
                if (configLines[i].StartsWith("car = "))
                    configLines[i] = "car = " + car;

                if (configLines[i].StartsWith("map = "))
                    configLines[i] = "map = " + map;
            }
            File.WriteAllLines(configPath, configLines);
        }

        private void btnSaveDefault_Click(object sender, EventArgs e)
        {
            string configPath = txtGamePath.Text + "\\config.ini";

            var configLines = File.ReadAllLines(configPath);
            for (int i = 0; i < configLines.Length; i++)
            {
                if (configLines[i].StartsWith("car = "))
                    configLines[i] = @"car = cars\spec17\spec17.car.ini";

                if (configLines[i].StartsWith("map = "))
                    configLines[i] = @"map = maps\finland\finland.map.ini";
            }
            File.WriteAllLines(configPath, configLines);
        }

        private void btnLaunchGame_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new(txtGamePath.Text + "\\NEngine-drive.exe");
            startInfo.WorkingDirectory = txtGamePath.Text;

            Process.Start(startInfo);
        }
    }
}
