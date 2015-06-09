using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;



namespace NeptuniaReBirth2Items
{
    public partial class Form1 : Form
    {

        private const short NUM_ITEMS = 3000;


        List<byte[]> existing = new List<byte[]>();
        List<byte[]> items = new List<byte[]>();
        List<byte[]> missing = new List<byte[]>();
        byte[] data;
        byte[] stone = new byte[8];

        int offset = 0;
        int tmpoffset = 0;
        int nag = 0;

        Process proc = null;
        ProcessModuleCollection procmcol = null;
        ProcessModule procm = null;
        IntPtr handle = (IntPtr)0;


        ArrayOfByteComparer comparer = new ArrayOfByteComparer();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();




        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";

            FindMissingItems();


            #region stone effects
            string[] stoneeffects = new string[51]
            {
                "(none)",

                "HP+10",
                "HP+20",
                "HP+30",
                "STR+5",

                "STR+10",
                "STR+20",
                "VIT+4",
                "VIT+8",

                "VIT+16",
                "LUK+10",
                "HP lvl+1",
                "HP lvl+2",

                "STR lvl+1",
                "STR lvl+2",
                "VIT lvl+1",
                "VIT lvl+2",

                "LUK lvl+1",
                "LUK lvl+2",
                "Psn-Atk",
                "Psn-Def",

                "Psn-Nul",
                "Par-Atk",
                "Par-Def",
                "Par-Nul",

                "Atk: Fire",
                "Def: Fire",
                "Atk: Ice",
                "Def: Ice",

                "Atk: Wind",
                "Def: Wind",
                "Atk: Elec",
                "Def: Elec",

                "Crit. Rate UP",
                "Evasion UP",
                "Defend",
                "Steal-Nul",

                "Item Drop UP",
                "Counter",
                "1st Aid",
                "Avoid Trap",

                "More Treasure",
                "More Enemies",
                "Fewer Enemies",
                "Cover",

                "Battle Random HP+",
                "Battle Random STR+",
                "Battle Random VIT+",
                "Paralyze Foe",

                "Rob Foe",
                "Area HP+"
            };
            #endregion


            List<string> stones = new List<string>(7)
            {
                "Stone of Faith",
                "Stone of Light",
                "Sagestone",
                "Neutral Stone",
                "Stone of Death",
                "Virgin Stone",
                "Goddess Stone",
            };

            cb_stonename.DataSource = stones;
            cb_stonename.SelectedIndexChanged += this.ModifyStone;
            cb_stoneeffect1.Items.AddRange(stoneeffects); cb_stoneeffect1.SelectedIndex = 0; cb_stoneeffect1.SelectedIndexChanged += this.ModifyStone;
            cb_stoneeffect2.Items.AddRange(stoneeffects); cb_stoneeffect2.SelectedIndex = 0; cb_stoneeffect2.SelectedIndexChanged += this.ModifyStone;
            cb_stoneeffect3.Items.AddRange(stoneeffects); cb_stoneeffect3.SelectedIndex = 0; cb_stoneeffect3.SelectedIndexChanged += this.ModifyStone;
            cb_stoneeffect4.Items.AddRange(stoneeffects); cb_stoneeffect4.SelectedIndex = 0; cb_stoneeffect4.SelectedIndexChanged += this.ModifyStone;

            ModifyStone(this, null);

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (!StartStatus()) return;


            items.Clear();
            byte[] temp0;



            // get healing items (tools)
            if (ch_tools.Checked)
            {
                for (short a = 1; a <= 40; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }

                temp0 = BitConverter.GetBytes((short)4541);
                items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
            }

            // get medals
            if (ch_medals.Checked)
            {
                for (short a = 211; a <= 236; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x01, 0x00 });
                }
            }

            // get memory expansions
            if (ch_memexpand.Checked)
            {
                for (short a = 241; a <= 245; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }
            }

            // get plans
            if (ch_plans.Checked)
            {
                for (short a = 401; a <= 671; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x01, 0x01 });
                }

                for (short a = 4501; a <= 4503; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x01, 0x01 });
                }

                for (short a = 4523; a <= 4527; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x01, 0x01 });
                }

                for (short a = 4538; a <= 4540; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x01, 0x01 });
                }

                for (short a = 4552; a <= 4556; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x01, 0x01 });
                }
            }

            // get materials
            if (ch_materials.Checked)
            {
                for (short a = 701; a <= 1039; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }

                for (short a = 4516; a <= 4522; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }

                for (short a = 4531; a <= 4537; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }

                for (short a = 4545; a <= 4551; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }
            }

            // get processor units
            if (ch_procunits.Checked)
            {
                for (short a = 3101; a <= 3521; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }
            }

            // get idea chips
            if (ch_ideachips.Checked)
            {
                for (short a = 4105; a <= 4283; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }
            }

            // get everything else not listed above
            if (ch_everything.Checked)
            {
                for (short a = 1062; a <= 2760; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }

                for (short a = 4504; a <= 4515; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }

                for (short a = 4528; a <= 4530; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }

                for (short a = 4542; a <= 4544; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }

                for (short a = 4557; a <= 4562; a++)
                {
                    temp0 = BitConverter.GetBytes(a);
                    items.Add(new byte[4] { temp0[0], temp0[1], 0x63, 0x00 });
                }
            }



            items = items.Except(missing, comparer).ToList();

            if (existing.Count > 0)
            {
                items = items.Except(existing, comparer).ToList();
                items.AddRange(existing);
            }



            data = items.SelectMany(a => a).ToArray();




            // write to game memory

            if (!WriteProcessMemory(
                handle,
                (IntPtr)offset,
                data,
                (uint)data.Length,
                out nag))
            {
                EndStatus();
                MessageBox.Show("Could not write region (give items) " + nag);
                return;
            }

            data = BitConverter.GetBytes((short)items.Count);

            if (!WriteProcessMemory(
                handle,
                (IntPtr)offset - 4,
                data,
                (uint)data.Length,
                out nag))
            {
                EndStatus();
                MessageBox.Show("Could not write region (num items) " + nag);
                return;
            }




            // end
            EndStatus();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clearing inventory (this cannot be undone). Continue?", "Warning", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel) return;

            if (!StartStatus()) return;

            byte[] clear = new byte[NUM_ITEMS * 4];

            if (!WriteProcessMemory(
            handle,
            (IntPtr)offset,
            clear,
            (uint)clear.Length,
            out nag))
            {
                EndStatus();
                MessageBox.Show("Could not write region (clear items) " + nag);
                return;
            }

            data = new byte[4];

            WriteProcessMemory(
            handle,
            (IntPtr)offset - 4,
            data,
            (uint)data.Length,
            out nag);


            existing.Clear();


            EndStatus();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (!StartStatus()) return;

            // save existing items

            existing.Clear();
            data = new byte[2];

            if (!ReadProcessMemory(
            handle,
            (IntPtr)offset - 4,
            data,
            data.Length,
            ref nag))
            {
                EndStatus();
                MessageBox.Show("Could not read region (num items) " + nag);
                return;
            }

            short num = BitConverter.ToInt16(data, 0);

            if (num == 0)
            {
                EndStatus();
                MessageBox.Show("Inventory is empty");
                return;
            }

            existing = new List<byte[]>();
            data = new byte[num * 4];

            ReadProcessMemory(
            handle,
            (IntPtr)offset,
            data,
            data.Length,
            ref nag);

            for (short a = 0; a < num; a++)
            {
                existing.Add(data.Skip(a * 4).Take(4).ToArray());
            }

            EndStatus();
        }


        private bool StartStatus()
        {

            timer.Reset();
            timer.Start();
            toolStripStatusLabel1.Text = "Working";

            if ((int)numericUpDown1.Value != 0)
            {
                offset = (int)numericUpDown1.Value;
            }
            else
            {
                EndStatus();
                MessageBox.Show("Offset can not be zero");
                return false;
            }


            try
            {
                proc = Process.GetProcessesByName("NeptuniaReBirth2").FirstOrDefault();
            }
            catch (Exception)
            {
                EndStatus();
                MessageBox.Show("Run Neptunia Re;Birth 2 and load a save");
                return false;
            }

            handle = OpenProcess(ProcessAccessFlags.All, false, proc.Id);

            if ((int)handle == 0)
            {
                EndStatus();
                MessageBox.Show("Could not find process handle");
                return false;
            }

            procmcol = proc.Modules;
            foreach (ProcessModule found in procmcol)
                if (found.ModuleName == "NeptuniaReBirth2.exe")
                {
                    procm = found;
                    break;
                }

            if (procm == null)
            {
                EndStatus();
                MessageBox.Show("Could not find module NeptuniaReBirth2.exe");
                return false;
            }



            return true;
        }


        private void EndStatus()
        {
            if ((int)handle != 0) CloseHandle(handle);

            // status alert
            timer.Stop();
            toolStripStatusLabel1.Text = "Finished [HH:MM:SS] " +
                DateTime.Now.Hour + ":" +
                DateTime.Now.Minute + ":" +
                DateTime.Now.Second +
                " (" + timer.ElapsedMilliseconds + "ms)";
        }


        private void FindMissingItems()
        {

            FileStream fs = null;

            try
            {
                fs = File.OpenRead(Application.StartupPath + "\\items.txt");
            }
            catch
            {
                MessageBox.Show("Missing items.txt");
                this.Close();
            }


            using (StreamReader sr = new StreamReader(fs))
            {


                short lastval = 0;
                short id = 1;
                byte[] temp;

                while (!sr.EndOfStream)
                {
                    if (!short.TryParse(sr.ReadLine(), out id))
                    {
                        break;
                    }
                    else
                    {
                        while (id > lastval + 1)
                        {
                            lastval++;
                            temp = BitConverter.GetBytes(lastval);
                            missing.Add(new byte[]
                                {
                                    temp[0],
                                    temp[1],
                                    0x01,
                                    0x00
                                });
                        }

                        lastval = id;
                    }
                }

                sr.Close();
            }
        }




        #region KERNEL32

        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }


        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint dwSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hProcess);


        #endregion KERNEL32

        private void b_weapons_Click(object sender, EventArgs e)
        {

            if (!StartStatus()) return;


            tmpoffset = offset +
                0x332;      // weapons


            items = new List<byte[]>(99);


            for (short i = 1; i <= 56; i++)
            {

                data = BitConverter.GetBytes(i);

                items.Add(new byte[8]
                {
                    data[0],
                    data[1],
                    0x09,
                    0x00,
                    0x00, 0x00, 0x00, 0x00
                });
            }

            for (short i = 0; i < 43; i++)
            {
                items.Add(new byte[8]);
            }


            data = items.SelectMany(a => a).ToArray();


            if (!WriteProcessMemory(
                handle,
                (IntPtr)tmpoffset,
                data,
                (uint)data.Length,
                out nag))
            {
                EndStatus();
                MessageBox.Show("Could not write region (stella weapons) " + nag);
                return;
            }


            data = new byte[2] { 0xff, 0xff };
            WriteProcessMemory(
                handle,
                (IntPtr)offset + 2,
                data,
                (uint)data.Length,
                out nag);


            EndStatus();

        }

        private void b_armor_Click(object sender, EventArgs e)
        {

            if (!StartStatus()) return;


            tmpoffset = offset +
                0x332 +     // weapons
                0x318;      // armor


            items = new List<byte[]>(99);


            for (short i = 101; i <= 144; i++)
            {

                data = BitConverter.GetBytes(i);

                items.Add(new byte[8]
                {
                    data[0],
                    data[1],
                    0x09,
                    0x00,
                    0x00, 0x00, 0x00, 0x00
                });
            }
            for (short i = 0; i < 55; i++)
            {
                items.Add(new byte[8]);
            }


            data = items.SelectMany(a => a).ToArray();


            if (!WriteProcessMemory(
                handle,
                (IntPtr)tmpoffset,
                data,
                (uint)data.Length,
                out nag))
            {
                EndStatus();
                MessageBox.Show("Could not write region (stella armor) " + nag);
                return;
            }


            data = new byte[2] { 0xff, 0xff };
            WriteProcessMemory(
                handle,
                (IntPtr)offset + 4,
                data,
                (uint)data.Length,
                out nag);


            EndStatus();
        }

        private void b_accessories_Click(object sender, EventArgs e)
        {
            if (!StartStatus()) return;


            tmpoffset = offset +
                0x332 +     // weapons
                0x318 +     // armor
                0x318 +     // stones
                0x318;      // accessories


            #region data
            data = new byte[]
            {
                0x30, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x36, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x34, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x2E, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x31, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x32, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x2F, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x37, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,

                0x2D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x35, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x33, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,

                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,

                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,

                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,

                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,

                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,

                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,

                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,

                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
            };
            #endregion


            if (!WriteProcessMemory(
                handle,
                (IntPtr)tmpoffset,
                data,
                (uint)data.Length,
                out nag))
            {
                EndStatus();
                MessageBox.Show("Could not write region (stella accessories) " + nag);
                return;
            }


            data = new byte[2] { 0xff, 0xff };
            WriteProcessMemory(
                handle,
                (IntPtr)offset + 8,
                data,
                (uint)data.Length,
                out nag);

            EndStatus();
        }

        private void b_starfragments_Click(object sender, EventArgs e)
        {
            if (!StartStatus()) return;


            tmpoffset = offset +
                0x332 +     // weapons
                0x318 +     // armor
                0x318 +     // stones
                0x318 +     // accessories
                0x318;      // star shards


            items.Clear();

            for (short i = 401; i <= 408; i++)
            {

                data = BitConverter.GetBytes(i);

                items.Add(new byte[8]
                {
                    data[0],
                    data[1],
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                });
            }
            for (short i = 0; i < 91; i++)
            {
                items.Add(new byte[8]);
            }


            data = items.SelectMany(a => a).ToArray();


            if (!WriteProcessMemory(
                handle,
                (IntPtr)tmpoffset,
                data,
                (uint)data.Length,
                out nag))
            {
                EndStatus();
                MessageBox.Show("Could not write region (stella star fragments) " + nag);
                return;
            }


            EndStatus();
        }

        private void b_stone_Click(object sender, EventArgs e)
        {

            if (!StartStatus()) return;


            tmpoffset = offset +
                0x332 +     // weapons
                0x318 +     // armor
                0x318;      // stones


            data = new byte[0x318];

            if (!ReadProcessMemory(
                handle,
                (IntPtr)tmpoffset,
                data,
                data.Length,
                ref nag))
            {
                EndStatus();
                MessageBox.Show("Could not read region (stella stones) " + nag);
                return;
            }



            int i = 0;
            for (i = 0; i < 99; i++)
            {
                if (data[i * 8] == 0x00) break;
            }

            if (i == 98)
            {
                EndStatus();
                MessageBox.Show("Could not add stone. Discard one in game.");
                return;
            }


            if (!WriteProcessMemory(
                handle,
                (IntPtr)(tmpoffset + (i * 8)),
                stone,
                (uint)stone.Length,
                out nag))
            {
                EndStatus();
                MessageBox.Show("Could not write region (stella add stone) " + nag);
                return;
            }

            data = new byte[2] { 0xff, 0xff };
            WriteProcessMemory(
                handle,
                (IntPtr)offset + 6,
                data,
                (uint)data.Length,
                out nag);


            EndStatus();
        }

        private void b_clearstones_Click(object sender, EventArgs e)
        {
            if (!StartStatus()) return;


            tmpoffset = offset +
                0x332 +     // weapons
                0x318 +     // armor
                0x318;      // stones

            data = new byte[0x318];


            if (!WriteProcessMemory(
                handle,
                (IntPtr)tmpoffset,
                data,
                (uint)data.Length,
                out nag))
            {
                EndStatus();
                MessageBox.Show("Could not write region (stella clear stones) " + nag);
                return;
            }

            data = new byte[2] { 0xff, 0xff };
            WriteProcessMemory(
                handle,
                (IntPtr)offset + 6,
                data,
                (uint)data.Length,
                out nag);


            EndStatus();
        }

        private void ModifyStone(object sender, EventArgs e)
        {

            stone[0] = (byte)(cb_stonename.SelectedIndex + 201);
            stone[1] = 0x00;
            stone[2] = 0x09;
            stone[3] = 0x00;
            stone[4] = (byte)cb_stoneeffect1.SelectedIndex;
            stone[5] = (byte)cb_stoneeffect2.SelectedIndex;
            stone[6] = (byte)cb_stoneeffect3.SelectedIndex;
            stone[7] = (byte)cb_stoneeffect4.SelectedIndex;

            data = new byte[4] { stone[4], stone[5], stone[6], stone[7] };
            data = data.OrderBy(a => a).ToArray();

            stone[4] = data[0];
            stone[5] = data[1];
            stone[6] = data[2];
            stone[7] = data[3];
        }
    }



    public class ArrayOfByteComparer : IEqualityComparer<byte[]>
    {
        public bool Equals(byte[] x, byte[] y)
        {
            return (x[0] == y[0] && x[1] == y[1]);
        }

        public int GetHashCode(byte[] num)
        {
            return num[0] ^ num[1];
        }
    }


}
