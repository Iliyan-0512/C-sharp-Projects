using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        private Panel drawingPanel;
        private ComboBox shapeSelector;
        private Button addButton;
        private Button editButton;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent(); // Ако използваш дизайнерския изглед, това трябва да остане

            // Създаване на панел за рисуване
            drawingPanel = new Panel
            {
                Location = new Point(20, 60),
                Size = new Size(360, 300),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(drawingPanel);

            // Създаване на ComboBox за избор на фигура
            shapeSelector = new ComboBox
            {
                Location = new Point(20, 20),
                Size = new Size(100, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            shapeSelector.Items.AddRange(new string[] { "Кръг", "Квадрат", "Триъгълник" });
            shapeSelector.SelectedIndex = 0;
            this.Controls.Add(shapeSelector);

            // Създаване на бутон за добавяне на фигура
            addButton = new Button
            {
                Text = "Добави",
                Location = new Point(140, 20),
                Size = new Size(100, 30)
            };
            addButton.Click += AddShapes; // Свързване на бутона с метода AddShapes
            this.Controls.Add(addButton);

            editButton = new Button
            {
                Text = "Edit",
                Location = new Point(140, 50),
                Size = new Size(100, 30)
            };
        }

        private void AddShapes(object sender, EventArgs e)
        {
            int size = 50;
            int x = rand.Next(10, drawingPanel.Width - size - 10);
            int y = rand.Next(10, drawingPanel.Height - size - 10);

            PictureBox shapeBox = new PictureBox
            {
                Location = new Point(x, y),
                Size = new Size(size, size),
                BackColor = Color.Transparent
            };

            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                string selectedShape = shapeSelector.SelectedItem.ToString();

                switch (selectedShape)
                {
                    case "Кръг":
                        g.FillEllipse(Brushes.Blue, 0, 0, size, size);
                        break;
                    case "Квадрат":
                        g.FillRectangle(Brushes.Red, 0, 0, size, size);
                        break;
                    case "Триъгълник":
                        Point[] trianglePoints = {
                            new Point(size / 2, 0),
                            new Point(0, size),
                            new Point(size, size)
                        };
                        g.FillPolygon(Brushes.Green, trianglePoints);
                        break;
                }
            }

            shapeBox.Image = bmp;
            drawingPanel.Controls.Add(shapeBox);
        }
        private void EditShapes(object sender, EventArgs e)
        {

        }
    }
}
