using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace bee
{
    public partial class Form1 : Form
    {
        Queen queen;
        World world;
        private Random random = new Random();
        private DateTime start = DateTime.Now;
        private DateTime end;
        private int framesRun = 0; //сколько кадров уже показано
        private HiveForm hiveForm = new HiveForm();
        private FieldForm fieldForm = new FieldForm();
        private Renderer renderer;

        public Form1()
        {
            InitializeComponent();
            //world = new World(new BeeMessage(SendMessage));
            MoveChildForms();
            hiveForm.Show(this);
            fieldForm.Show(this);
            ResetSimulator();

            timer1.Interval = 50; //миллисекунд
            timer1.Tick += new EventHandler(RunFrame);
            timer1.Enabled = false;
            UpdateStats(new TimeSpan());//новый отсчет времени

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Eggcare", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);
            queen = new Queen(workers);
        }

        private void MoveChildForms()
        {
            hiveForm.Location = new Point(Location.X + Width + 10, Location.Y);
            fieldForm.Location = new Point(Location.X,
            Location.Y + Math.Max(Height, hiveForm.Height) + 10);
        }

        private void ResetSimulator()
        {
            framesRun = 0;
            world = new World(new BeeMessage(SendMessage));
            renderer = new Renderer(world, hiveForm, fieldForm);
        }

        private void UpdateStats(TimeSpan frameDuration) //стр.549
        {
            Bees.Text = world.Bees.Count.ToString();
            Flowers.Text = world.Flowers.Count.ToString();
            HoneyInHive.Text = String.Format("{0:f3}", world.Hive.Honey);
            FramesRun.Text = framesRun.ToString();
            double nectar = 0;
            foreach (Flower flower in world.Flowers)
            {
                nectar += flower.Nectar;
            }
            NectarInFlowers.Text = String.Format("{0:f3}", nectar);

            double milliseconds = frameDuration.TotalMilliseconds;
            if (milliseconds != 0.0)
            {
                FrameRate.Text = string.Format("{0:f0}({1:f1}ms)", 1000 / milliseconds, milliseconds);
            }
            else
            {
                FrameRate.Text = "N/A";
            }
            //listBox1.Items.Clear();
            //foreach (var bee in world.Bees)
            //{
            //    listBox1.Items.Add(bee.Location.X.ToString() + "," + bee.Location.Y.ToString());
            //}
        }

        private void timer1_Tick(object sender, EventArgs e) //550
        {
            //  Console.WriteLine(DateTime.Now.ToString());
        }

        public void RunFrame(object sender, EventArgs e) //552
        {
            framesRun++;//увеличить количество кадров
            world.Go(random);
            renderer.Render();
            end = DateTime.Now;
            TimeSpan frameDuration = end - start;
            start = end;
            UpdateStats(frameDuration);
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
            renderer.Reset();
            ResetSimulator();
            //framesRun = 0;
            //world = new World(new BeeMessage(SendMessage));
            if (!timer1.Enabled)
                toolStrip1.Items[0].Text = "Start simulation";
        }

        private void SendMessage(int ID, string Message)//557,561
        {
            statusStrip1.Items[0].Text = "Bee №" + ID + ":" + Message;
            var beeGroups =
                            from bee in world.Bees
                            group bee by bee.CurrentState into beeGroup
                            orderby beeGroup.Key
                            select beeGroup;
            listBox1.Items.Clear();
            foreach (var group in beeGroups)
            {
                string s;
                if (group.Count() == 1)
                    s = "";
                else
                    s = "s";
                listBox1.Items.Add(group.Key.ToString() + ":"
                + group.Count() + " bee" + s);
                if (group.Key == Bee.BeeState.Idle
                && group.Count() == world.Bees.Count()
                && framesRun > 0)
                {
                    listBox1.Items.Add("Simulation ended: all bees are idle");

                    toolStrip1.Items[0].Text = "Simulation ended";
                    statusStrip1.Items[0].Text = "Simulation ended";
                    timer1.Enabled = false;
                }
            }
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Для этого задания рабочих нет "
                + workerBeeJob.Text + "Матка говорит...");
            else
                MessageBox.Show("Задание " + workerBeeJob.Text + " будет закончено через "
                + shifts.Value + " смен ", " Матка говорит...");
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Worker nanny = new Worker(Job.EggCare, 454);
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
                        framesRun = (int)bf.Deserialize(input);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to read the simulator file\r\n" + ex.Message,
                    "Bee Simulator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    world = currentWorld;
                    framesRun = currentFramesRun;
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
            renderer.Reset();
            renderer = new Renderer(world, hiveForm, fieldForm);//689

        }

        //BeeControl control = null;
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (control == null)
        //    {
        //        control = new BeeControl()
        //        {
        //            Location = new Point(100, 100)
        //        };
        //        Controls.Add(control);
        //    }
        //    else
        //    {
        //        using (control)
        //        {
        //            Controls.Remove(control);
        //        }
        //    }
        //}

        private void Form1_Move(object sender, EventArgs e)
        {
            MoveChildForms();
        }


    }
}
