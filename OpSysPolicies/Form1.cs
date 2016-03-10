using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpSysPolicies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Processes
        {
            public String processName { get; set; }
            public float processSize { get; set; }
        }
        public class Memory //:Processes
        {
            public float memoryHoleSize { get; set; }
        }
        public class ModifiedMemory //:Memory
        {
            public float memoryHoleIndex { get; set; }
            public float memoryHoleSize { get; set; }
            public String processName { get; set; }
            public float processSize { get; set; }
        }

        List<ModifiedMemory> mm = new List<ModifiedMemory>();
        List<Processes> processInfo = new List<Processes>();
        ArrayList p = new ArrayList();
        float[] memoryHoles = new float[] { 100, 200, 50, 70, 90, 350, 70, 70 };

        #region PROCESS
        private void addBt_Click(object sender, EventArgs e)
        {

        }
        private bool isProcessExisting(String processName)
        {
            if (processInfo.Exists(x => x.processName == processName))
            {
                return true;
            }
            return false;
        }
        #endregion

        private void performChoice()
        {
            //Check if process name exists. If not, process is added. If yes, prompts user.
            if (!isProcessExisting(pNameTb.Text))
            {
                processInfo.Add(new Processes { processName = pNameTb.Text, processSize = float.Parse(pSizeTb.Text) });
                if (worstFitRb.Checked)
                {
                    worstFit();
                }
                else if (bestFitRb.Checked)
                {
                    bestFit();
                }
                else if (firstFitRb.Checked)
                {
                    firstFit();
                }
                else if (nextFitRb.Checked)
                {
                    nextFit();
                }
                inPanel.Invalidate();
            }
            else
            {
                MessageBox.Show("Process with same name already exists!", "ERROR");
            }
            pNameTb.Focus();
        }

        #region MEMORY
        private void fcfs()
        {
        }
        private void sjn()
        {
        }
        private void pbs()
        {
        }
        private void rbs()
        {
        }
        #endregion
        #region POLICIES
        private void bestFit()
        {
            //Create a copy of memoryHoles so that we can make changes
            float[] mh = new float[memoryHoles.Length];
            Array.Copy(memoryHoles, mh, memoryHoles.Length);

            //Reset mm List
            mm.RemoveRange(0, mm.Count);

            for (int h = 0; h < processInfo.Count; h++)
            {
                Boolean foundHole = false;
                float minDiff = mh.Max();
                int indOfMinDiff = 0;

                //Get the bestfit memory hole's index by getting the lowest difference
                for (int m = 0; m < mh.Length; m++)
                {
                    if (processInfo[h].processSize <= mh[m])
                    {
                        float diff = mh[m] - processInfo[h].processSize;
                        if (minDiff > diff && minDiff != diff)
                        {
                            minDiff = diff;
                            indOfMinDiff = m;
                            foundHole = true;
                        }
                    }
                }

                if (foundHole)
                {
                    mm.Add(new ModifiedMemory
                            {
                                memoryHoleIndex = indOfMinDiff,
                                memoryHoleSize = mh[indOfMinDiff],
                                processName = processInfo[h].processName,
                                processSize = processInfo[h].processSize
                            });
                    mh[indOfMinDiff] = 0;
                }
                else
                {
                    MessageBox.Show("Process Name: " + processInfo[h].processName + ": Addressing Error");
                }
            }
        }
        private void worstFit()
        {
            //Create a copy of memoryHoles so that we can make changes
            float[] mh = new float[memoryHoles.Length];
            Array.Copy(memoryHoles, mh, memoryHoles.Length);

            //Reset mm List
            mm.RemoveRange(0, mm.Count);

            for (int h = 0; h < processInfo.Count; h++)
            {
                Boolean foundHole = false;
                float largest = 0;
                int indOfLargest = 0;

                //get the index of the largest memory hole
                for (int l = 0; l < mh.Length; l++)
                {
                    if (largest < mh[l])
                    {
                        largest = mh[l];
                        indOfLargest = l;
                    }
                }
                if (processInfo[h].processSize <= mh[indOfLargest])
                {
                    mm.Add(new ModifiedMemory
                    {
                        memoryHoleIndex = indOfLargest,
                        memoryHoleSize = mh[indOfLargest],
                        processName = processInfo[h].processName,
                        processSize = processInfo[h].processSize
                    });
                    mh[indOfLargest] = 0;
                    foundHole = true;
                }

                if (!foundHole)
                {
                    MessageBox.Show("Process Name: " + processInfo[h].processName + ": Addressing Error");
                }
            }
        }
        private void firstFit()
        {
            //Create a copy of memoryHoles so that we can make changes
            float[] mh = new float[memoryHoles.Length];
            Array.Copy(memoryHoles, mh, memoryHoles.Length);

            //Reset mm List
            mm.RemoveRange(0, mm.Count);

            for (int i = 0; i < processInfo.Count; i++)
            {
                Boolean foundHole = false;

                for (int j = 0; j < mh.Length; j++)
                {
                    if (processInfo[i].processSize <= mh[j])
                    {
                        foundHole = true;
                        mm.Add(new ModifiedMemory
                        {
                            memoryHoleIndex = j,
                            memoryHoleSize = mh[j],
                            processName = processInfo[i].processName,
                            processSize = processInfo[i].processSize
                        });
                        mh[j] = 0;
                        break;
                    }
                }

                if (!foundHole)
                {
                    MessageBox.Show("Process Name: " + processInfo[i].processName + ": Addressing Error");
                }
            }
        }
        private void nextFit()
        {
            //Create a copy of memoryHoles so that we can make changes
            float[] mh = new float[memoryHoles.Length];
            Array.Copy(memoryHoles, mh, memoryHoles.Length);

            //Reset mm List
            mm.RemoveRange(0, mm.Count);

            for (int i = 0; i < processInfo.Count; i++)
            {
                Boolean foundHole = false;
                int pass = 0;
                for (int j = 0; j < mh.Length; j++)
                {
                    if (processInfo[i].processSize <= mh[j])
                    {
                        pass++;
                        if (pass == 2)
                        {
                            foundHole = true;
                            mm.Add(new ModifiedMemory
                            {
                                memoryHoleIndex = j,
                                memoryHoleSize = mh[j],
                                processName = processInfo[i].processName,
                                processSize = processInfo[i].processSize
                            });
                            mh[j] = 0;
                            break;
                        }
                    }
                }

                if (!foundHole)
                {
                    MessageBox.Show("Process Name: " + processInfo[i].processName + ": Addressing Error");
                }
            }
        }
        #endregion

        private void inPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.MidnightBlue);
            StringFormat myFormat = new StringFormat()
                                    {
                                        Alignment = StringAlignment.Center,
                                        LineAlignment = StringAlignment.Center,
                                        FormatFlags = StringFormatFlags.LineLimit
                                    };
            int totalHeight = 0;
            int height;
            float holesSum = 0;

            for (int i = 0; i < memoryHoles.Length; i++)
            {
                //Draw memory
                height = (int)(memoryHoles[i] * 0.5);
                Rectangle rect = new Rectangle(35, inPanel.ClientRectangle.Top + totalHeight + 12, inPanel.Width - 75, height);
                e.Graphics.DrawRectangle(myPen, rect);
                e.Graphics.DrawString(holesSum.ToString(), new Font("Times New Roman", 12), myPen.Brush, inPanel.Width - 38, totalHeight);
                e.Graphics.DrawString(memoryHoles[i].ToString(), new Font("Times New Roman", 12), myPen.Brush, 0, totalHeight + height / 2);
                holesSum += memoryHoles[i];
                totalHeight += height;
                //Draw process
                for (int j = 0; j < mm.Count; j++)
                {
                    if (mm[j].memoryHoleIndex == i)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.AliceBlue), rect.X + 1, rect.Y + 1, rect.Width - 1, rect.Height - 1);
                        e.Graphics.DrawString(mm[j].processName + " = " + mm[j].processSize,
                                              new Font("Times New Roman", 14, FontStyle.Bold),
                                              myPen.Brush,
                                              rect,
                                              myFormat);
                    }
                }
            }
            e.Graphics.DrawString(holesSum.ToString(),
                                  new Font("Times New Roman", 12),
                                  myPen.Brush,
                                  inPanel.Width - 38,
                                  totalHeight);

            //Change inPanel position if it exceeds outPanel's size
            inPanel.Height = totalHeight + 32 + 15;
            int inPanelBottom = outPanel.Height - inPanel.Height;
            if (inPanelBottom > 0)
            {
                inPanel.Location = new Point(3, inPanelBottom);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            processInfo.Clear();
            mm.Clear();
            inPanel.Invalidate();
        }

        #region RADIO BUTTON EVENTS
        private void worstFitRb_CheckedChanged(object sender, EventArgs e)
        {
            if (worstFitRb.Checked)
            {
                worstFit();
                inPanel.Invalidate();
            }
        }
        private void bestFitRb_CheckedChanged(object sender, EventArgs e)
        {
            if (bestFitRb.Checked)
            {
                bestFit();
                inPanel.Invalidate();
            }
        }
        private void firstFitRb_CheckedChanged(object sender, EventArgs e)
        {
            if (firstFitRb.Checked)
            {
                firstFit();
                inPanel.Invalidate();
            }
        }
        private void nextFitRb_CheckedChanged(object sender, EventArgs e)
        {
            if (nextFitRb.Checked)
            {
                nextFit();
                inPanel.Invalidate();
            }
        }
        private void psRb_CheckedChanged(object sender, EventArgs e)
        {
            if (psRb.Checked)
            {
                psGb.Enabled = true;
                mpGb.Enabled = false;
            }
        }

        private void mpRb_CheckedChanged(object sender, EventArgs e)
        {
            if (mpRb.Checked)
            {
                psGb.Enabled = false;
                mpGb.Enabled = true;
            }
        }
        private void bothRb_CheckedChanged(object sender, EventArgs e)
        {
            if (bothRb.Checked)
            {
                psGb.Enabled = true;
                mpGb.Enabled = true;
                rbsRb.Enabled = false;
            }
        }
        #endregion

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                performChoice();
            }
        }

        private void doProcessBt_Click(object sender, EventArgs e)
        {
            performChoice();
        }

    }   
}
