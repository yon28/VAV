using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
//471
namespace bee
{
    class Renderer//визуализатор
    {
        private World world;
        private HiveForm hiveForm;
        private FieldForm fieldForm;

        private Dictionary<Flower, PictureBox> flowerLookup = new Dictionary<Flower, PictureBox>();
        public List<Flower> deadFlowers = new List<Flower>();
        private Dictionary<Bee, BeeControl> beeLookup = new Dictionary<Bee, BeeControl>();
        public List<Bee> retiredBees = new List<Bee>();

        public Renderer(World world, HiveForm hiveForm, FieldForm fieldForm)
        {
            this.world = world;
            this.hiveForm = hiveForm;
            this.fieldForm = fieldForm;
        }

        public void Render()//рисует
        {
            DrawBees();
            DrawFlowers();
            RemoveRetiredBeesAndDeadFlowers();
        }

        public void Reset()//очищает
        {
            foreach (PictureBox flower in flowerLookup.Values)
            {
                fieldForm.Controls.Remove(flower);
                flower.Dispose();
            }
            foreach (BeeControl bee in beeLookup.Values)
            {
                hiveForm.Controls.Remove(bee);
                fieldForm.Controls.Remove(bee);
                bee.Dispose();
            }
            flowerLookup.Clear();
            beeLookup.Clear();
        }

        private void DrawFlowers()
        {
            foreach (Flower flower in world.Flowers)
                if (!flowerLookup.ContainsKey(flower))
                {
                    PictureBox flowerControl = new PictureBox()
                    {
                        Width = 45,
                        Height = 55,
                        BackColor = Color.Transparent,
                        Image = Properties.Resources._8,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = flower.Location
                    };
                    flowerControl.BackColor = Color.Transparent;
                    flowerLookup.Add(flower, flowerControl);
                    fieldForm.Controls.Add(flowerControl);
                }
            foreach (Flower flower in flowerLookup.Keys)
            {
                if (!world.Flowers.Contains(flower))
                {
                    PictureBox flowerControlToRemove = flowerLookup[flower];
                    fieldForm.Controls.Remove(flowerControlToRemove);
                    flowerControlToRemove.Dispose();
                    deadFlowers.Add(flower);
                }
            }
        }

        private void DrawBees()//587
        {
            BeeControl beeControl;
            foreach (Bee bee in world.Bees)
            {
                beeControl = GetBeeControl(bee);
                if (bee.InsideHive)
                {
                    if (fieldForm.Controls.Contains(beeControl))
                    {
                        MoveBeeFromFieldToHive(beeControl);
                    }
                }
                else if (hiveForm.Controls.Contains(beeControl))
                    {
                        MoveBeeFromHiveToField(beeControl);
                    }
                beeControl.Location = bee.Location;
            }
            foreach (Bee bее in beeLookup.Keys)
            {
                if (!world.Bees.Contains(bее))
                {
                    beeControl = beeLookup[bее];
                    if (fieldForm.Controls.Contains(beeControl))
                    {
                        fieldForm.Controls.Remove(beeControl);
                    }
                    if (hiveForm.Controls.Contains(beeControl))
                    {
                        hiveForm.Controls.Remove(beeControl);
                    }
                    beeControl.Dispose();
                    retiredBees.Add(bее);
                }
            }
        }

        private BeeControl GetBeeControl(Bee bee)
        {
            BeeControl beeControl;
            if (!beeLookup.ContainsKey(bee))
            {
                beeControl = new BeeControl() { Width = 20, Height = 20 };
                beeLookup.Add(bee, beeControl);
                hiveForm.Controls.Add(beeControl);
                beeControl.BringToFront();
            }
            else
            {
                beeControl = beeLookup[bee];
            }
            return beeControl;
        }

        private void MoveBeeFromHiveToField(BeeControl beeControl)
        {
            hiveForm.Controls.Remove(beeControl);
            beeControl.Size = new Size(20, 20);
            fieldForm.Controls.Add(beeControl);
            beeControl.BringToFront();
        }

        private void MoveBeeFromFieldToHive(BeeControl beeControl)
        {
            fieldForm.Controls.Remove(beeControl);
            beeControl.Size = new Size(20, 20);
            hiveForm.Controls.Add(beeControl);
            beeControl.BringToFront();
        }

        private void RemoveRetiredBeesAndDeadFlowers()
        {
            foreach (Bee bee in retiredBees)
            {
                beeLookup.Remove(bee);
            }
            retiredBees.Clear();
            foreach (Flower flower in deadFlowers)
            {
                flowerLookup.Remove(flower);
            }
            deadFlowers.Clear();
        }

        public static Bitmap ResizeImage(Bitmap picture, int width, int height)
        {
            Bitmap resizedPicture = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedPicture))
            {
                graphics.DrawImage(picture, 0, 0, width, height);
            }
            return resizedPicture;
        }
    }
}


