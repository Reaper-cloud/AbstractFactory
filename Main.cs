using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactory.Shape;
using static AbstractFactory.ShapeFactory;
using System.Windows.Forms;

namespace AbstractFactory
{
        public partial class MainForm : Form
        {
            private IShape currentShape;
            private IShapeFactory factory;
            private ComboBox shapeSelector;
            private ComboBox colorSelector;

            public MainForm()
            {
                

                this.Width = 400;
                this.Height = 400;

                // Создание выпадающего списка для выбора формы
                shapeSelector = new ComboBox();
                shapeSelector.Location = new Point(10, 10);
                shapeSelector.Items.AddRange(new string[] { "Circle", "Square", "Triangle" });
                shapeSelector.SelectedIndexChanged += ShapeSelector_SelectedIndexChanged;

                // Создание выпадающего списка для выбора цвета
                colorSelector = new ComboBox();
                colorSelector.Location = new Point(150, 10);
                colorSelector.Items.AddRange(new string[] { "Red", "Blue" });
                colorSelector.SelectedIndexChanged += ColorSelector_SelectedIndexChanged;

                // Добавление элементов на форму
                this.Controls.Add(shapeSelector);
                this.Controls.Add(colorSelector);
            }

            private void ShapeSelector_SelectedIndexChanged(object sender, EventArgs e)
            {
                CreateShape();
                Invalidate(); // Перерисовать форму
            }

            private void ColorSelector_SelectedIndexChanged(object sender, EventArgs e)
            {
                switch (colorSelector.SelectedItem.ToString())
                {
                    case "Red":
                        factory = new RedFactory();
                        break;
                    case "Blue":
                        factory = new BlueFactory();
                        break;
                }
                CreateShape();
                Invalidate(); // Перерисовать форму
            }

            private void CreateShape()
            {
                if (shapeSelector.SelectedItem == null || factory == null) return;

                switch (shapeSelector.SelectedItem.ToString())
                {
                    case "Circle":
                        currentShape = factory.CreateCircle();
                        break;
                    case "Square":
                        currentShape = factory.CreateSquare();
                        break;
                    case "Triangle":
                        currentShape = factory.CreateTriangle();
                        break;
                }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                currentShape?.Draw(e.Graphics); // Рисуем текущую фигуру
            }
        }
    }
