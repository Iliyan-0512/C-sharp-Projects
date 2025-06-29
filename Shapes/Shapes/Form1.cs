using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        private Panel drawingPanel;
        private Panel editPanel;
        private ComboBox shapeSelector;
        private Button addButton, editButton, clearButton, deleteButton;
        private Button colorButton, saveButton, cancelButton;
        private NumericUpDown sizeSelector;
        private Random rand = new Random();
        private PictureBox selectedShape = null;

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true; // Позволява засичане на клавиши в цялата форма
            this.KeyDown += Form1_KeyDown; // Добавяме обработчик за клавиши

            // Панел за рисуване
            drawingPanel = new Panel
            {
                Location = new Point(20, 60),
                Size = new Size(360, 300),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(drawingPanel);

            // ComboBox за избор на фигури
            shapeSelector = new ComboBox
            {
                Location = new Point(20, 20),
                Size = new Size(100, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            shapeSelector.Items.AddRange(new string[] { "Кръг", "Квадрат", "Триъгълник" });
            shapeSelector.SelectedIndex = 0;
            this.Controls.Add(shapeSelector);

            // Бутон "Добави"
            addButton = new Button
            {
                Text = "Добави",
                Location = new Point(140, 20),
                Size = new Size(100, 30)
            };
            addButton.Click += AddShapes;
            this.Controls.Add(addButton);

            // Бутон "Редактирай"
            editButton = new Button
            {
                Text = "Редактирай",
                Location = new Point(250, 20),
                Size = new Size(100, 30)
            };
            editButton.Click += EditShapes;
            this.Controls.Add(editButton);

            // Бутон "Изчисти екрана"
            clearButton = new Button
            {
                Text = "Изчисти екрана",
                Location = new Point(370, 20),
                Size = new Size(200, 30)
            };
            clearButton.Click += ClearShapes;
            this.Controls.Add(clearButton);

            // Бутон "Изтрий последната фигура"
            deleteButton = new Button
            {
                Text = "Изтрий последната фигура",
                Location = new Point(590, 20),
                Size = new Size(220, 30)
            };
            deleteButton.Click += DeleteLastShapes;
            this.Controls.Add(deleteButton);

            // Панел за редактиране (скрит първоначално)
            editPanel = new Panel
            {
                Location = new Point(400, 60),
                Size = new Size(200, 150),
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };
            this.Controls.Add(editPanel);

            // Бутон за смяна на цвят
            colorButton = new Button
            {
                Text = "Цвят",
                Location = new Point(10, 10),
                Size = new Size(80, 30)
            };
            colorButton.Click += ChangeColor;
            editPanel.Controls.Add(colorButton);

            // NumericUpDown за размера
            sizeSelector = new NumericUpDown
            {
                Location = new Point(10, 50),
                Size = new Size(80, 30),
                Minimum = 10,
                Maximum = 200,
                Value = 50
            };
            editPanel.Controls.Add(sizeSelector);

            // Бутон "Запази"
            saveButton = new Button
            {
                Text = "Запази",
                Location = new Point(10, 90),
                Size = new Size(80, 30)
            };
            saveButton.Click += saveChanges;
            editPanel.Controls.Add(saveButton);

            // Бутон "Отказ"
            cancelButton = new Button
            {
                Text = "Отказ",
                Location = new Point(100, 90),
                Size = new Size(80, 30)
            };
            cancelButton.Click += (s, e) => editPanel.Visible = false;
            editPanel.Controls.Add(cancelButton);
        }

        private void AddShapes(object sender, EventArgs e)
        {
            int size = 50;
            int x = rand.Next(10, drawingPanel.Width - size - 10);
            int y = rand.Next(10, drawingPanel.Height - size - 10);
            Color defaultColor = Color.Blue;

            PictureBox shapeBox = new PictureBox
            {
                Location = new Point(x, y),
                Size = new Size(size, size),
                BackColor = Color.Transparent,
                Tag = new Tuple<string, Color>(shapeSelector.SelectedItem.ToString(), defaultColor)
            };

            DrawShape(shapeBox, size, defaultColor);
            shapeBox.Click += SelectShape;
            drawingPanel.Controls.Add(shapeBox);
        }

        private void DrawShape(PictureBox shapeBox, int size, Color color)
        {
            string shapeType = ((Tuple<string, Color>)shapeBox.Tag).Item1;
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                switch (shapeType)
                {
                    case "Кръг":
                        g.FillEllipse(new SolidBrush(color), 0, 0, size, size);
                        break;
                    case "Квадрат":
                        g.FillRectangle(new SolidBrush(color), 0, 0, size, size);
                        break;
                    case "Триъгълник":
                        Point[] trianglePoints = {
                            new Point(size / 2, 0),
                            new Point(0, size),
                            new Point(size, size)
                        };
                        g.FillPolygon(new SolidBrush(color), trianglePoints);
                        break;
                }
            }
            shapeBox.Image = bmp;
        }

        private void SelectShape(object sender, EventArgs e)
        {
            selectedShape = sender as PictureBox;
            editPanel.Visible = true;
            sizeSelector.Value = selectedShape.Width;
        }

        private void MoveShape(int deltaX, int deltaY)
        {
            if (selectedShape == null) return;

            int newX = selectedShape.Location.X + deltaX;
            int newY = selectedShape.Location.Y + deltaY;

            // Проверка дали не излиза извън панела
            if (newX >= 0 && newX + selectedShape.Width <= drawingPanel.Width &&
                newY >= 0 && newY + selectedShape.Height <= drawingPanel.Height)
            {
                selectedShape.Location = new Point(newX, newY);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (selectedShape == null) return;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    MoveShape(-5, 0);
                    break;
                case Keys.Right:
                    MoveShape(5, 0);
                    break;
                case Keys.Up:
                    MoveShape(0, -5);
                    break;
                case Keys.Down:
                    MoveShape(0, 5);
                    break;
            }
        }

        private void ClearShapes(object sender, EventArgs e)
        {
            drawingPanel.Controls.Clear();
            selectedShape = null;
            editPanel.Visible = false;
        }

        private void DeleteLastShapes(object sender, EventArgs e)
        {
            if (drawingPanel.Controls.Count > 0)
            {
                Control lastShape = drawingPanel.Controls[drawingPanel.Controls.Count - 1];
                drawingPanel.Controls.Remove(lastShape);
            }
        }
    }
}
