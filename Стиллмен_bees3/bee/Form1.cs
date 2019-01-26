using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace bee
{
    public partial class Form1 : Form
    {
        World world;
        private int framesRun = 0; //сколько кадров уже показано//+
        private FieldForm fieldForm = new FieldForm();
        private HiveForm hiveForm = new HiveForm();
        private Renderer renderer;

        public Form1()
        {
            InitializeComponent();
            world = new World(new BeeMessage(SendMessage));//--
            MoveChildForms();
            fieldForm.Show(this);
            hiveForm.Show(this);

            framesRun = world.framesRun;
            ResetSimulator();//+
            timer1.Interval = 70; //миллисекунд
            timer1.Tick += new EventHandler(RunFrame);
            timer1.Enabled = true;
            UpdateStats();// new TimeSpan());//новый отсчет времени//+
        }

        private void SendMessage(int ID, string Message)//557,561
        {
            listBox1.Items.Clear();
            world.SendMessage1(ID, Message);
            foreach (var message in world.listBox1Items)
            {
                listBox1.Items.Add(message);
            }
            statusStrip1.Items[0].Text = world.statusStrip1Items0Text;
        }

        public void RunFrame(object sender, EventArgs e) //552
        {
            world.RunFrame(sender);
            UpdateStats();
            hiveForm.Invalidate();
            fieldForm.Invalidate();
        }

        public List<string> Facts = new List<string>();
        private void UpdateStats()//TimeSpan frameDuration) //стр.549      
        {
            Facts = world.GetList();

            Bees.Text = Facts[0];
            HoneyInHive.Text = Facts[1];
            Flowers.Text = Facts[2];
            NectarInFlowers.Text = Facts[3];
            FramesRun.Text = Facts[4];

            //double milliseconds = frameDuration.TotalMilliseconds;
            //if (milliseconds != 0.0)
            //{
            //   // FrameRate.Text = string.Format("{0:f0}({1:f1}ms)", 800 / milliseconds, milliseconds);
            //}
            //else
            //{
            //   // FrameRate.Text = "N/A";
            //}
        }





        private void ResetSimulator()
        {
            world.framesRun = 0;//+
            framesRun = world.framesRun;
            world = new World(new BeeMessage(SendMessage));//+
            renderer = new Renderer(world, hiveForm, fieldForm);
        }

        private void MoveChildForms()
        {
            hiveForm.Location = new Point(Location.X + Width + 10, Location.Y);
            fieldForm.Location = new Point(Location.X, Location.Y + Math.Max(Height, hiveForm.Height) + 10);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)//616
        {
            Graphics g = e.Graphics;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            renderer.AnimateBees();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            MoveChildForms();
        }

        private void timer1_Tick(object sender, EventArgs e) //550
        {
            //  Console.WriteLine(DateTime.Now.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Worker nanny = new Worker(Job.EggCare, 454);
        }

        private void StartSimulation_Click(object sender, EventArgs e) //554
        {
            if (timer1.Enabled)
            {
                toolStrip1.Items[0].Text = "Resume simulation";
                timer1.Stop();
            }
            else
            {
                toolStrip1.Items[0].Text = "Pause simulation";
                timer1.Start();
            }
        }

        private void Reset_Click(object sender, EventArgs e) //557
        {
            ResetSimulator();
            if (!timer1.Enabled)
            {
                toolStrip1.Items[0].Text = "Start simulation";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            bool enabled = timer1.Enabled;
            if (enabled)
            {
                timer1.Stop();
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Simulator File (*.bees)|* .bees";
                saveDialog.CheckPathExists = true;
                saveDialog.Title = "Choose a file to save the current simulation";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        using (Stream output = File.OpenWrite(saveDialog.FileName))
                        {
                            bf.Serialize(output, world);
                            bf.Serialize(output, framesRun);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to save the simulator file\r\n" + ex.Message,
                        "Bee Simulator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (enabled)
            {
                timer1.Start();
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            World currentWorld = world;
            int currentFramesRun = framesRun;
            bool enabled = timer1.Enabled;
            if (enabled)
                timer1.Stop();
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "SimulatorFile(*.bees)|*.bees";
            openDialog.CheckPathExists = true;
            openDialog.CheckFileExists = true;
            openDialog.Title = "Choose a file with a simulation to load";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (Stream input = File.OpenRead(openDialog.FileName))
                    {
                        world = (World)bf.Deserialize(input);
                        world.framesRun = (int)bf.Deserialize(input);//
                        framesRun = world.framesRun;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to read the simulator file\r\n" + ex.Message,
                    "Bee Simulator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    world = currentWorld;
                    world.framesRun = currentFramesRun;//
                    framesRun = world.framesRun;
                }
            }
            world.Hive.MessageSender = new BeeMessage(SendMessage);
            foreach (Bee bee in world.Bees)
            {
                bee.MessageSender = new BeeMessage(SendMessage);
            }
            if (enabled)
            {
                timer1.Start();
            }
            renderer = new Renderer(world, hiveForm, fieldForm);//689
        }




    }
}
