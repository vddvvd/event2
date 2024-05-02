using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ev2
{
    public partial class Form1 : Form
    {
        public event EventHandler<Point> MouseClickEvent;

        public Form1()
        {
            InitializeComponent();
            MouseClickEvent += Form1_MouseClickEvent;
        }
        private void Form1_MouseClickEvent(object sender, Point e)
        {
            label1.Text = $"X: {e.X}, Y: {e.Y}";
            label2.Text = $"X: {e.X}, Y: {e.Y}";
         
            label2.Location = new Point(e.X - label2.Width / 2, e.Y - label2.Height / 2);// переміщення
        }
        protected override void OnMouseClick(MouseEventArgs e) // обробник
        {
            
            
            MouseClickEvent?.Invoke(this, e.Location); // виклик подіїї
        }




    }
}
