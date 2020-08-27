using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using My;

namespace AutoEmail
{
    public partial class SetEDM : Form
    {
        
        public SetEDM()
        {
            InitializeComponent();
            SetAllEDM();
        }

        
        private void SetAllEDM()
        {
            TB_LargeMonitor.Text = Mail_Config.LargeMonitor;
            TB_AirQC.Text = Mail_Config.AirQC;
            TB_Flow.Text = Mail_Config.Flow;
            TB_Recordor.Text = Mail_Config.Recordor;
            TB_Collector.Text = Mail_Config.Collector;
            TB_EE.Text = Mail_Config.EE;
            TB_infrared.Text = Mail_Config.infrared;
            TB_Pressure.Text = Mail_Config.Pressure;
            TB_Diff_Pressure.Text = Mail_Config.Diff_Pressure;
            TB_Air.Text = Mail_Config.Air;
            TB_Dirt.Text = Mail_Config.Dirt;
            TB_Sunshine.Text = Mail_Config.Sunshine;
            TB_Wind.Text = Mail_Config.Wind;
            TB_Rain.Text = Mail_Config.Rain;
            TB_Meteorological.Text = Mail_Config.Meteorological;
            TB_Water.Text = Mail_Config.Water;
            TB_Liquid.Text = Mail_Config.Liquid;
            TB_Tap.Text = Mail_Config.Sticker;
            TB_TempControl.Text = Mail_Config.TempControl;
            TB_TCband.Text = Mail_Config.TCband;
            TB_Wireless.Text = Mail_Config.Wireless;
            TB_Compiler.Text = Mail_Config.Compiler;
            TB_SourceControl.Text = Mail_Config.SourceControl;
            TB_Food.Text = Mail_Config.Food;
            TB_Other.Text = Mail_Config.Other;
        }
        private void SelectEDM(object sender, EventArgs e)
        {
            UIButton BTEDM = (UIButton)sender;
            UIRichTextBox UIText;
            switch (BTEDM.Name)
            {
                case "BT_LargeMonitor":
                    UIText = TB_LargeMonitor;
                    break;
                case "BT_AirQC":
                    UIText = TB_AirQC;
                    break;
                case "BT_Flow": UIText = TB_Flow; break;
                case "BT_Recordor":
                    UIText = TB_Recordor;
                    break;
                case "BT_Collector":
                    UIText = TB_Collector;
                    break;
                case "BT_EE":
                    UIText = TB_EE;
                    break;
                case "BT_infrared":
                    UIText = TB_infrared;
                    break;
                case "BT_Pressure":
                    UIText = TB_Pressure;
                    break;
                case "BT_Diff_Pressure":
                    UIText = TB_Diff_Pressure;
                    break;
                case "BT_Air":
                    UIText = TB_Air;
                    break;
                case "BT_Dirt":
                    UIText = TB_Dirt;
                    break;
                case "BT_Sunshine":
                    UIText = TB_Sunshine;
                    break;
                case "BT_Wind":
                    UIText = TB_Wind;
                    break;
                case "BT_Rain":
                    UIText = TB_Rain;
                    break;
                case "BT_Meteorological":
                    UIText = TB_Meteorological;
                    break;
                case "BT_Water":
                    UIText = TB_Water;
                    break;
                case "BT_Liquid":
                    UIText = TB_Liquid;
                    break;
                case "BT_Tap":
                    UIText = TB_Tap;
                    break;
                case "BT_TempControl":
                    UIText = TB_TempControl;
                    break;
                case "BT_TCband":
                    UIText = TB_TCband;
                    break;
                case "BT_Wireless":
                    UIText = TB_Wireless;
                    break;
                case "BT_Compiler":
                    UIText = TB_Compiler;
                    break;
                case "BT_SourceControl":
                    UIText = TB_SourceControl;
                    break;
                case "BT_Food":
                    UIText = TB_Food;
                    break;
                case "BT_Other":
                    UIText = TB_Other;
                    break;

                default:
                    UIText = TB_LargeMonitor;
                    break;
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "files (*.*)|";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UIText.Text = dialog.FileName;
               
            }
        }
        private void uiButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string filePath = System.Windows.Forms.Application.StartupPath + "\\System.ini";

            MyINI myINI = new MyINI(filePath);
            myINI.setKeyValue("Product_EDM", "LargeMonitor", TB_LargeMonitor.Text);
            Mail_Config.LargeMonitor = TB_LargeMonitor.Text;
            myINI.setKeyValue("Product_EDM", "AirQC", TB_AirQC.Text);
            Mail_Config.AirQC = TB_AirQC.Text;
            myINI.setKeyValue("Product_EDM", "Flow", TB_Flow.Text);
            Mail_Config.Flow = TB_Flow.Text;
            myINI.setKeyValue("Product_EDM", "Recordor", TB_Recordor.Text);
            Mail_Config.Recordor = TB_Recordor.Text;
            myINI.setKeyValue("Product_EDM", "Collector", TB_Collector.Text);
            Mail_Config.Collector = TB_Collector.Text;
            myINI.setKeyValue("Product_EDM", "EE", TB_EE.Text);
            Mail_Config.EE = TB_EE.Text;
            myINI.setKeyValue("Product_EDM", "infrared", TB_infrared.Text);
            Mail_Config.infrared = TB_infrared.Text;
            myINI.setKeyValue("Product_EDM", "Pressure", TB_Pressure.Text);
            Mail_Config.Pressure = TB_Pressure.Text;
            myINI.setKeyValue("Product_EDM", "Diff_Pressure", TB_Diff_Pressure.Text);
            Mail_Config.Diff_Pressure = TB_Diff_Pressure.Text;
            myINI.setKeyValue("Product_EDM", "Air", TB_Air.Text);
            Mail_Config.Air = TB_Air.Text;
            myINI.setKeyValue("Product_EDM", "Dirt", TB_Dirt.Text);
            Mail_Config.Dirt = TB_Dirt.Text;
            myINI.setKeyValue("Product_EDM", "Wind", TB_Wind.Text);
            Mail_Config.Wind = TB_Wind.Text;
            myINI.setKeyValue("Product_EDM", "Rain", TB_Rain.Text);
            Mail_Config.Rain = TB_Rain.Text;
            myINI.setKeyValue("Product_EDM", "Meteorological", TB_Meteorological.Text);
            Mail_Config.Meteorological = TB_Meteorological.Text;
            myINI.setKeyValue("Product_EDM", "Water", TB_Water.Text);
            Mail_Config.Water = TB_Water.Text;
            myINI.setKeyValue("Product_EDM", "Liquid", TB_Liquid.Text);
            Mail_Config.Liquid = TB_Liquid.Text;
            myINI.setKeyValue("Product_EDM", "Tap", TB_Tap.Text);
            Mail_Config.Sticker = TB_Tap.Text;
            myINI.setKeyValue("Product_EDM", "TempControl", TB_TempControl.Text);
            Mail_Config.TempControl = TB_TempControl.Text;
            myINI.setKeyValue("Product_EDM", "TCband", TB_TCband.Text);
            Mail_Config.TCband = TB_TCband.Text;
            myINI.setKeyValue("Product_EDM", "Wireless", TB_Wireless.Text);
            Mail_Config.Wireless = TB_Wireless.Text;
            myINI.setKeyValue("Product_EDM", "Compiler", TB_Compiler.Text);
            Mail_Config.Compiler = TB_Compiler.Text;
            myINI.setKeyValue("Product_EDM", "SourceControl", TB_SourceControl.Text);
            Mail_Config.SourceControl = TB_SourceControl.Text;
            myINI.setKeyValue("Product_EDM", "Food", TB_Food.Text);
            Mail_Config.Food = TB_Food.Text;
            myINI.setKeyValue("Product_EDM", "Other", TB_Other.Text);
            Mail_Config.Other = TB_Other.Text;
            this.Close();

        }
    }
}
