using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVCLib;

namespace TDS2014B_Tekvisa_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Tvc tvc1 = new Tvc();

        private void Form1_Load(object sender, EventArgs e)
        {
            Array Teklist;
            try 
            {
                tvc1.SearchCriterion = 0;
                Teklist = tvc1.FindList as Array;
                foreach(object item in Teklist)
                {
                    listBox1.Items.Add(item);
                }

                listBox1.SetSelected(0, true);
                tvc1.Descriptor = Convert.ToString(listBox1.SelectedItem);
                tek_lbl1.Text ="MFG: " +  tvc1.InstrumentManufacturer;
                tek_lbl2.Text = "Model: " + tvc1.InstrumentModel;
                tek_lbl3.Text = "SID: " + tvc1.SoftwareManufacturerID;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + "No Tektronix device found!");
            }
        }

        private void btnDeviceRefresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            Array Teklist;
            try
            {
                tvc1.SearchCriterion = 0;
                Teklist = tvc1.FindList as Array;
                foreach (object item in Teklist)
                {
                    listBox1.Items.Add(item);
                }

                listBox1.SetSelected(0, true);
                tvc1.Descriptor = Convert.ToString(listBox1.SelectedItem);
                tek_lbl1.Text = "MFG: " + tvc1.InstrumentManufacturer;
                tek_lbl2.Text = "Model: " + tvc1.InstrumentModel;
                tek_lbl3.Text = "SID: " + tvc1.SoftwareManufacturerID;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + "No Tektronix device found!");
            }
        }

        private void chkCH1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCH1.Checked)
            {
                tvc1.WriteString("Select:CH1 ON");
            }
            else
            {
                tvc1.WriteString("Select:CH1 OFF");
            }
        }

        private void chkCH2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCH2.Checked)
            {
                tvc1.WriteString("Select:CH2 ON");
            }
            else
            {
                tvc1.WriteString("Select:CH2 OFF");
            }
        }

        private void chkCH3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCH3.Checked)
            {
                tvc1.WriteString("Select:CH3 ON");
            }
            else
            {
                tvc1.WriteString("Select:CH3 OFF");
            }
        }

        private void chkCH4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCH4.Checked)
            {
                tvc1.WriteString("Select:CH4 ON");
            }
            else
            {
                tvc1.WriteString("Select:CH4 OFF");
            }
        }

        private void btnSetupTDS2014B_Click(object sender, EventArgs e)
        {
            txtinfo.AppendText("Setting up TDS2014B, please wait...\r\n");
            tvc1.WriteString("Horizontal:main:scale 5.0e-4");// set OSC main time base for 1 kHz measurement
            tvc1.WriteString("CH1:scale 5");// set ch1 to vertical 5V
            tvc1.WriteString("CH2:scale 1"); // set ch1 to vertical 1V

            tvc1.WriteString("CH1:POSition 2.5");// set CH1, CH2 horizontal postion
            tvc1.WriteString("CH2:POSition 0");

            //set up for probes
            tvc1.WriteString("CH1:probe 10");// set probe attenuation to x10
            tvc1.WriteString("CH2:probe 10");

            //set up for trigger
            tvc1.WriteString("TRIGger:MAIn:EDGE:SLOpe RISE");//  set trigger slope rise
            tvc1.WriteString("TRIGger:MAIn:TYPe EDGE");//  set type to edge
            tvc1.WriteString("TRIGger:MAIn:EDGE:SOUrce CH1");// set trigger source to CH1
            tvc1.WriteString("TRIGger:MAIn:LEVel 0");//  set trigger level
            tvc1.WriteString("TRIGger:MAIn:MODe auto");//  set trigger to auto
            tvc1.WriteString("TRIGger:MAIn:EDGE:COUPling AC");// set coupling to AC

            //'set up ch for measurement
            tvc1.WriteString("measurement:meas1:source ch1");// ' set measurement1 for ch1
            tvc1.WriteString("measurement:meas1:type crms");// 'set measurement1 type for ch1
            tvc1.WriteString("measurement:meas2:source ch1");// ' set measurement2 for ch1
            tvc1.WriteString("measurement:meas2:type freq");// 'set measurement2 type for ch1

            tvc1.WriteString("measurement:meas3:source ch2");// ' set measurement3 for ch2
            tvc1.WriteString("measurement:meas3:type crms");// 'set measurement3 type for ch2
            tvc1.WriteString("measurement:meas4:source ch2");// ' set measurement4 for ch2
            tvc1.WriteString("measurement:meas4:type freq");// 'set measurement4 type for ch2
            txtinfo.AppendText("done!\r\n");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if(btnRead.Text=="Start Read")
            {
                btnRead.Text = "Stop Read";
                tmRead.Start();
            }
            else if(btnRead.Text=="Stop Read")
            {
                btnRead.Text = "Start Read";
                tmRead.Stop();
            }
        }

        double rms1 = 0, rms2 = 0, freq1 = 0, freq2 = 0;
        private void tmRead_Tick(object sender, EventArgs e)
        {
            txtinfo.Clear();
            rms1 =Convert.ToDouble(tvc1.Query("measurement:meas1:value?"));
            freq1 = Convert.ToDouble(tvc1.Query("measurement:meas2:value?"));
            rms2 = Convert.ToDouble(tvc1.Query("measurement:meas3:value?"));
            freq2 = Convert.ToDouble(tvc1.Query("measurement:meas4:value?"));
            txtinfo.AppendText("CH1: RMS1: " + rms1.ToString("#.##") + " V\r\n");
            txtinfo.AppendText("CH1: Freq1: " + freq1.ToString("#.##") + " Hz\r\n");
            txtinfo.AppendText("CH2: RMS2: " + rms2.ToString("#.##") + " V\r\n");
            txtinfo.AppendText("CH2: Freq2: " + freq2.ToString("#.##") + " Hz\r\n");

        }
    }
}
