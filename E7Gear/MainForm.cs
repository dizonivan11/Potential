using IronOcr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace E7Gear {
    public partial class MainForm : Form {
        private readonly string[] GEAR_STATS = new string[] {
            "Attack", "Defense", "Health", "Effectiveness", "Effect Resistance", "Critical Hit Chance", "Critical Hit Damage", "Speed"
        };

        // Stats
        private int
            Attack,
            FlatAttack,
            Health,
            FlatHealth,
            Defense,
            FlatDefense,
            Effectiveness,
            EffectResistance,
            CriticalHitChance,
            CriticalHitDamage,
            Speed;

        // References
        private ComboBox[] gearStat;
        private NumericUpDown[] gearValue;
        private readonly Dictionary<NumericUpDown, ComboBox> cboxStats = new Dictionary<NumericUpDown, ComboBox>();

        public MainForm() {
            InitializeComponent();
            gearStat = new ComboBox[] { cboxMain, cboxSub1, cboxSub2, cboxSub3, cboxSub4 };
            gearValue = new NumericUpDown[] { numMain, numSub1, numSub2, numSub3, numSub4 };
            cboxStats.Add(numMain, cboxMain);
            cboxStats.Add(numSub1, cboxSub1);
            cboxStats.Add(numSub2, cboxSub2);
            cboxStats.Add(numSub3, cboxSub3);
            cboxStats.Add(numSub4, cboxSub4);

            KeyDown += MainForm_KeyDown;
            numSub1.ValueChanged += UpdateStatValue;
            numSub2.ValueChanged += UpdateStatValue;
            numSub3.ValueChanged += UpdateStatValue;
            numSub4.ValueChanged += UpdateStatValue;
            cboxSub1.TextChanged += UpdateSubStat;
            cboxSub2.TextChanged += UpdateSubStat;
            cboxSub3.TextChanged += UpdateSubStat;
            cboxSub4.TextChanged += UpdateSubStat;
        }

        private void UpdateSubStat(object sender, EventArgs e) {
            // Implement dynamic stat change event
            // TODO: ....
        }

        private void UpdateStatValue(object sender, EventArgs e) {
            NumericUpDown numStat = (NumericUpDown)sender;
            ComboBox cboxStat = cboxStats[numStat];

            switch (cboxStat.Text) {
                case "Attack": Attack = (int)numStat.Value; break;
                case "Flat Attack": FlatAttack = (int)numStat.Value; break;
                case "Health": Health = (int)numStat.Value; break;
                case "Flat Health": FlatHealth = (int)numStat.Value; break;
                case "Defense": Defense = (int)numStat.Value; break;
                case "Flat Defense": FlatDefense = (int)numStat.Value; break;
                case "Effectiveness": Effectiveness = (int)numStat.Value; break;
                case "Effect Resistance": EffectResistance = (int)numStat.Value; break;
                case "Critical Hit Chance": CriticalHitChance = (int)numStat.Value; break;
                case "Critical Hit Damage": CriticalHitDamage = (int)numStat.Value; break;
                case "Speed": Speed = (int)numStat.Value; break;
                default:
                    break;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            if (Clipboard.ContainsImage()) {
                if (e.KeyCode == Keys.V && e.Control) {
                    e.SuppressKeyPress = true;
                    picPreview.Image = Clipboard.GetImage();

                    ClearStats();

                    var Ocr = new IronTesseract();
                    Ocr.Configuration.PageSegmentationMode = TesseractPageSegmentationMode.SingleBlock;
                    Ocr.Configuration.EngineMode = TesseractEngineMode.TesseractAndLstm;
                    Ocr.MultiThreaded = true;
                    Ocr.Language = OcrLanguage.English;

                    using (var Input = new OcrInput(Clipboard.GetImage())) {
                        Input.Binarize();
                        Input.Contrast();
                        Input.DeNoise();
                        Input.Sharpen();
                        var Result = Ocr.Read(Input);
                        string[] lines = Result.Text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                        int currentGearStatIndex = 0;
                        for (int i = 0; i < lines.Length; i++) {
                            string line = lines[i];

                            for (int s = 0; s < GEAR_STATS.Length; s++) {
                                string stat = GEAR_STATS[s];

                                if (Regex.IsMatch(line, stat)) {
                                    string statValue = line.Substring(line.IndexOf(stat) + stat.Length).Trim();
                                    bool isPercentage = statValue.Contains('%');

                                    // Remove non-numeric characters at the start and end,
                                    // Useful for modified gears, 1000+ gear stats, and noisy read
                                    statValue = Regex.Replace(statValue, @"\D", "");
                                    int statNumber = int.Parse(statValue);
                                    gearValue[currentGearStatIndex].Value = statNumber;

                                    // Distribute stats
                                    switch (stat) {
                                        case "Attack":
                                            if (isPercentage) {
                                                gearStat[currentGearStatIndex].Text = "Attack";
                                            } else {
                                                gearStat[currentGearStatIndex].Text = "Flat Attack";
                                            }
                                            break;
                                        case "Health":
                                            if (isPercentage) {
                                                gearStat[currentGearStatIndex].Text = "Health";
                                            } else {
                                                gearStat[currentGearStatIndex].Text = "Flat Health";
                                            }
                                            break;
                                        case "Defense":
                                            if (isPercentage) {
                                                gearStat[currentGearStatIndex].Text = "Defense";
                                            } else {
                                                gearStat[currentGearStatIndex].Text = "Flat Defense";
                                            }
                                            break;
                                        case "Effectiveness":
                                            gearStat[currentGearStatIndex].Text = "Effectiveness";
                                            break;
                                        case "Effect Resistance":
                                            gearStat[currentGearStatIndex].Text = "Effect Resistance";
                                            break;
                                        case "Critical Hit Chance":
                                            gearStat[currentGearStatIndex].Text = "Critical Hit Chance";
                                            break;
                                        case "Critical Hit Damage":
                                            gearStat[currentGearStatIndex].Text = "Critical Hit Damage";
                                            break;
                                        case "Speed":
                                            gearStat[currentGearStatIndex].Text = "Speed";
                                            break;
                                        default:
                                            break;
                                    }
                                    gearValue[currentGearStatIndex].Value = statNumber;

                                    // If its not the main stats, initially update the values
                                    if (currentGearStatIndex > 0)
                                        UpdateStatValue(gearValue[currentGearStatIndex], e);

                                    currentGearStatIndex++;
                                    break;
                                }
                            }
                        }
                    }
                    CalculateGearScore();
                }
            }
        }

        private void CalculateGearScore() {
            double score = 0;

            // Lvl 85 gears (before reforge)
            score = Attack + Health + Defense + Effectiveness + EffectResistance +
                (CriticalHitChance * 1.6) + (CriticalHitDamage * 1.1) + (Speed * 2) +
                (FlatAttack / 10) + (FlatHealth / 50) + (FlatDefense / 6);

            lblScore.Text = score.ToString();
        }

        private void ClearStats() {
            Attack = 0;
            FlatAttack = 0;
            Health = 0;
            FlatHealth = 0;
            Defense = 0;
            FlatDefense = 0;
            Effectiveness = 0;
            EffectResistance = 0;
            CriticalHitChance = 0;
            CriticalHitDamage = 0;
            Speed = 0;

            for (int i = 0; i < gearStat.Length; i++) {
                gearStat[i].SelectedIndex = -1;
                gearValue[i].Value = 0;
            }
            lblScore.Text = "--";
        }

        private void btnClear_Click(object sender, EventArgs e) {
            picPreview.Image = null;
            ClearStats();
        }

        private void btnCalc_Click(object sender, EventArgs e) {
            CalculateGearScore();
        }
    }
}
