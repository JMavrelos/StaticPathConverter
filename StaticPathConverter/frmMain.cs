﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticPathConverter
{
    public partial class frmMain : Form
    {
        private bool changeCommas = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator.Equals(",");


        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs args)
        {
            double x = 0.0;
            double y = 0.0;
            string output = "";
            List<String> commands = split(txtStatic.Text);
            try
            {
                foreach (string command in commands)
                {
                    output += parse(command, ref x, ref y);
                }
                txtRelative.Text = output;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error while parsing " + e.Message);
            }


        }


        private List<string> split(string text)
        {
            List<string> response = new List<string>();
            string current = "";
            string valid = ",. 0123456789";
            foreach (char c in text)
            {
                if (!valid.Contains(c) && !current.Trim().Equals(""))
                {
                    response.Add(current.Trim());
                    current = "";
                }
                current += c;
            }

            return response;


        }

        private string parse(string command, ref double x, ref double y)
        {
            string response = "";
            char cmd = command[0];
            List<double> prms = command.Substring(1)
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList().Select((it) =>
            {
                if (changeCommas)
                {
                    return Math.Round(double.Parse(it.Replace(".", ",")), 2);
                }
                else
                {
                    return Math.Round(double.Parse(it), 2);
                }
            }).ToList();

            switch (cmd)
            {
                case 'M':
                    {
                        if (prms.Count != 2)
                        {
                            throw new Exception("Expected 2 parameters for Move command instead got " + prms.Count);
                        }
                        if (chkNoMove.Checked)
                        {
                            response = "M" + asString(prms[0]) + " " + asString(prms[1]);
                        }
                        else
                        {
                            response = "m" + asString(prms[0] - x) + " " + asString(prms[1] - y);
                        }
                        x = prms[0];
                        y = prms[1];
                        break;
                    }
                case 'm':
                    {

                    }
                case 'Z':
                    {
                        response = "z";
                        break;
                    }
                case 'H':
                    {
                        if (prms.Count != 1)
                        {
                            throw new Exception("Expected 1 parameter for Horizontal command instead got " + prms.Count);
                        }
                        response = "h" + asString(prms[0] - x);
                        x = prms[0];
                        break;
                    }
                case 'V':
                    {
                        if (prms.Count != 1)
                        {
                            throw new Exception("Expected 1 parameter for Vertical command instead got " + prms.Count);
                        }
                        response = "v" + asString(prms[0] - y);
                        y = prms[0];
                        break;
                    }
                case 'L':
                    {
                        if (prms.Count != 2)
                        {
                            throw new Exception("Expected 2 parameters for Line command instead got " + prms.Count);
                        }
                        response = "l" + asString(prms[0] - x) + " " + asString(prms[1] - y);
                        x = prms[0];
                        y = prms[1];
                        break;
                    }
                case 'A':
                    {
                        if (prms.Count != 7)
                        {
                            throw new Exception("Expected 7 parameters for Curve command instead got " + prms.Count);
                        }
                        response = "c" + asString(prms[0]) + " " + asString(prms[1]) + " " + asString(prms[2]) + " " + asString(prms[3]) + " " + asString(prms[4]) + " " +
                            asString(prms[5] - x) + " " + asString(prms[6] - y);
                        x = prms[5];
                        y = prms[6];
                        break;
                    }
                case 'C':
                    {
                        if (prms.Count != 6)
                        {
                            throw new Exception("Expected 6 parameters for Curve command instead got " + prms.Count);
                        }
                        response = "c" + asString(prms[0] - x) + " " + asString(prms[1] - y) + " " +
                            asString(prms[2] - x) + " " + asString(prms[3] - y) + " " +
                            asString(prms[4] - x) + " " + asString(prms[5] - y);
                        x = prms[4];
                        y = prms[5];
                        break;
                    }
                case 'c':
                case 'z':
                case 'l':
                case 'a':
                case 'm':

                default:
                    throw new Exception("Unrecognized command " + cmd);
            }
            return response;

        }


        private string asString(double num)
        {
            String response = Math.Round(num,2).ToString().Replace(",", ".");
            Console.WriteLine(" converted " + num + " to  " + response);
            return response;
        }
    }
}