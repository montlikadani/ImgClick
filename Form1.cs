using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImgClick {
    public partial class Form1 : Form {

        private readonly Random random = new Random();

        public Form1() {
            InitializeComponent();

            Image[] imgs = new Image[] { Properties.Resources.car, Properties.Resources.food, Properties.Resources.papucs };
            int rows = 3, columns = 6;

            for (int i = 0; i < rows; i++) {
                for (int k = 0; k < columns; k++) {
                    Button button = new Button() {
                        Text = (i * columns + k).ToString()
                    };

                    button.Click += (sender, e) => {
                        if (sender is Button btn) {
                            btn.BackgroundImage = imgs[random.Next(imgs.Length)];
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    };

                    panel.Controls.Add(button);
                }
            }
        }


    }
}
